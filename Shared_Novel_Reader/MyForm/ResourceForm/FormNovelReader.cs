using System;
using System.Windows.Forms;
using Shared_Novel_Reader.models;

namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    public partial class FormNovelReader : Form
    {
        public bool IsLocal = true;// 是否是本地资源
        public string Book_Name = "";// 书名
        public int Link_Num = 0;// 本地图书保存的名称
        public int Book_ID = 0;// 网络图书的ID
        public int Part_Num = 0;// 卷数
        public int Chapter_Num = 0;// 章节数
        public int BookTarget = -1;
        public FormNovelReader(string bookname,int linknum,bool islocal)
        {
            IsLocal = islocal;
            InitializeComponent();
            LoadLocalBook(bookname, linknum);
        }


        public void LoadLocalBook(string bookname, int linknum)
        {
            if (!IsLocal) return;
            int index = -1;
            // 开始在内存中查找图书信息
            index = LocalBookShelf.FindBookInMemoryByName(bookname);

            // 如果没找到说明不在内存里,则需要从Resources文件夹内加载到内存里
            if (index == -1)
            {
                // 文件加载失败
                if (!LocalBookShelf.LoadBookByNum(linknum))
                {
                    MessageBox.Show("图书加载失败");

                    return;
                }
                index = LocalBookShelf.FindBookInMemoryByName(bookname);
                if (index == -1)
                {
                    MessageBox.Show("图书资源不存在");

                    return;
                }
            }

            /// 能运行到这里说明在index位置就是需要的图书资源
            BookTarget = index;
            Book_Name = bookname;
            Link_Num = linknum;
            this.DataGridViewList.Rows.Clear();
            foreach (var vol in models.LocalBookShelf.BookList[BookTarget].Vol_Array)
            {
                string VolName = "第" + vol.Vol_Num + "卷";
                foreach (var chapter in vol.Chapter_Array)
                {
                    string[] col = new string[5];
                    string ChapterName = VolName + "\t第" + chapter.ChapNum + "章\t" + chapter.ChapTitle;
                    col[0] = ChapterName;
                    col[1] = Convert.ToString(vol.Vol_Num);
                    col[2] = Convert.ToString(chapter.ChapNum);
                    this.DataGridViewList.Rows.Add(col);
                }
            }
            this.DataGridViewList.Rows[0].Selected = true;
            int volNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[1].Value);
            int chapNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[2].Value);
            LoadLocalContent(volNum, chapNum);
        }


        /// <summary>
        /// 加载章节内容
        /// </summary>
        /// <param name="volnum">分卷数</param>
        /// <param name="chapnum">章节数</param>
        public void LoadLocalContent(int volnum,int chapnum)
        {
            if(BookTarget == -1)
            {
                MessageBox.Show("图书内容加载失败");
                return;
            }
            /// 能运行到这里说明在index位置就是需要的图书资源
            this.DataGridViewContent.Rows.Clear();
            Book book = LocalBookShelf.BookList[BookTarget];
            if(book == null)
            {
                MessageBox.Show("图书资源不存在");
                return;
            }

            if(volnum > book.Vol_Array.Count)
            {
                MessageBox.Show("分卷资源不存在");
                return;
            }
            Vol vol = book.Vol_Array[volnum - 1];
            if (vol == null)
            {
                MessageBox.Show("分卷资源不存在");
                return;
            }

            if (chapnum > vol.Chapter_Array.Count)
            {
                MessageBox.Show("章节资源不存在");
                return;
            }
            Chapter chapter = vol.Chapter_Array[chapnum - 1];
            if (chapter == null)
            {
                MessageBox.Show("章节资源不存在");
                return;
            }

            if(chapter.ContentList.Count <= 0)
            {
                MessageBox.Show("章节内容资源不存在");
                return;
            }

            //this.DataGridViewContent.Rows[0].Cells[0].Value = chapter.ChapTitle;
            string ChapterName = "第" + volnum + "卷" + "  第" + chapter.ChapNum + "章  " + chapter.ChapTitle;
            this.DataGridViewContent.Columns[0].HeaderText = ChapterName;
            foreach (Content content in chapter.ContentList)
            {
                if (!content.Best_New) continue;
                foreach (var str in content.ContentArray)
                {
                    this.DataGridViewContent.Rows.Add(str);
                }
                Part_Num = volnum;
                Chapter_Num = chapnum;
                return;
            }
            MessageBox.Show("章节最新内容资源不存在");
            return;
        }

        private void DataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int volNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[1].Value);
            int chapNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[2].Value);
            LoadLocalContent(volNum, chapNum);
        }
    }
}
