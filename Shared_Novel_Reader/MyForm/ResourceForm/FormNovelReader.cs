using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.models;
using Shared_Novel_Reader.Tools;

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
                    col[3] = Convert.ToString(0);
                    col[4] = Convert.ToString(chapter.ChapTitle);
                    this.DataGridViewList.Rows.Add(col);
                }
            }
            this.DataGridViewList.Rows[0].Selected = true;
            int volNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[1].Value);
            int chapNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[2].Value);
            LoadContent(volNum, chapNum);
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
                MessageBox.Show("在线图书章节列表查询失败");
            }
            else if (res.Data["ChapterList"].ToString() == "")
            {
                MessageBox.Show("在线图书章节为空");
            }
            else
            {
                JArray ChapterListJson = (JArray)res.Data["ChapterList"];
                this.DataGridViewList.Rows.Clear();
                int index = 0,num = 0;
                foreach (var chapter in ChapterListJson)
                {
                    string[] col = new string[5];
                    string ChapterName = chapter["VolNum"] + "\t第" + chapter["ChapterNum"] + "章\t" + chapter["ChapterTitle"];
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
                    MessageBox.Show("指定章节超出索引范围");
                    this.DataGridViewList.Rows[0].Selected = true;
                    LoadLocalContent(Convert.ToInt32(this.DataGridViewList.Rows[0].Cells[1].Value), Convert.ToInt32(this.DataGridViewList.Rows[0].Cells[2].Value));
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
                LoadLocalContent(volnum, chapnum);
            else
                LoadInternetContent(bookid,volnum, chapnum , chapTitle);
        }

        /// <summary>
        /// 加载本地图书章节内容
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


            // 发送请求
            var ContentResult = Task<MyResponse>.Run(() => Tools.API.User.Resource.SearchContent(ReqJson));

            MyResponse res = await ContentResult;
            /// 返回格式
            if (res == null || !res.Result)
            {
                // 清除残留数据
                MessageBox.Show("在线图书章节内容查询失败");
                this.DataGridViewContent.Rows.Add("在线图书章节内容查询失败");
                return;
            }
            else if (res.Data["ChapterContent"].ToString() == "")
            {
                MessageBox.Show("在线图书章节内容为空");
                this.DataGridViewContent.Rows.Add("在线图书章节内容为空");
                return;
            }
            else
            {
                JArray ContentArray = (JArray)res.Data["ChapterContent"];
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


            MessageBox.Show("章节最新内容资源不存在");
            return;
        }



        private void DataGridViewList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            int volNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[1].Value);
            int chapNum = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[2].Value);
            int bookid = Convert.ToInt32(this.DataGridViewList.Rows[index].Cells[3].Value);
            string chaptitle = Convert.ToString(this.DataGridViewList.Rows[index].Cells[4].Value);
            LoadContent(volNum, chapNum, bookid, chaptitle);
        }
    }
}
