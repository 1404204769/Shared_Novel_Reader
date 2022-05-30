using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.models;
using Shared_Novel_Reader.Tools;

namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    public partial class FormNovelReader : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormNovelReader));
        public bool IsLocal = true;// 是否是本地资源
        public string Book_Name = "";// 书名
        public int Link_Num = 0;// 本地图书保存的名称
        public int Book_ID = 0;// 网络图书的ID
        public int Part_Num = 0;// 卷数
        public int Chapter_Num = 0;// 章节数
        public int Content_Version = 0;// 章节版本
        public int BookTarget = -1;
        public int Row_Index = 0;
        public int EditRow_Index = -1;// 编辑章节的标记
        public int ContentRow_Index = 0;
        public int InternetChapterID = -1;// 在线章节ID
        public bool IsEditMode = false;// 内容是否处于编辑状态
        public List<string> content = null;
        public FormNovelReader(string bookname,int keyNum,bool islocal)
        {
            IsLocal = islocal;
            InitializeComponent();
            if (islocal)
                LoadLocalBook(bookname, keyNum);
            else
                LoadInternetBook(bookname, keyNum);
        }


        /// <summary>
        /// 加载本地图书
        /// </summary>
        /// <param name="bookname">书名</param>
        /// <param name="linknum">保存的文件名</param>
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
            LoadLocalList();
            this.DataGridViewList.Rows[0].Selected = true;
