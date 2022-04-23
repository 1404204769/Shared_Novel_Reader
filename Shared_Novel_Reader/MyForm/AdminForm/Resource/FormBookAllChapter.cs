﻿using Newtonsoft.Json;
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
        FormChapterAllVersion FormChapterAllVersion = null;
        public FormBookAllChapter(int Book_ID)
        {
            BookID = Book_ID;
            InitializeComponent();
            LoadBookAllChapter();
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
            JArray ContentJson;
            ChapterListStr = new string[ChapterListJson.Count][];

            for (int i = 0; i < ChapterListJson.Count; i++)
            {
                string ColName;
                string[] RowData = new string[DataGridViewResourceBookAllChapter.ColumnCount];
                for (int j = 0; j < DataGridViewResourceBookAllChapter.ColumnCount; j++)
                {
                    ColName = DataGridViewResourceBookAllChapter.Columns[j].Name.ToString();
                    RowData[j] = ChapterListJson[i][ColName].ToString();
                    if (ColName == "Memo")
                    {
                        MemoJson = JObject.Parse(RowData[j]);
                        RowData[j] = MemoJson.ToString();
                    }
                    else if(ColName == "Content")
                    {
                        ContentJson = (JArray)JsonConvert.DeserializeObject(RowData[j]);
                        //ContentJson = JObject.Parse(RowData[j]).ToObject<JArray>();
                        RowData[j] = ContentJson.ToString();
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
            for (int i = 0; i < DataGridViewResourceBookAllChapter.ColumnCount; i++)
            {
                show += DataGridViewResourceBookAllChapter.Columns[i].HeaderText.ToString() + " : " + (string)DataGridViewResourceBookAllChapter.Rows[RowIndex].Cells[i].Value + "\n";
            }
            MessageBox.Show(show);
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
            if (FormChapterAllVersion != null)
            {
                FormChapterAllVersion.Dispose();
            }
            FormChapterAllVersion = new FormChapterAllVersion(BookID, PartNum, ChapterNum);
            FormChapterAllVersion.Visible = true;
        }
    }
}