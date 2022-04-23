using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.Tools;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.AdminForm.Resource
{
    public partial class FormBookAllChapter : Form
    {
        int BookID, PartNum, ChapterNum;
        string BookName;
        public FormChapterAllVersion FormChapterAllVersion = null;// 章节版本
        public FormChapterContent FormChapterContent = null;// 章节内容
        public FormBookAllChapter(string Book_Name,int Book_ID)
        {
            BookName = Book_Name;
            BookID = Book_ID;
            InitializeComponent();
            LoadBookAllChapter();
        }

        public void DisposeFormChapterAllVersion()
        {
            if(FormChapterAllVersion != null)
            {
                FormChapterAllVersion.DisposeFormChapterContent();
                FormChapterAllVersion.Dispose();
            }
        }

        public void DisposeFormChapterContent()
        {
            if (FormChapterContent != null)
            {
                FormChapterContent.Dispose();
            }
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        private async void LoadBookAllChapter()
        {
            JObject ReqJson = new JObject();
            ReqJson["SearchType"] = "Chapter";
            ReqJson["Limit"] = 0;
            ReqJson["Offset"] = 0;
            ReqJson["Book_ID"] = BookID;


            // 发送请求
            var BookListResult = Task<MyResponse>.Run(() => Tools.API.Admin.Resource.FindResource(ReqJson));

            MyResponse res = await BookListResult;


            // 加载前把残留的数据删除
            DataGridViewResourceBookAllChapter.Rows.Clear();

            if (res == null || !res.Result)
            {
                // 清除残留数据
                MessageBox.Show("图书章节列表查询失败");
            }
            else if (res.Data["Chapter_List"].ToString() == "")
            {
                MessageBox.Show("图书章节列表为空");
            }
            else
            {

                string[][] ChapterListStr;
                JArray ChapterListJson = (JArray)res.Data["Chapter_List"];
                // MessageBox.Show(ChapterListJson.ToString());
                GetChapterList(in ChapterListJson, out ChapterListStr);
                for (int i = 0; i < ChapterListJson.Count; i++)
                {
                    DataGridViewResourceBookAllChapter.Rows.Add(ChapterListStr[i]);
                }
                MessageBox.Show("图书章节列表查询成功");
            }
        }


        private void GetChapterList(in JArray ChapterListJson, out string[][] ChapterListStr)
        {
            JObject MemoJson;
            ChapterListStr = new string[ChapterListJson.Count][];
            string[] ColName = new string[DataGridViewResourceBookAllChapter.ColumnCount];
            for (int i = 0; i < DataGridViewResourceBookAllChapter.ColumnCount; i++)
            {
                ColName[i] = DataGridViewResourceBookAllChapter.Columns[i].Name;
            }

            for (int i = 0; i < ChapterListJson.Count; i++)
            {
                string[] RowData = new string[DataGridViewResourceBookAllChapter.ColumnCount];
                for (int j = 0; j < DataGridViewResourceBookAllChapter.ColumnCount; j++)
                {
                    RowData[j] = ChapterListJson[i][ColName[j]].ToString();
                    if (ColName[j] == "Memo")
                    {
                        MemoJson = JObject.Parse(RowData[j]);
                        RowData[j] = MemoJson.ToString();
                    }
                }
                ChapterListStr[i] = RowData;
            }
            return;
        }

        private void ViewDetails_Click(object sender, EventArgs e)
        {
            int RowIndex = DataGridViewResourceBookAllChapter.CurrentRow.Index;
            string show = "";
            string[] ColName = new string[DataGridViewResourceBookAllChapter.ColumnCount];
            string[] ColHead = new string[DataGridViewResourceBookAllChapter.ColumnCount];
            for (int i = 0; i < DataGridViewResourceBookAllChapter.ColumnCount; i++)
            {
                ColHead[i] = DataGridViewResourceBookAllChapter.Columns[i].HeaderText.ToString();
                ColName[i] = DataGridViewResourceBookAllChapter.Columns[i].Name;

            }
            for (int i = 0; i < DataGridViewResourceBookAllChapter.ColumnCount; i++)
            {
                show += ColHead[i] + " : " + (string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[ColName[i]].Value + "\n";
            }
            MessageBox.Show(show);
        }

        private void ViewChapter_Click(object sender, EventArgs e)
        {
            // 获取当前行的下标
            int RowIndex = DataGridViewResourceBookAllChapter.CurrentRow.Index;
            BookID = Convert.ToInt32((string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[0].Value);
            PartNum = Convert.ToInt32((string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[2].Value);
            ChapterNum = Convert.ToInt32((string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[3].Value);
            // 展示前选择搜索范围
            // 弹出确认框
            DisposeFormChapterContent();
            int VersionNum = Convert.ToInt32((string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[8].Value);

            JArray ContentArray = (JArray)JsonConvert.DeserializeObject((string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[5].Value);
            string ChapterTitle = (string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[4].Value;
            FormChapterContent = new FormChapterContent(BookName, PartNum, ChapterNum,ChapterTitle, VersionNum, ContentArray);
            FormChapterContent.Visible = true;
        }

        private void MyRefresh_Click(object sender, EventArgs e)
        {
            LoadBookAllChapter();
        }

        private void ViewAllVersion_Click(object sender, EventArgs e)
        {
            // 获取当前行的下标
            int RowIndex = DataGridViewResourceBookAllChapter.CurrentRow.Index;
            BookID = Convert.ToInt32((string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[0].Value);
            PartNum = Convert.ToInt32((string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[2].Value);
            ChapterNum = Convert.ToInt32((string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[3].Value);
            // 展示前选择搜索范围
            // 弹出确认框
            DisposeFormChapterAllVersion();
            FormChapterAllVersion = new FormChapterAllVersion(BookName,BookID, PartNum, ChapterNum);
            FormChapterAllVersion.Visible = true;
        }
    }
}