/*            int volNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[1].Value);
            int chapNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[2].Value);
            int contentversion = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[5].Value);
            LoadContent(volNum, chapNum, contentversion);*/
        }

        public void LoadLocalList()
        {
            this.DataGridViewList.Rows.Clear();
            foreach (var vol in models.LocalBookShelf.BookList[BookTarget].Vol_Array)
            {
                string VolName = "第" + vol.Vol_Num + "卷";
                foreach (var chapter in vol.Chapter_Array)
                {
                    // 如果不存在内容则跳过
                    if (chapter.ContentList.Count == 0)
                        continue;
                    int RowIndex = 0;
                    string[] col = new string[6];
                    string ChapterName = VolName + "\t第" + chapter.ChapNum + "章\t" + chapter.ChapTitle;
                    col[0] = ChapterName;
                    col[1] = Convert.ToString(vol.Vol_Num);
                    col[2] = Convert.ToString(chapter.ChapNum);
                    col[3] = Convert.ToString(BookTarget);
                    col[4] = Convert.ToString(chapter.ChapTitle);
                    System.Drawing.Color color = System.Drawing.Color.White;
                    for (int i = 0; i < chapter.ContentList.Count; i++)
                    {
                        col[5] = Convert.ToString(i);
                        if (chapter.ContentList.Count > 1)
                        {
                            // 说明版本有多个，需要标红
                            color = System.Drawing.Color.Red;
                            col[0] = ChapterName + "版本" + (i + 1);
                        }
                        RowIndex = this.DataGridViewList.Rows.Add(col);
                        this.DataGridViewList.Rows[RowIndex].DefaultCellStyle.BackColor = color;
                    }
                }
            }
        }

        /// <summary>
        /// 加载网络图书
        /// </summary>
        /// <param name="bookname">书名</param>
        /// <param name="bookid">图书ID</param>
        /// <param name="volNum">上次浏览的分卷数</param>
        /// <param name="chapNum">上次浏览的章节数</param>
        public async void LoadInternetBook(string bookname, int bookid,int volNum = 1,int chapNum = 1)
        {
            if (IsLocal) return;

            JObject ReqJson = new JObject();
            ReqJson["Book_Name"] = bookname;
            ReqJson["Book_ID"] = bookid;
            // 发送请求
            var MenuResult = Task<MyResponse>.Run(() => Tools.API.User.Resource.SearchMenu(ReqJson));

            MyResponse res = await MenuResult;
            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("在线图书章节列表查询失败");
            }
            else if (res.Data["ChapterList"].ToString() == "")
            {
                log.Info("在线图书章节为空");
            }
            else
            {
                JArray ChapterListJson = (JArray)res.Data["ChapterList"];
                this.DataGridViewList.Rows.Clear();
                int index = 0,num = 0;
                foreach (var chapter in ChapterListJson)
                {
                    string[] col = new string[5];
                    string ChapterName = "第" + chapter["VolNum"] + "卷\t第" + chapter["ChapterNum"] + "章\t" + chapter["ChapterTitle"];
                    col[0] = ChapterName;
                    col[1] = Convert.ToString(chapter["VolNum"]);
                    col[2] = Convert.ToString(chapter["ChapterNum"]);
                    col[3] = Convert.ToString(bookid);
                    col[4] = Convert.ToString(chapter["ChapterTitle"]);
                    this.DataGridViewList.Rows.Add(col);
                    if((Convert.ToInt32(chapter["VolNum"]) == volNum)&& (Convert.ToInt32(chapter["VolNum"]) == chapNum))
                    {
                        index = num;
                    }
                    num++;
                }
                if(index >= this.DataGridViewList.Rows.Count)
                {
                    log.Info("指定章节超出索引范围");
                    this.DataGridViewList.Rows[0].Selected = true;
                    LoadContent(Convert.ToInt32(this.DataGridViewList.Rows[0].Cells[1].Value), Convert.ToInt32(this.DataGridViewList.Rows[0].Cells[2].Value));
                    return;
                }
                this.DataGridViewList.Rows[index].Selected = true;
                LoadContent(volNum, chapNum, bookid);
            }

            // 给服务器发送请求
        }

        /// <summary>
        /// 加载内容
        /// </summary>
        /// <param name="volnum">分卷数</param>
        /// <param name="chapnum">章节数</param>
        /// <param name="bookid">图书ID,在线阅读时需要的参数，默认为1</param>
        /// <param name="chapTitle">章节标题,在线阅读时需要的参数，默认为空</param>
        public void LoadContent(int volnum, int chapnum,int bookid = 1,string chapTitle = "")
        {
            if (IsLocal)
                LoadLocalContent(volnum, chapnum,bookid);
            else
                LoadInternetContent(bookid,volnum, chapnum , chapTitle);
        }


        public bool IsTargetExist(int volnum, int chapnum,int contentversion)
        {
            if (BookTarget == -1)
            {
                log.Info("图书内容加载失败");
                return false;
            }
            /// 能运行到这里说明在index位置就是需要的图书资源
            this.DataGridViewContent.Rows.Clear();
            Book book = LocalBookShelf.BookList[BookTarget];
            if (book == null)
            {
                log.Info("图书资源不存在");
                return false;
            }

            if (volnum > book.Vol_Array.Count)
            {
                log.Info("分卷资源不存在");
                return false;
            }
            Vol vol = book.Vol_Array[volnum - 1];
            if (vol == null)
            {
                log.Info("分卷资源不存在");
                return false;
            }

            if (chapnum > vol.Chapter_Array.Count)
            {
                log.Info("章节资源不存在");
                return false;
            }
            Chapter chapter = vol.Chapter_Array[chapnum - 1];
            if (chapter == null)
            {
                log.Info("章节资源不存在");
                return false;
            }

            if (chapter.ContentList.Count <= contentversion)
            {
                log.Info("章节内容资源不存在");
                return false;
            }

            return true;
        }


        /// <summary>
        /// 加载本地图书章节内容
        /// </summary>
        /// <param name="volnum">分卷数</param>
        /// <param name="chapnum">章节数</param>
        /// <param name="contentversion">章节内容版本数</param>
        public void LoadLocalContent(int volnum,int chapnum,int contentversion)
        {
            if (!IsTargetExist(volnum, chapnum, contentversion)) return;
            //this.DataGridViewContent.Rows[0].Cells[0].Value = chapter.ChapTitle;
            Chapter chapter = LocalBookShelf.BookList[BookTarget].Vol_Array[volnum - 1].Chapter_Array[chapnum - 1];
            string ChapterName = "第" + volnum + "卷" + "  第" + chapter.ChapNum + "章  " + chapter.ChapTitle;
            this.DataGridViewContent.Columns[0].HeaderText = ChapterName;
            if (contentversion > chapter.ContentList.Count - 1)
            {
                log.Info("章节内容资源不存在");
                return;
            }
            this.DataGridViewContent.Rows.Clear();
            foreach (var str in chapter.ContentList[contentversion].ContentArray)
            {
                this.DataGridViewContent.Rows.Add("    "+str);
            }
            Part_Num = volnum;
            Chapter_Num = chapnum;
            Content_Version = contentversion;
            return;
        }

        /// <summary>
        /// 加载网络图书章节内容
        /// </summary>
        /// <param name="bookid">图书ID</param>
        /// <param name="volnum">分卷数</param>
        /// <param name="chapnum">章节数</param>
        public async void LoadInternetContent(int bookid,int volnum, int chapnum, string chapTitle)
        {
            if (IsLocal) return;

            JObject ReqJson = new JObject();
            ReqJson["Book_ID"] = bookid;
            ReqJson["Part_Num"] = volnum;
            ReqJson["Chapter_Num"] = chapnum;
            ReqJson["Type"] = "Read";


            // 发送请求
            var ContentResult = Task<MyResponse>.Run(() => Tools.API.User.Resource.SearchContent(ReqJson));

            MyResponse res = await ContentResult;
            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("在线图书章节内容查询失败");
                this.DataGridViewContent.Rows.Add("在线图书章节内容查询失败");
            }
            else if (res.Data["ChapterContent"].ToString() == "")
            {
                log.Info("在线图书章节内容为空");
                this.DataGridViewContent.Rows.Add("在线图书章节内容为空");
            }
            else
            {
                JArray ContentArray = (JArray)res.Data["ChapterContent"];
                InternetChapterID = Convert.ToInt32(res.Data["ChapterID"]);
                this.DataGridViewContent.Rows.Clear();
                //this.DataGridViewContent.Rows[0].Cells[0].Value = chapter.ChapTitle;
                string ChapterName = "第" + volnum + "卷" + "  第" + chapnum + "章  " + chapTitle;
                this.DataGridViewContent.Columns[0].HeaderText = ChapterName;
                foreach (string content in ContentArray)
                {
                    this.DataGridViewContent.Rows.Add(content);
                    Part_Num = volnum;
                    Chapter_Num = chapnum;
                }
                return;

            }

            log.Info("章节最新内容资源不存在");
            return;
        }

        public bool List_Open(int target)
        {
            if (target < 0) return false;
            int volNum = Convert.ToInt32(this.DataGridViewList.Rows[target].Cells[1].Value);
            int chapNum = Convert.ToInt32(this.DataGridViewList.Rows[target].Cells[2].Value);
            int bookid = 0;
            if (IsLocal)
                bookid = Convert.ToInt32(this.DataGridViewList.Rows[target].Cells[5].Value);
            else
                bookid = Convert.ToInt32(this.DataGridViewList.Rows[target].Cells[3].Value);
            string chaptitle = Convert.ToString(this.DataGridViewList.Rows[target].Cells[4].Value);
            LoadContent(volNum, chapNum, bookid, chaptitle);
            return true ;
        }



        /// <summary>
        /// 更新章节内容，如果是本地则直接更新，如果是网络则弹出确认框
        /// </summary>
        public bool Update_ChapterContent(int volnum,int chapnum,int contentVersion = 0)
        {
            if (content == null)
            {
                log.Info("目前还没有要保存的内容");
                return true;
            }
            log.Info("要保存的章节内容所在位置  分卷数: " + volnum + "  章节数:" + chapnum + "  版本数:" + contentVersion);
            // 比较一下要保存的内容是否与原版的内容不符合
            if(IsLocal)
            {
                if (!IsTargetExist(volnum, chapnum, contentVersion))
                {
                    log.Info("要保存的章节不存在");
                    return false;
                }
                Chapter chapter = LocalBookShelf.BookList[BookTarget].Vol_Array[volnum - 1].Chapter_Array[chapnum - 1];
                List<string> OldContent = chapter.ContentList[contentVersion].ContentArray;
                bool IsDifference = false;
                // 如果内容行数不一样，说明内容不一样
                if (OldContent.Count == content.Count)
                {
                    // 否则开始比较内容
                    for (int i = 0; i < this.content.Count; i++)
                    {
                        if (content[i] == OldContent[i])
                        {
                            continue;
                        }
                        else
                        {
                            IsDifference = true;
                            break;
                        }
                    }
                }
                else
                    IsDifference = true;

                // 如果相同则不做处理
                if(!IsDifference)
                {
                    log.Info("章节内容并未做出修改，无需保存");
                    return true;
                }
                // 否则覆盖掉原本的内容并将其更新时间设为最新
                chapter.ContentList[contentVersion].ContentArray.Clear();
                foreach(string s in content)
                {
                    chapter.ContentList[contentVersion].ContentArray.Add(s);
                }
                chapter.Update_Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                content.Clear();
                content = null;

            }
            log.Info("章节内容保存成功");
            return true;
        }

        private void FormNovelReader_Load(object sender, EventArgs e)
        {
/*            Type ListdgvType = this.DataGridViewList.GetType();
            PropertyInfo ListPi = ListdgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            ListPi.SetValue(this.DataGridViewList, true, null);*/
            Type ContentdgvType = this.DataGridViewContent.GetType();
            PropertyInfo ContentPi = ContentdgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            ContentPi.SetValue(this.DataGridViewContent, true, null);
        }


        private void DataGridViewList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            log.Info("DataGridViewList_CellClick");
            bool Open_New = CheckEditMode();
            if (IsEditMode && !Open_New) return;
            if (this.DataGridViewList.CurrentRow != null)
            {
                Row_Index = this.DataGridViewList.CurrentRow.Index;
            }
            else
                Row_Index = this.DataGridViewList.SelectedRows[0].Index;

            log.Info("所选行发生了更改，当前行为：" + Row_Index);
            if (Open_New)
                List_Open(Row_Index);
        }

        // 编辑模式是否可以允许执行下面的动作
        public bool CheckEditMode()
        {
            if (IsEditMode == false) return true;// 没开编辑模式当然可以关闭

            if (this.DataGridViewList.CurrentRow != null && this.DataGridViewList.CurrentRow.Index == Row_Index)
                return false;// 如果是当前目录再次被点击，则无视

            if(this.DataGridViewContent.SelectedRows.Count > 0 && this.DataGridViewContent.SelectedRows[0].Index == Row_Index) 
                return false;

            // 询问是否退出编辑模式
            DialogResult result = MessageBox.Show("确定退出编辑模式吗？", "退出编辑模式", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // 确认后的具体操作 
                // 先把编辑后的内容复制一遍
                int count = this.DataGridViewContent.Rows.Count;// 由于允许编辑最后会多一行空行
                content = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    content.Add(this.DataGridViewContent.Rows[i].Cells[0].Value.ToString());
                }
                // 判断是否需要保存
                if (!Update_ChapterContent(Part_Num, Chapter_Num, Content_Version))
                {
                    this.DataGridViewList.Rows[Row_Index].Selected = true;
                    return false;  // 保存失败则不允许移动位置
                }
                else
                {
                    // 成功则退出编辑模式
                    log.Info("退出编辑模式");
                    IsEditMode = false;// 禁止用户编辑
                    this.ContextMenuStripContent.Items[0].Visible = true;
                    this.ContextMenuStripContent.Items[1].Visible = false;
                    this.ContextMenuStripContent.Items[2].Visible = false;
                    this.ContextMenuStripContent.Items[3].Visible = false;
                    this.ContextMenuStripContent.Items[4].Visible = false;
                    this.ContextMenuStripContent.Items[5].Visible = false;
                    this.ContextMenuStripContent.Items[6].Visible = false;
                }
            }
            else
            {
                // 将目录定位重新设置在原本的位置上
                // this.DataGridViewList.Rows[this.DataGridViewList.CurrentRow.Index].Selected = false;
                this.DataGridViewContent.ClearSelection();
                this.DataGridViewList.Rows[Row_Index].Selected = true;
                //this.DataGridViewContent.CurrentCell.Value = this.DataGridViewContent.Rows[Row_Index].Cells[0].Value.ToString();    
                return false;
            }

            return true;// 一切正常可以展开新的内容替换当前编辑部分
        }

        private void DataGridViewList_SelectionChanged(object sender, EventArgs e)
        {
            log.Info("DataGridViewList_SelectionChanged");
        }


        private void UpdateChapterContent_Click(object sender, EventArgs e)
        {
            log.Info("开始进入编辑模式");
            int count = this.DataGridViewContent.Rows.Count;
            content = new List<string>();
            for (int i = 0; i < count; i++)
            {
                content.Add(this.DataGridViewContent.Rows[i].Cells[0].Value.ToString());
            }
            IsEditMode = true;// 允许用户开始编辑
            this.ContextMenuStripContent.Items[0].Visible = false;
            this.ContextMenuStripContent.Items[1].Visible = true;
            this.ContextMenuStripContent.Items[2].Visible = true;
            this.ContextMenuStripContent.Items[3].Visible = true;
            this.ContextMenuStripContent.Items[4].Visible = true;
            this.ContextMenuStripContent.Items[5].Visible = true;
            this.ContextMenuStripContent.Items[6].Visible = true;
        }

        /// 用户删除内容行
        private void ContentRow_OnRemoveStep(object sender, EventArgs e)
        {
        }


        private void MoveDownRow_Click(object sender, EventArgs e)
        {
            if (ContentRow_Index < 0)
            {
                MessageBox.Show("请先选择一行，单击以选中行");
            }
            else
            {
                if (ContentRow_Index >= this.DataGridViewContent.Rows.Count - 1)
                {
                    MessageBox.Show("此行已在底端，不能再下移！");
                }
                else
                {
                    int tempIndex = ContentRow_Index;
                    DataGridViewRow newRow = DataGridViewContent.Rows[ContentRow_Index];
                    // 删除选中的行  
                    DataGridViewContent.Rows.Remove(DataGridViewContent.Rows[ContentRow_Index]);
                    // 将拷贝的行，插入到原本选中的上一行位置  
                    DataGridViewContent.Rows.Insert(tempIndex + 1, newRow);
                    DataGridViewContent.ClearSelection();
                    // 选中最初选中的行 
                    DataGridViewContent.Rows[ContentRow_Index].Selected = false;
                    DataGridViewContent.Rows[tempIndex].Selected = true;
                }
            }
        }

        private void MoveUpRow_Click(object sender, EventArgs e)
        {
            if (ContentRow_Index < 0)
            {
                MessageBox.Show("请先选择一行，单击以选中行");
            }
            else
            {
                if (ContentRow_Index <= 0)
                {
                    MessageBox.Show("此行已在顶端，不能再上移！");
                }
                else
                {
                    // 拷贝选中的行  
                    int tempIndex = ContentRow_Index;
                    DataGridViewRow newRow = DataGridViewContent.Rows[ContentRow_Index];
                    // 删除选中的行  
                    DataGridViewContent.Rows.Remove(DataGridViewContent.Rows[ContentRow_Index]);
                    // 将拷贝的行，插入到原本选中的上一行位置  
                    DataGridViewContent.Rows.Insert(tempIndex - 1, newRow);
                    DataGridViewContent.ClearSelection();
                    // 选中最初选中的行 
                    DataGridViewContent.Rows[ContentRow_Index].Selected = false;
                    DataGridViewContent.Rows[tempIndex].Selected = true;
                }
            }
        }


        private void DataGridViewContent_SelectionChanged(object sender, EventArgs e)
        {
            if (this.DataGridViewContent.CurrentRow != null)
            {
                ContentRow_Index = this.DataGridViewContent.CurrentRow.Index;
            }
            else
                ContentRow_Index = this.DataGridViewContent.SelectedRows[0].Index;
            log.Info("所选内容行发生了更改，当前行为：" + ContentRow_Index);
            //if ( DataGridViewContent.Rows[ContentRow_Index].ReadOnly == false)
            //    DataGridViewContent.Rows[ContentRow_Index].ReadOnly = true ;// 关闭编辑模式
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            if (ContentRow_Index < 0)
            {
                MessageBox.Show("请先选择删除行，单击以选中行");
                return;
            }
            DialogResult result = MessageBox.Show("确定要删除选中行(" + ContentRow_Index + ")吗？", "删除选中行", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DataGridViewContent.Rows.Remove(DataGridViewContent.Rows[ContentRow_Index]);
            }
        }

        private void InsertUpRow_Click(object sender, EventArgs e)
        {
            string tempstr = string.Empty;
            ToolForm.FormInput edit = new ToolForm.FormInput();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                tempstr = edit.getValue();
            }
            else
                return;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(this.DataGridViewContent);
            newRow.Cells[0].Value = tempstr;
            //this.dataGridView_Task_ViewEdit.Rows.Insert(0, dr);    //添加的行作为第一行
            DataGridViewContent.Rows.Insert(ContentRow_Index, newRow);
        }

        private void InsertDownRow_Click(object sender, EventArgs e)
        {
            string tempstr = string.Empty;
            ToolForm.FormInput edit = new ToolForm.FormInput();
            if (edit.ShowDialog() == DialogResult.OK)
            {
                tempstr = edit.getValue();
            }
            else
                return;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(this.DataGridViewContent);
            newRow.Cells[0].Value = tempstr;
            //this.dataGridView_Task_ViewEdit.Rows.Insert(0, dr);    //添加的行作为第一行
            DataGridViewContent.Rows.Insert(ContentRow_Index+1, newRow);
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            ToolForm.FormInput edit = new ToolForm.FormInput();
            edit.setValue(DataGridViewContent.Rows[ContentRow_Index].Cells[0].Value.ToString());
            if (edit.ShowDialog() == DialogResult.OK)
            {
                DataGridViewContent.Rows[ContentRow_Index].Cells[0].Value = edit.getValue();
            }
        }

        private void DataGridViewList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                this.DataGridViewList.Rows[e.RowIndex].Selected = true;
                if (!IsLocal)
                {
                    this.ContextMenuStripList.Items[0].Visible = false;
                    this.ContextMenuStripList.Items[1].Visible = false;
                    this.ContextMenuStripList.Items[2].Visible = false;
                    this.ContextMenuStripList.Items[3].Visible = false;
                    return;
                }
                if (this.DataGridViewList.Rows[e.RowIndex].DefaultCellStyle.BackColor == System.Drawing.Color.Red)
                {
                    this.ContextMenuStripList.Items[2].Visible = true;
                }
                else
                    this.ContextMenuStripList.Items[2].Visible = false;
            }
        }

        

        private void InsertChapter_Click(object sender, EventArgs e)
        {
            ToolForm.FormChapterTitle FormChapterTitle = new ToolForm.FormChapterTitle();
            DialogResult res = FormChapterTitle.ShowDialog();
            if (res == DialogResult.Cancel) return;
            int volnum = FormChapterTitle.getVolNum();
            int chapnum = FormChapterTitle.getChapterNum();
            string title = FormChapterTitle.getTitle();
            List<string> content = new List<string>();
            content.Add("");
            bool insertRes = LocalBookShelf.BookList[BookTarget].InsertNewChapter(volnum, chapnum, title, content);
            if (!insertRes)
            {
                MessageBox.Show("新章节插入失败");
                return;
            }
            LoadLocalList();
            for(int i = 0; i < this.DataGridViewList.RowCount; i++)
            {
                if(Convert.ToInt32( this.DataGridViewList.Rows[i].Cells[1].Value) == volnum
                    && Convert.ToInt32(this.DataGridViewList.Rows[i].Cells[2].Value) == chapnum)
                {

                    this.DataGridViewList.Rows[i].Selected = true;
                    return;
                }
            }
            this.DataGridViewList.Rows[0].Selected = true;
            return;
        }

        private void UpdateChapter_Click(object sender, EventArgs e)
        {
            int volnum = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[1].Value.ToString());
            int chapnum = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[2].Value.ToString());
            int bookid = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[3].Value.ToString());
            string title = this.DataGridViewList.CurrentRow.Cells[4].Value.ToString();
            int version = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[5].Value.ToString());
            ToolForm.FormChapterTitle FormChapterTitle = new ToolForm.FormChapterTitle();
            FormChapterTitle.setVolNum(volnum);
            FormChapterTitle.setChapterNum(chapnum);
            FormChapterTitle.setTitle(title);
            FormChapterTitle.UnEdit();
            DialogResult res = FormChapterTitle.ShowDialog();
            if (res == DialogResult.Cancel) return;
            if(FormChapterTitle.getTitle() == title)
            {
                MessageBox.Show("修改前后章节标题相同");
                return;
            }
            DialogResult result = MessageBox.Show("确认将图书第" + volnum + "卷 第" + chapnum + "章的标题改为" + FormChapterTitle.getTitle() + "嘛？", "修改章节名称", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            bool insertRes = LocalBookShelf.BookList[BookTarget].ChangeChapterTitle(volnum, chapnum, FormChapterTitle.getTitle(), version);
            if (!insertRes)
            {
                MessageBox.Show("章节标题修改失败");
                return;
            }
            MessageBox.Show("章节标题修改成功");
            LoadLocalList();
            for (int i = 0; i < this.DataGridViewList.RowCount; i++)
            {
                if (Convert.ToInt32(this.DataGridViewList.Rows[i].Cells[1].Value) == volnum
                    && Convert.ToInt32(this.DataGridViewList.Rows[i].Cells[2].Value) == chapnum
                    && Convert.ToInt32(this.DataGridViewList.Rows[i].Cells[5].Value) == version)
                {

                    this.DataGridViewList.Rows[i].Selected = true;
                    return;
                }
            }
            this.DataGridViewList.Rows[0].Selected = true;
            return;
        }

        private void DeleteChapter_Click(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[3].Value.ToString());
            int volnum = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[1].Value.ToString());
            int chapnum = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[2].Value.ToString());
            int version = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[5].Value.ToString());
            int index = 0;
            for (int i = 0; i < this.DataGridViewList.RowCount; i++)
            {
                if (Convert.ToInt32(this.DataGridViewList.Rows[i].Cells[1].Value) == volnum
                    && Convert.ToInt32(this.DataGridViewList.Rows[i].Cells[2].Value) == chapnum
                    && Convert.ToInt32(this.DataGridViewList.Rows[i].Cells[5].Value) == version)
                {

                    index = i;
                    break;
                }
            }
            if (!LocalBookShelf.BookList[bookid].RemoveChapter(volnum, chapnum, version))
            {
                MessageBox.Show("删除章节失败");
                return;
            }

            LoadLocalList();
            this.DataGridViewList.Rows[index].Selected = true;
            log.Info("删除章节成功");
        }

        private void ChooseChapter_Click(object sender, EventArgs e)
        {
            if (this.DataGridViewList.CurrentRow.DefaultCellStyle.BackColor != System.Drawing.Color.Red)
            {
                MessageBox.Show("当前行并不存在冲突");
                return;
            }
            log.Info("开始解决冲突");
            int bookid = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[3].Value.ToString());
            int volnum = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[1].Value.ToString());
            int chapnum = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[2].Value.ToString());
            int version = Convert.ToInt32(this.DataGridViewList.CurrentRow.Cells[5].Value.ToString());
            if (!LocalBookShelf.BookList[bookid].ReduceChapterConflicts(volnum, chapnum, version))
            {
                MessageBox.Show("解决冲突失败");
                return;
            }

            // 修改颜色，删除多余的
            for(int i = 0;i < this.DataGridViewList.Rows.Count; i++)
            {
                DataGridViewRow row = this.DataGridViewList.Rows[i];
                //log.Info(row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + " " + row.Cells[5].Value.ToString());
                if ((row.Cells[1].Value.ToString() == Convert.ToString(volnum)) && 
                    (row.Cells[2].Value.ToString() == Convert.ToString(chapnum)))
                {
                    log.Info("处理 : " + row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + " " + row.Cells[5].Value.ToString());
                    if (row.Cells[5].Value.ToString() == Convert.ToString(version))
                    {
                        row.Cells[0].Value = "第" + volnum + "卷" + "\t第" + chapnum + "章\t" + row.Cells[4].Value;
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        // 将版本号更改为0，毕竟其他的被删除了
                        row.Cells[5].Value = Convert.ToString(0);
                        continue;
                    }
                    this.DataGridViewList.Rows.Remove(row);
                    i--;
                }
            }
            log.Info("解决冲突成功");

        }

        private void DataGridViewContent_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.DataGridViewContent.Rows[e.RowIndex].Selected = true;/*
                this.ContextMenuStripContent.Items[0].Visible = true;
                this.ContextMenuStripContent.Items[1].Visible = false;
                this.ContextMenuStripContent.Items[2].Visible = false;
                this.ContextMenuStripContent.Items[3].Visible = false;
                this.ContextMenuStripContent.Items[4].Visible = false;
                this.ContextMenuStripContent.Items[5].Visible = false;
                this.ContextMenuStripContent.Items[6].Visible = false;*/
                if (!IsLocal)
                {
                    this.ContextMenuStripContent.Items[0].Visible = false;
                }
            }
        }

        private async void Report_Click(object sender, EventArgs e)
        {
            if(InternetChapterID == -1)
            {
                MessageBox.Show("章节ID无效");
                return;
            }

            ToolForm.FormInput formInput = new ToolForm.FormInput();
            formInput.Text = "报告章节错误内容(章节ID:" + InternetChapterID + "  章节所属分卷:" + Part_Num + "  章节数:" + Chapter_Num+")";
            DialogResult DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;

            // 准备数据
            JObject ReqJson = new JObject();
            JObject TargetJson = new JObject();
            TargetJson["Chapter_ID"] = InternetChapterID;
            ReqJson["Content"] = formInput.getValue();
            ReqJson["Target"] = TargetJson;
            ReqJson["Type"] = "Chapter_Report";

            // 发送请求
            var ReportRes = Task<MyResponse>.Run(() => Tools.API.User.User.Report(ReqJson));

            MyResponse res = await ReportRes;

            if (res == null)
            {
                // 清除残留数据
                MessageBox.Show("网络异常，请重试");
                return;
            }
            else if (!res.Result)
            {
                MessageBox.Show("章节错误报告失败");
            }
            else if (res.Data.ToString() == "")
            {
                MessageBox.Show("数据异常，请重试");
            }
            else
            {
                MessageBox.Show("章节错误报告成功");
            }

        }
    }
}