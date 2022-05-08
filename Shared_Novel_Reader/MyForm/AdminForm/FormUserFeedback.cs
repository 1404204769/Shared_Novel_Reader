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
using log4net;

namespace Shared_Novel_Reader.MyForm.AdminForm
{
    public partial class FormUserFeedback : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormUserFeedback));

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
                log.Info("用户意见列表查询失败");
            }
            else if(res.Data["FeedbackList"].ToString() == "")
            {
                log.Info("用户意见列表为空");
            }
            else
            {
                string[][] FeedbackListStr;
                JArray FeedbackListJson = (JArray)res.Data["FeedbackList"];
                // log.Info(FeedbackListJson.ToString());
                GetFeedbackList(in FeedbackListJson, out FeedbackListStr);
                for (int i = 0; i < FeedbackListJson.Count; i++)
                {
                    DataGridViewUserFeedback.Rows.Add(FeedbackListStr[i]);
                }
                log.Info("用户意见列表查询成功");
            }
        }


        private void GetFeedbackList(in JArray FeedbackListJson, out string[][] FeedbackListStr)
        {
            //JObject MemoJson;
            FeedbackListStr = new string[FeedbackListJson.Count][];
            string[] ColName = new string[DataGridViewUserFeedback.ColumnCount];
            for (int i = 0; i < DataGridViewUserFeedback.ColumnCount; i++)
            {
                ColName[i] = DataGridViewUserFeedback.Columns[i].Name;
            }

            for (int i = 0; i < FeedbackListJson.Count; i++)
            {
                string[] RowData = new string[DataGridViewUserFeedback.ColumnCount];
                //MemoJson = JObject.Parse(FeedbackListJson[i]["Memo"].ToString());
                for (int j = 0; j < DataGridViewUserFeedback.ColumnCount; j++)
                {
                  /*  if (ColName[j] == "Memo")
                    {
                        RowData[j] = MemoJson["Content"].ToString();
                        continue;
                    }*/
                    RowData[j] = FeedbackListJson[i][ColName[j]].ToString();
                }
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
            string[] ColName = new string[DataGridViewUserFeedback.ColumnCount];
            string[] ColHead = new string[DataGridViewUserFeedback.ColumnCount];
            for (int i = 0; i < DataGridViewUserFeedback.ColumnCount; i++)
            {
                ColHead[i] = DataGridViewUserFeedback.Columns[i].HeaderText.ToString();
                ColName[i] = DataGridViewUserFeedback.Columns[i].Name;

            }
            for (int i = 0; i < DataGridViewUserFeedback.ColumnCount; i++)
            {
                if(ColName[i] == "Memo")
                {
                    JObject MemoJson = JObject.Parse((string)DataGridViewUserFeedback.Rows[RowIndex].Cells[ColName[i]].Value);
                    show += "反馈内容:"+ MemoJson["Content"].ToString()+"\n";
                    string status = Convert.ToString(this.DataGridViewUserFeedback.Rows[RowIndex].Cells["Status"].Value);
                    if (status == "已完成" || status == "已拒绝")
                    {
                        show += "操作说明:" + MemoJson["Explain"].ToString() + "\n";
                    }
                    continue;
                }
                show += ColHead[i] + " : " + (string)DataGridViewUserFeedback.Rows[RowIndex].Cells[ColName[i]].Value + "\n";
            }
            MessageBox.Show(show);
        }

        private async void Examine(int IdeaID, bool Result, string Explain = "")
        {

            JObject ReqJson = new JObject();
            ReqJson["Idea_ID"] = IdeaID;
            ReqJson["Examine_Result"] = Result;
            ReqJson["Examine_Explain"] = Explain;

            // 发送请求
            var ExamineRes = Task<MyResponse>.Run(() => Tools.API.Admin.Feedback.ExamineFeedback(ReqJson));

            MyResponse res = await ExamineRes;

            if (res == null)
            {
                // 清除残留数据
                MessageBox.Show("网络异常，请重试");
                return;
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("审核失败:"+res.Message);
                return;
            }
            MessageBox.Show("审核成功");


            //JObject MemoJson = JObject.Parse(res.Data["Memo"].ToString());
            // 更新数据
            string[] ColName = new string[DataGridViewUserFeedback.ColumnCount];
            for (int i = 0; i < DataGridViewUserFeedback.ColumnCount; i++)
            {
                ColName[i] = DataGridViewUserFeedback.Columns[i].Name;
            }
            int RowIndex = 0;
            for (int i = 0; i < DataGridViewUserFeedback.Rows.Count; i++)
            {
                if (Convert.ToInt32(DataGridViewUserFeedback.Rows[i].Cells[0].Value) == IdeaID)
                {
                    RowIndex = i;
                    break;
                }
            }

            for (int j = 0; j < DataGridViewUserFeedback.ColumnCount; j++)
            {/*
                if (ColName[j] == "Memo")
                {
                    DataGridViewUserFeedback.Rows[RowIndex].Cells[ColName[j]].Value = MemoJson["Content"].ToString();
                    continue;
                }*/
                DataGridViewUserFeedback.Rows[RowIndex].Cells[ColName[j]].Value = res.Data[ColName[j]].ToString();
            }
            return;
        }

        private void Allow_Click(object sender, EventArgs e)
        {

            int RowIndex = DataGridViewUserFeedback.CurrentRow.Index;
            if (RowIndex < 0) return;
            string status = Convert.ToString(this.DataGridViewUserFeedback.Rows[RowIndex].Cells["Status"].Value);
            if(status == "已完成" || status == "已拒绝")
            {
                DialogResult result = MessageBox.Show("此反馈已完成,确定要重新执行操作吗？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            int IdeaID = Convert.ToInt32(this.DataGridViewUserFeedback.Rows[RowIndex].Cells[0].Value);
            ToolForm.FormInput formInput = new ToolForm.FormInput();
            formInput.Text = "审核状态->已完成:请输入通过的理由";
            DialogResult DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;

            Examine(IdeaID, true, formInput.getValue());
        }

        private void Refuse_Click(object sender, EventArgs e)
        {
            int RowIndex = DataGridViewUserFeedback.CurrentRow.Index;
            if (RowIndex < 0) return;
            string status = Convert.ToString(this.DataGridViewUserFeedback.Rows[RowIndex].Cells["Status"].Value);
            if (status == "已完成" || status == "已拒绝")
            {
                DialogResult result = MessageBox.Show("此反馈已完成,确定要重新执行操作吗？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            int IdeaID = Convert.ToInt32(this.DataGridViewUserFeedback.Rows[RowIndex].Cells[0].Value);

            ToolForm.FormInput formInput = new ToolForm.FormInput();
            formInput.Text = "审核状态->已拒绝:请输入拒绝的理由";
            DialogResult res = formInput.ShowDialog();
            if (res == DialogResult.Cancel)
                return;

            Examine(IdeaID, false, formInput.getValue());
        }
    }
}
