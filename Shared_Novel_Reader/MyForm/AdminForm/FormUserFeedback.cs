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
using Shared_Novel_Reader.Tools.API.Admin;

namespace Shared_Novel_Reader.MyForm.AdminForm
{
    public partial class FormUserFeedback : Form
    {
        public bool IsFindAll = true;
        public string ProviderIDStr = String.Empty;
        public string ProcessorStr = String.Empty;
        public string FinishStr = String.Empty;
        public int Limit = 0;// 暂时用不到
        public int Offset = 0;// 暂时用不到
        public FormUserFeedback()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        public async void LoadFeedback()
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
                if(ProviderIDStr != String.Empty)
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
            var FeedbackListResult = Task<MyResponse>.Run(() =>  Feedback.FindFeedback(ReqJson));

            MyResponse res = await FeedbackListResult;


            // 加载前把残留的数据删除
            DataGridViewUserFeedback.Rows.Clear();

            if (res == null || !res.Result)
            {
                // 清除残留数据
                MessageBox.Show("用户意见列表查询失败");
            }
            else if(res.Data["FeedbackList"].ToString() == "")
            {
                MessageBox.Show("用户意见列表为空");
            }
            else
            {

                string[][] FeedbackListStr;
                JArray FeedbackListJson = (JArray)res.Data["FeedbackList"];
                MessageBox.Show(FeedbackListJson.ToString());
                GetFeedbackList(in FeedbackListJson, out FeedbackListStr);
                for (int i = 0; i < FeedbackListJson.Count; i++)
                {
                    DataGridViewUserFeedback.Rows.Add(FeedbackListStr[i]);
                }
                MessageBox.Show("用户意见列表查询成功");
            }
        }


        private void GetFeedbackList(in JArray FeedbackListJson, out string[][] FeedbackListStr)
        {
            JObject MemoJson;
            FeedbackListStr = new string[FeedbackListJson.Count][];

            for (int i = 0; i < FeedbackListJson.Count; i++)
            {
                MemoJson = JObject.Parse(FeedbackListJson[i]["Memo"].ToString());
                string[] RowData = { Convert.ToString(FeedbackListJson[i]["Idea_ID"]),Convert.ToString(FeedbackListJson[i]["User_ID"]),
                    (string)FeedbackListJson[i]["Type"],MemoJson["Content"].ToString(),(string)FeedbackListJson[i]["Status"],
                    Convert.ToString(FeedbackListJson[i]["IsManage"]),Convert.ToString(FeedbackListJson[i]["Processor"]),
                    (string)FeedbackListJson[i]["Create_Time"],(string)FeedbackListJson[i]["Update_Time"]};
                FeedbackListStr[i] = RowData;
            }
            return;
        }

        private void ReFind_Click(object sender, EventArgs e)
        {
            // 展示前选择搜索范围
            // 弹出确认框
            FormFilterUserFeedback FilterUserFeedback = new FormFilterUserFeedback();
            // 初始化 如果上次有搜索则在这里恢复
            FilterUserFeedback.TextProviderID.Text = this.ProviderIDStr;
            FilterUserFeedback.TextProcessor.Text = this.ProcessorStr;
            if (this.FinishStr == "")
            {
                FilterUserFeedback.ComboBoxFinish.SelectedItem = "无";
            }
            else
            {
                FilterUserFeedback.ComboBoxFinish.SelectedItem = this.FinishStr;
            }
            DialogResult res = FilterUserFeedback.ShowDialog();

            // 根据结果决定搜索范围   OK-FindAll   Yes-FindSome   Cancel-NoFInd
            if (res == DialogResult.OK)
            {
                this.IsFindAll = true;
                this.LoadFeedback();
                this.Show();
            }
            else if (res == DialogResult.Yes)
            {
                this.IsFindAll = false;
                this.ProcessorStr = FilterUserFeedback.TextProcessor.Text;
                this.ProviderIDStr = FilterUserFeedback.TextProviderID.Text;
                this.FinishStr = FilterUserFeedback.ComboBoxFinish.SelectedItem.ToString();

                this.LoadFeedback();
                this.Show();
            }

            FilterUserFeedback.Dispose();
        }

        private void ViewDetails_Click(object sender, EventArgs e)
        {
            int RowIndex = DataGridViewUserFeedback.CurrentRow.Index;
            string show = "";
            for (int i = 0; i < DataGridViewUserFeedback.ColumnCount; i++)
            {
                show += DataGridViewUserFeedback.Columns[i].HeaderText.ToString() + " : " + (string)DataGridViewUserFeedback.Rows[RowIndex].Cells[i].Value + "\n";
            }
            MessageBox.Show(show);
        }
    }
}
