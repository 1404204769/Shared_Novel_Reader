using log4net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.Tools;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.AdminForm.Resource
{
    public partial class FormChapterAllVersion : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormChapterAllVersion));
        string BookName;
        int BookID, PartNum, ChapterNum;
        public FormChapterContent FormChapterContent = null;
        public FormChapterAllVersion(string Book_Name,int Book_ID,int Part_Num,int Chapter_Num)
        {
            BookName = Book_Name;
            BookID = Book_ID;
            PartNum = Part_Num;
            ChapterNum = Chapter_Num;
            InitializeComponent();
            LoadChapterAllVersion();
        }

        public void DisposeFormChapterContent()
        {
            if(FormChapterContent != null)
            {
                FormChapterContent.Dispose();
            }
        }

        /// <summary>
        /// 查询指定章节所有版本
        /// </summary>
        private async void LoadChapterAllVersion()
        {
            JObject ReqJson = new JObject();
            ReqJson["SearchType"] = "ChapterVersion";
            ReqJson["Limit"] = 0;
            ReqJson["Offset"] = 0;
            ReqJson["Book_ID"] = BookID;
            ReqJson["Chapter_Num"] = ChapterNum;
            ReqJson["Part_Num"] = PartNum;

            // 发送请求
            var BookListResult = Task<MyResponse>.Run(() => Tools.API.Admin.Resource.FindResource(ReqJson));

            MyResponse res = await BookListResult;


            // 加载前把残留的数据删除
            DataGridViewResourceChapterAllVersion.Rows.Clear();

            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("章节所有版本列表查询失败");
            }
            else if (res.Data["Chapter_List"].ToString() == "")
            {
                log.Info("章节所有版本列表为空");
            }
            else
            {
                string[][] ChapterListStr;
                JArray ChapterListJson = (JArray)res.Data["Chapter_List"];
                // log.Info(ChapterListJson.ToString());
                GetChapterList(in ChapterListJson, out ChapterListStr);
                for (int i = 0; i < ChapterListJson.Count; i++)
                {
                    DataGridViewResourceChapterAllVersion.Rows.Add(ChapterListStr[i]);
                }
                log.Info("章节所有版本列表查询成功");
            }
        }


        private void GetChapterList(in JArray ChapterListJson, out string[][] ChapterListStr)
        {
            JObject MemoJson;
            ChapterListStr = new string[ChapterListJson.Count][];
            string[] ColName = new string[DataGridViewResourceChapterAllVersion.ColumnCount];
            for (int i = 0; i < DataGridViewResourceChapterAllVersion.ColumnCount; i++)
            {
                ColName[i] = DataGridViewResourceChapterAllVersion.Columns[i].Name;
            }

            for (int i = 0; i < ChapterListJson.Count; i++)
            {
                string[] RowData = new string[DataGridViewResourceChapterAllVersion.ColumnCount];
                for (int j = 0; j < DataGridViewResourceChapterAllVersion.ColumnCount; j++)
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

        private void ViewChapter_Click(object sender, EventArgs e)
        {
            // 获取当前行的下标
            int RowIndex = DataGridViewResourceChapterAllVersion.CurrentRow.Index;
            BookID = Convert.ToInt32((string)DataGridViewResourceChapterAllVersion.Rows[RowIndex].Cells[0].Value);
            PartNum = Convert.ToInt32((string)DataGridViewResourceChapterAllVersion.Rows[RowIndex].Cells[2].Value);
            ChapterNum = Convert.ToInt32((string)DataGridViewResourceChapterAllVersion.Rows[RowIndex].Cells[3].Value);
            // 展示前选择搜索范围
            // 弹出确认框
            DisposeFormChapterContent();
            int VersionNum = Convert.ToInt32((string)DataGridViewResourceChapterAllVersion.Rows[RowIndex].Cells[8].Value);
            JArray ContentArray = (JArray)JsonConvert.DeserializeObject((string)DataGridViewResourceChapterAllVersion.Rows[RowIndex].Cells[5].Value);
            string ChapterTitle = (string)DataGridViewResourceChapterAllVersion.Rows[RowIndex].Cells[4].Value;
            FormChapterContent = new FormChapterContent(BookName, PartNum, ChapterNum, ChapterTitle, VersionNum,ContentArray);
            FormChapterContent.Visible = true;
        }

        private void ViewDetails_Click(object sender, EventArgs e)
        {
            int RowIndex = DataGridViewResourceChapterAllVersion.CurrentRow.Index;
            string show = "";
            string[] ColName = new string[DataGridViewResourceChapterAllVersion.ColumnCount];
            string[] ColHead = new string[DataGridViewResourceChapterAllVersion.ColumnCount];
            for (int i = 0; i < DataGridViewResourceChapterAllVersion.ColumnCount; i++)
            {
                ColHead[i] = DataGridViewResourceChapterAllVersion.Columns[i].HeaderText.ToString();
                ColName[i] = DataGridViewResourceChapterAllVersion.Columns[i].Name;

            }
            for (int i = 0; i < DataGridViewResourceChapterAllVersion.ColumnCount; i++)
            {
                show += ColHead[i] + " : " + (string)DataGridViewResourceChapterAllVersion.Rows[RowIndex].Cells[ColName[i]].Value + "\n";
            }
            MessageBox.Show(show);
        }

        private void MyRefresh_Click(object sender, EventArgs e)
        {
            LoadChapterAllVersion();
        }
    }
}
