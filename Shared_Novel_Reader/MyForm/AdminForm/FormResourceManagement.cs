using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.MyForm.AdminForm.Resource;
using Shared_Novel_Reader.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.AdminForm
{
    public partial class FormResourceManagement : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormResourceManagement));

        public FormBookAllChapter FormBookAllChapter = null;
        public bool IsFindAll = true;
        public string BookNameStr = String.Empty;
        public string AuthorStr = String.Empty;
        public string PublisherStr = String.Empty;
        public int Limit = 0;// 暂时用不到
        public int Offset = 0;// 暂时用不到
        public FormResourceManagement()
        {
            InitializeComponent();
        }

        public void DisposeFormBookAllChapter()
        {
            if (FormBookAllChapter != null)
            {
                FormBookAllChapter.DisposeFormChapterAllVersion();
                FormBookAllChapter.DisposeFormChapterContent();
                FormBookAllChapter.Dispose();
            }
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        public async void LoadResourceBook()
        {
            JObject ReqJson = new JObject();
            ReqJson["SearchType"] = "Book";
            ReqJson["Limit"] = 0;
            ReqJson["Offset"] = 0;
            ReqJson["Book_Name"] = "";
            ReqJson["Author"] = "";
            ReqJson["Publisher"] = "";

            if (!IsFindAll)
            {
                if (BookNameStr != String.Empty)
                {
                    ReqJson["Book_Name"] = BookNameStr;
                }
                if (AuthorStr != String.Empty)
                {
                    ReqJson["Author"] = AuthorStr;
                }
                if (PublisherStr != String.Empty)
                {
                    ReqJson["Publisher"] = PublisherStr;
                }
            }

            // 发送请求
            var BookListResult = Task<MyResponse>.Run(() => Tools.API.Admin.Resource.FindResource(ReqJson));

            MyResponse res = await BookListResult;


            // 加载前把残留的数据删除
            DataGridViewResourceBook.Rows.Clear();

            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("图书资源列表查询失败");
            }
            else if (res.Data["Book_List"].ToString() == "")
            {
                log.Info("图书资源列表为空");
            }
            else
            {

                string[][] BookListStr;
                JArray BookListJson = (JArray)res.Data["Book_List"];
                // log.Info(BookListJson.ToString());
                GetBookList(in BookListJson, out BookListStr);
                for (int i = 0; i < BookListJson.Count; i++)
                {
                    DataGridViewResourceBook.Rows.Add(BookListStr[i]);
                }
                log.Info("图书资源列表查询成功");
            }
        }


        private void GetBookList(in JArray BookListJson, out string[][] BookListStr)
        {
            JObject MemoJson;
            BookListStr = new string[BookListJson.Count][];
            string[] ColName = new string[DataGridViewResourceBook.ColumnCount];
            for (int i = 0; i < DataGridViewResourceBook.ColumnCount; i++)
            {
                ColName[i] = DataGridViewResourceBook.Columns[i].Name;
            }

            for (int i = 0; i < BookListJson.Count; i++)
            {
                string[] RowData = new string[DataGridViewResourceBook.ColumnCount];
                for (int j = 0; j < DataGridViewResourceBook.ColumnCount; j++)
                {
                    RowData[j] = BookListJson[i][ColName[j]].ToString();
                    if(ColName[j] == "Memo")
                    {
                        MemoJson = JObject.Parse(RowData[j]);
                        RowData[j] = MemoJson.ToString();
                    }
                }
                BookListStr[i] = RowData;
            }
            return;
        }
        private void ReFind_Click(object sender, EventArgs e)
        {

            // 展示前选择搜索范围
            // 弹出确认框
            FormFilterResourceManagement FilterResourceManagement = new FormFilterResourceManagement();
            // 初始化 如果上次有搜索则在这里恢复
            FilterResourceManagement.TextAuthor.Text = this.AuthorStr;
            FilterResourceManagement.TextBookName.Text = this.BookNameStr;
            FilterResourceManagement.TextPublisher.Text = this.PublisherStr;

            DialogResult res = FilterResourceManagement.ShowDialog();

            // 根据结果决定搜索范围   OK-FindAll   Yes-FindSome   Cancel-NoFInd
            if (res == DialogResult.OK)
            {
                this.IsFindAll = true;
                this.LoadResourceBook();
                this.Show();
            }
            else if (res == DialogResult.Yes)
            {
                this.IsFindAll = false;
                this.AuthorStr = FilterResourceManagement.TextAuthor.Text;
                this.BookNameStr = FilterResourceManagement.TextBookName.Text;
                this.PublisherStr = FilterResourceManagement.TextPublisher.Text;

                this.LoadResourceBook();
                this.Show();
            }

            FilterResourceManagement.Dispose();
        }

        private void ViewDetails_Click(object sender, EventArgs e)
        {
            int RowIndex = DataGridViewResourceBook.CurrentRow.Index;
            string show = "";
            string[] ColName = new string[DataGridViewResourceBook.ColumnCount];
            string[] ColHead = new string[DataGridViewResourceBook.ColumnCount];
            for (int i = 0; i < DataGridViewResourceBook.ColumnCount; i++)
            {
                ColHead[i] = DataGridViewResourceBook.Columns[i].HeaderText.ToString();
                ColName[i] = DataGridViewResourceBook.Columns[i].Name;

            }
            for (int i = 0; i < DataGridViewResourceBook.ColumnCount; i++)
            {
                show += ColHead[i] + " : " + (string)DataGridViewResourceBook.Rows[RowIndex].Cells[ColName[i]].Value + "\n";
            }
            log.Info(show);
        }

        private void ViewChapters_Click(object sender, EventArgs e)
        {
            // 获取当前行的下标
            int RowIndex = DataGridViewResourceBook.CurrentRow.Index;
            int BookID = Convert.ToInt32((string)DataGridViewResourceBook.Rows[RowIndex].Cells[0].Value);
            string BookName = (string)DataGridViewResourceBook.Rows[RowIndex].Cells[1].Value;

            // 展示前选择搜索范围
            // 弹出确认框
            DisposeFormBookAllChapter();

            FormBookAllChapter = new FormBookAllChapter(BookName,BookID);
            FormBookAllChapter.Visible = true;
        }
    }
}
