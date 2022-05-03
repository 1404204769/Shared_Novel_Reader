using log4net;
using Shared_Novel_Reader.models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.ToolForm
{
    public partial class FormUploadChange : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormUploadChange));
        string BookName = string.Empty;
        int LinkNum = -1;
        int BookTarget = -1; 
        public List<Tuple<int, int>> SelectList = null;
        public FormUploadChange(string bookname,int linknum)
        {
            InitializeComponent();
            BookName = bookname;
            LinkNum = linknum;
            SelectList = new List<Tuple<int, int>>(); 
            // 开始在内存中查找图书信息
            BookTarget = LocalBookShelf.FindBookInMemoryByName(BookName);

            // 如果没找到说明不在内存里,则需要从Resources文件夹内加载到内存里
            if (BookTarget == -1)
            {
                if (LinkNum < 1)
                {
                    MessageBox.Show("图书序号错误");
                    this.Dispose();
                    return;
                }
                // 文件加载失败
                if (!LocalBookShelf.LoadBookByNum(LinkNum))
                {
                    MessageBox.Show("图书加载失败");
                    this.Dispose();
                    return;
                }
                BookTarget = LocalBookShelf.FindBookInMemoryByName(BookName);
                if (BookTarget == -1)
                {
                    MessageBox.Show("图书资源不存在");
                    this.Dispose();
                    return;
                }
            }
            LoadLocalList();
        }

        public void LoadLocalList()
        {
            this.DataGridViewList.Rows.Clear();
            bool IsWrong = false;
            foreach (var vol in models.LocalBookShelf.BookList[BookTarget].Vol_Array)
            {
                string VolName = "第" + vol.Vol_Num + "卷";
                foreach (var chapter in vol.Chapter_Array)
                {
                    // 如果不存在内容则跳过
                    if (chapter.ContentList.Count == 0)
                        continue;

                    DateTime upload = DateTime.Parse(chapter.Upload_Time);
                    DateTime update = DateTime.Parse(chapter.Update_Time);
                    // 如果上传时间大于等于更新时间则说明无需上传更改
                    if (upload >= update)
                    {
                        continue;
                    }
                    // 说明不曾上传过，需要调用的是新资源接口
                    if (upload == DateTime.MinValue)
                    {
                        continue;
                    }

                    int RowIndex = 0;
                    string[] col = new string[7];
                    string ChapterName = VolName + "\t第" + chapter.ChapNum + "章\t" + chapter.ChapTitle;

                    col[0] = Convert.ToString(false);
                    col[1] = ChapterName;
                    col[2] = Convert.ToString(vol.Vol_Num);
                    col[3] = Convert.ToString(chapter.ChapNum);
                    col[4] = Convert.ToString(BookTarget);
                    col[5] = Convert.ToString(chapter.ChapTitle);
                    Color color = Color.White;
                    for (int i = 0; i < chapter.ContentList.Count; i++)
                    {
                        col[6] = Convert.ToString(i);
                        if (chapter.ContentList.Count > 1)
                        {
                            // 说明版本有多个，需要标红
                            IsWrong = true;
                            color = System.Drawing.Color.Red;
                            col[1] = ChapterName + "版本" + (i + 1);
                        }
                        // RowIndex = this.DataGridViewList.Rows.Add(col);
                        RowIndex = this.DataGridViewList.Rows.Add(col);
                        this.DataGridViewList.Rows[RowIndex].DefaultCellStyle.BackColor = color;
                    }
                }
            }
            if(this.DataGridViewList.Rows.Count == 0)
            {
                MessageBox.Show("此资源不存在需要申请更改的部分");
                this.Dispose();
            }
            if(IsWrong)
            {
                MessageBox.Show("此资源存在冲突，请先解决冲突后再上传");
                this.Dispose();
            }
        }

        private void LabelAllYes_Click(object sender, EventArgs e)
        {
            this.DataGridViewList.EndEdit();// 切记此处要加上结束编辑状态的代码
            foreach (DataGridViewRow row in this.DataGridViewList.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void LabelAllNo_Click(object sender, EventArgs e)
        {
            this.DataGridViewList.EndEdit();// 切记此处要加上结束编辑状态的代码
            /*
                当你需要保存修改过后的内容，必须将光标指向另外一行，DataGridView才 会将编辑过后的数据提交到数据缓存区，当你操作完
                DataGridview的时候，又没有移动另一行，你在上面的修改有可能还没有提交到数据缓存区，你在执行代码获取DataGridView上面修改的
                行数据时不一定能获取到修改后的内容，所以，想重新读取到修改后的内容，为了安全起见，手动执行一-下DataGridView.EndEdit()，让修
                改后的内容提交到缓存区，这样就可以读取到DataGridView修改后的内容了。
             */
            for (int i = 0; i < this.DataGridViewList.Rows.Count; i++)
            {
                DataGridViewRow row = this.DataGridViewList.Rows[i];
                row.Cells[0].Value = false;
            }
        }

        private void LabelYes_Click(object sender, EventArgs e)
        {
            SelectList.Clear();
            this.DataGridViewList.EndEdit();// 切记此处要加上结束编辑状态的代码
            foreach (DataGridViewRow row in this.DataGridViewList.Rows)
            {
                if (row.Cells[0].Value.ToString() == "True")
                {
                    SelectList.Add(new Tuple<int, int>(Convert.ToInt32( row.Cells[2].Value ),Convert.ToInt32( row.Cells[3].Value)));
                    log.Info("选中了 第"+ row.Cells[2].Value.ToString() + "卷 第"+ row.Cells[3].Value.ToString() + "章 "+ row.Cells[5].Value.ToString());
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void LabelNo_Click(object sender, EventArgs e)
        {
            this.DataGridViewList.EndEdit();// 切记此处要加上结束编辑状态的代码
            DialogResult = DialogResult.Cancel;
        }

        private void DataGridViewList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.DataGridViewList.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() == "True")
                {
                    row.Cells[0].Value = false;
                    log.Info("取消选中 第" + row.Cells[2].Value.ToString() + "卷 第" + row.Cells[3].Value.ToString() + "章 " + row.Cells[5].Value.ToString());
                }
                else
                {
                    row.Cells[0].Value = true;
                    log.Info("选中了 第" + row.Cells[2].Value.ToString() + "卷 第" + row.Cells[3].Value.ToString() + "章 " + row.Cells[5].Value.ToString());
                }
            }
        }
    }
}
