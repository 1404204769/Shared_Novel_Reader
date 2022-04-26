using log4net;
using Newtonsoft.Json.Linq;
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
    public partial class FormUserApplication : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormUserApplication));

        public bool IsFindAll = true;
        public string ProviderIDStr = String.Empty;
        public string ProcessorStr = String.Empty;
        public string FinishStr = String.Empty;
        public int Limit = 0;// 暂时用不到
        public int Offset = 0;// 暂时用不到
        public FormUserApplication()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 查询所有
        /// </summary>
        public async void LoadApplication()
        {
            JObject ReqJson = new JObject();
            JArray Filter = new JArray();
            ReqJson["Limit"] = 0;
            ReqJson["Offset"] = 0;
            ReqJson["Finish"] = false;
            ReqJson["Processor"] = "root";
            ReqJson["Provider_ID"] = 1;

            if (!IsFindAll)
            {
                if (ProviderIDStr != String.Empty)
                {
                    ReqJson["Provider_ID"] = Convert.ToInt32(ProviderIDStr);
                    Filter.Add("Provider_ID");
                }
                if (ProcessorStr != String.Empty)
                {
                    ReqJson["Processor"] = ProcessorStr;
                    Filter.Add("Processor");
                }
                if (FinishStr != String.Empty && FinishStr != "无")
                {
                    if (FinishStr == "已处理")
                    {
                        // 已处理
                        ReqJson["Finish"] = true;
                    }
                    else
                    {
                        // 未处理
                        ReqJson["Finish"] = false;
                    }
                    Filter.Add("Finish");
                }
            }
            ReqJson["Filter_Col"] = Filter;

            // 发送请求
            var ApplicationListResult = Task<MyResponse>.Run(() => Tools.API.Admin.Application.FindApplication(ReqJson));

            MyResponse res = await ApplicationListResult;
            

            // 加载前把残留的数据删除
            DataGridViewUserApplication.Rows.Clear();

            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("用户申请列表查询失败");
            }
            else if (res.Data["ApplicationList"].ToString() == "")
            {
                log.Info("用户申请列表为空");
            }
            else
            {

                string[][] ApplicationListStr;
                JArray ApplicationListJson = (JArray)res.Data["ApplicationList"];
                // log.Info(ApplicationListJson.ToString());
                GetApplicationList(in ApplicationListJson, out ApplicationListStr);
                for (int i = 0; i < ApplicationListJson.Count; i++)
                {
                    DataGridViewUserApplication.Rows.Add(ApplicationListStr[i]);
                }
                log.Info("用户申请列表查询成功");
            }
        }


        private void GetApplicationList(in JArray ApplicationListJson, out string[][] ApplicationListStr)
        {
            JObject MemoJson;
            ApplicationListStr = new string[ApplicationListJson.Count][];


            string[] ColName = new string[DataGridViewUserApplication.ColumnCount];
            for (int i = 0; i < DataGridViewUserApplication.ColumnCount; i++)
            {
                ColName[i] = DataGridViewUserApplication.Columns[i].Name;
            }

            for (int i = 0; i < ApplicationListJson.Count; i++)
            {
                MemoJson = JObject.Parse(ApplicationListJson[i]["Memo"].ToString());

                string[] RowData = new string[DataGridViewUserApplication.ColumnCount];
                for (int j = 0; j < DataGridViewUserApplication.ColumnCount; j++)
                {
                    if (ColName[j] == "Memo")
                    {
                        RowData[j] = MemoJson["Explain"].ToString();
                        continue;
                    }
                    RowData[j] = ApplicationListJson[i][ColName[j]].ToString();
                }

                ApplicationListStr[i] = RowData;
            }
            return;
        }

        private void ViewDetail(object sender, EventArgs e)
        {
            int RowIndex = DataGridViewUserApplication.CurrentRow.Index;
            string show = "";
            string[] ColName = new string[DataGridViewUserApplication.ColumnCount];
            string[] ColHead = new string[DataGridViewUserApplication.ColumnCount];
            for (int i = 0; i < DataGridViewUserApplication.ColumnCount; i++)
            {
                ColHead[i] = DataGridViewUserApplication.Columns[i].HeaderText.ToString();
                ColName[i] = DataGridViewUserApplication.Columns[i].Name;

            }
            for (int i = 0; i < DataGridViewUserApplication.ColumnCount; i++)
            {
                show += ColHead[i] + " : " + (string)DataGridViewUserApplication.Rows[RowIndex].Cells[ColName[i]].Value + "\n";
            }

            log.Info(show);
        }

        private void ReFind_Click(object sender, EventArgs e)
        {
            // 展示前选择搜索范围
            // 弹出确认框
            FormFilterUserApplication FilterUserApplication = new FormFilterUserApplication();
            // 初始化 如果上次有搜索则在这里恢复
            FilterUserApplication.TextProviderID.Text = this.ProviderIDStr;
            FilterUserApplication.TextProcessor.Text = this.ProcessorStr;
            if (this.FinishStr == "")
            {
                FilterUserApplication.ComboBoxFinish.SelectedItem = "无";
            }
            else
            {
                FilterUserApplication.ComboBoxFinish.SelectedItem = this.FinishStr;
            }
            DialogResult res = FilterUserApplication.ShowDialog();

            // 根据结果决定搜索范围   OK-FindAll   Yes-FindSome   Cancel-NoFInd
            if (res == DialogResult.OK)
            {
                this.IsFindAll = true;
                this.LoadApplication();
                this.Show();
            }
            else if (res == DialogResult.Yes)
            {
                this.IsFindAll = false;
                this.ProcessorStr = FilterUserApplication.TextProcessor.Text;
                this.ProviderIDStr = FilterUserApplication.TextProviderID.Text;
                this.FinishStr = FilterUserApplication.ComboBoxFinish.SelectedItem.ToString();

                this.LoadApplication();
                this.Show();
            }

            FilterUserApplication.Dispose();
        }
    }
}
