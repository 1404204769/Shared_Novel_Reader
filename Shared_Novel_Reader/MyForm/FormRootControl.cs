using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.MyForm.AdminForm;
using Shared_Novel_Reader.Tools;
using Shared_Novel_Reader.Tools.API.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm
{
    public partial class FormRootControl : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormRootControl));
        public bool IsFindAll = true;
        public string UserIDStr = String.Empty;
        public string UserNameStr = String.Empty;
        public string UserSexStr = String.Empty;
        public FormRootControl()
        {
            InitializeComponent();
            LevelInit();
        }

        /// <summary>
        /// 查询所有
        /// </summary>
        public async void LoadAllUser()
        {
            if (!IsFindAll) return;
            // 发送请求
            var UserListResult = Task<MyResponse>.Run(() => User.AllUserList());

            MyResponse res = await UserListResult;


            // 加载前把残留的数据删除
            DataGridViewUser.Rows.Clear();

            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("用户列表查询失败");
            }
            else if (res.Data["UserList"].ToString() == "")
            {
                log.Info("用户列表为空");
            }
            else
            {

                string[][] UserListStr;
                JArray UserListJson = (JArray)res.Data["UserList"];
                // log.Info(UserListJson.ToString());
                GetUserList(in UserListJson, out UserListStr);
                for (int i = 0; i < UserListJson.Count; i++)
                {
                    DataGridViewUser.Rows.Add(UserListStr[i]);
                }
                log.Info("用户列表查询成功");
            }
        }


        /// <summary>
        /// 查询部分
        /// </summary>
        public async void LoadSomeUser()
        {
            if (IsFindAll) return;

            // 数据处理
            int UserID = -1;
            if (UserIDStr != "")
            {
                UserID = Convert.ToInt32(UserIDStr);
            }

            if (UserSexStr == "无")
            {
                UserSexStr = "";
            }
            log.Info("正在查询指定用户(ID:" + UserID + ",Name:" + UserNameStr + ",Sex:" + UserSexStr + ")");

            JObject ReqJson = new JObject();
            ReqJson["User_ID"] = UserID;
            ReqJson["User_Name"] = UserNameStr;
            ReqJson["User_Sex"] = UserSexStr;
            // 发送请求
            var UserListResult = Task<MyResponse>.Run(() => User.SomeUserList(ReqJson));

            MyResponse res = await UserListResult;

            // 加载前把残留的数据删除
            DataGridViewUser.Rows.Clear();


            if (res == null || !res.Result)
            {
                // 清除残留数据
                log.Info("指定用户查询失败");
            }
            else if (res.Data["UserList"].ToString() == "")
            {
                log.Info("用户列表为空");
            }
            else
            {
                string[][] UserListStr;
                JArray UserListJson = (JArray)res.Data["UserList"];
                // log.Info(UserListJson.ToString());
                GetUserList(in UserListJson, out UserListStr);
                for (int i = 0; i < UserListJson.Count; i++)
                {
                    DataGridViewUser.Rows.Add(UserListStr[i]);
                }
                log.Info("指定用户查询成功");
            }

        }

        private void GetUserList(in JArray UserListJson, out string[][] UserListStr)
        {
            UserListStr = new string[UserListJson.Count][];

            string[] ColName = new string[DataGridViewUser.ColumnCount];
            for (int i = 0; i < DataGridViewUser.ColumnCount; i++)
            {
                ColName[i] = DataGridViewUser.Columns[i].Name;
            }

            for (int i = 0; i < UserListJson.Count; i++)
            {
                string[] RowData = new string[DataGridViewUser.ColumnCount];
                for (int j = 0; j < DataGridViewUser.ColumnCount; j++)
                {
                    if (ColName[j] == "User_Name")
                    {
                        RowData[j] = UserListJson[i]["Name"].ToString();
                        continue;
                    }
                    RowData[j] = UserListJson[i][ColName[j]].ToString();
                }

                UserListStr[i] = RowData;
            }
            return;

        }

        private void ReFind_Click(object sender, EventArgs e)
        {
            // 展示前选择搜索范围
            // 弹出确认框
            FormFilterUserManagement FilterUserList = new FormFilterUserManagement();
            // 初始化 如果上次有搜索则在这里恢复
            FilterUserList.TextUserID.Text = this.UserIDStr;
            FilterUserList.TextName.Text = this.UserNameStr;
            if (this.UserSexStr == "")
            {
                FilterUserList.ComboBoxSex.SelectedItem = "无";
            }
            else
            {
                FilterUserList.ComboBoxSex.SelectedItem = this.UserSexStr;
            }
            DialogResult res = FilterUserList.ShowDialog();

            // 根据结果决定搜索范围   OK-FindAll   Yes-FindSome   Cancel-NoFInd
            if (res == DialogResult.OK)
            {
                this.IsFindAll = true;
                this.LoadAllUser();
                this.Show();
            }
            else if (res == DialogResult.Yes)
            {
                this.IsFindAll = false;
                this.UserIDStr = FilterUserList.TextUserID.Text;
                this.UserNameStr = FilterUserList.TextName.Text;
                this.UserSexStr = FilterUserList.ComboBoxSex.SelectedItem.ToString();

                this.LoadSomeUser();
                this.Show();
            }

            FilterUserList.Dispose();
        }

        private async void ViewDetails_Click(object sender, EventArgs e)
        {
            if (DataGridViewUser.Rows.Count == 0) return;

            int RowIndex = -1;
            foreach(DataGridViewRow row in DataGridViewUser.Rows)
            {
                if(row.Selected)
                {
                    RowIndex = row.Index;
                    break;
                }
            }
            if(RowIndex == -1) return;
            string show = "";
            string[] ColName = new string[DataGridViewUser.ColumnCount];
            string[] ColHead = new string[DataGridViewUser.ColumnCount];
            for (int i = 0; i < DataGridViewUser.ColumnCount; i++)
            {
                ColHead[i] = DataGridViewUser.Columns[i].HeaderText.ToString();
                ColName[i] = DataGridViewUser.Columns[i].Name;

            }
            for (int i = 0; i < DataGridViewUser.ColumnCount; i++)
            {
                show += ColHead[i] + " : " + (string)DataGridViewUser.Rows[RowIndex].Cells[ColName[i]].Value + "\n";
            }
            if ((string)DataGridViewUser.Rows[RowIndex].Cells[7].Value == "Ban")
            {
                string Time = "";

                // 发送请求
                var SearchRes = Task<MyResponse>.Run(() => Tools.API.GPI.SearchBanTime(Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells[0].Value)));

                MyResponse res = await SearchRes;

                if (res == null)
                {
                    Time = "网络异常,请重试";
                    return;
                }
                else if (!res.Result || res.Data.ToString() == "")
                {
                    Time = "查询封号截止时间失败";
                    return;
                }
                else
                {
                    Time = res.Data["Ban_Time"].ToString();
                }
                show += "封号截止时间:" + Time;
            }

            MessageBox.Show(show);
        }


        private async void AdminControl_Click(object sender, EventArgs e)
        {

            if (DataGridViewUser.Rows.Count == 0) return;

            int RowIndex = -1;
            foreach (DataGridViewRow row in DataGridViewUser.Rows)
            {
                if (row.Selected)
                {
                    RowIndex = row.Index;
                    break;
                }
            }
            if (RowIndex == -1) return;

            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.User.AdminControl(Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells[0].Value)));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("管理员操作失败:"+res.Message);
            }
            else
            {
                MessageBox.Show(res.Message);
                for (int i = 0; i < DataGridViewUser.ColumnCount; i++)
                {
                    string colName = DataGridViewUser.Columns[i].Name;
                    if (colName == "User_Name")
                    {
                        DataGridViewUser.Rows[RowIndex].Cells[colName].Value = res.Data["Name"].ToString();
                        continue;
                    }
                    DataGridViewUser.Rows[RowIndex].Cells[colName].Value = res.Data[colName].ToString();
                }
            }

        }

        private void TabPageAdmin_Click(object sender, EventArgs e)
        {
            ReFind.PerformClick();
        }

        public async void LevelInit()
        {

            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.SearchSysOutLevel());

            MyResponse res = await SearchRes;

            if (res == null)
            {
                log.Info("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                log.Info("查询系统日志等级失败:" + res.Message);
            }
            else
            {
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"] , (bool)res.Data["WARN"]);
            }
        }

        public void RefreshLevel(bool TRACE, bool DEBUG, bool INFO, bool WARN)
        {
            if(TRACE)
            {
                this.LabelTRACEValue.Text = "已开启";
                this.BtnTRACEOpen.Visible = false;
                this.BtnTRACEClose.Visible = true;
            }
            else
            {
                this.LabelTRACEValue.Text = "未开启";
                this.BtnTRACEOpen.Visible = true;
                this.BtnTRACEClose.Visible = false;
            }
            if (DEBUG)
            {
                this.LabelDEBUGValue.Text = "已开启";
                this.BtnDEBUGOpen.Visible = false;
                this.BtnDEBUGClose.Visible = true;
            }
            else
            {
                this.LabelDEBUGValue.Text = "未开启";
                this.BtnDEBUGOpen.Visible = true;
                this.BtnDEBUGClose.Visible = false;
            }
            if (INFO)
            {
                this.LabelINFOValue.Text = "已开启";
                this.BtnINFOOpen.Visible = false;
                this.BtnINFOClose.Visible = true;
            }
            else
            {
                this.LabelINFOValue.Text = "未开启";
                this.BtnINFOOpen.Visible = true;
                this.BtnINFOClose.Visible = false;
            }
            if (WARN)
            {
                this.LabelWARNValue.Text = "已开启";
                this.BtnWARNOpen.Visible = false;
                this.BtnWARNClose.Visible = true;
            }
            else
            {
                this.LabelWARNValue.Text = "未开启";
                this.BtnWARNOpen.Visible = true;
                this.BtnWARNClose.Visible = false;
            }
        }

        private async void BtnTRACEOpen_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "TRACE";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("打开系统日志等级(TRACE)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("打开系统日志等级(TRACE)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }
        }

        private async void BtnTRACEClose_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "TRACE";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("关闭系统日志等级(TRACE)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("关闭系统日志等级(TRACE)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnDEBUGOpen_Click(object sender, EventArgs e)
        {

            JObject ReqJson = new JObject();
            ReqJson["Level"] = "DEBUG";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("打开系统日志等级(DEBUG)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("打开系统日志等级(DEBUG)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }
        }

        private async void BtnDEBUGClose_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "DEBUG";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("关闭系统日志等级(DEBUG)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("关闭系统日志等级(DEBUG)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnINFOOpen_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "INFO";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("打开系统日志等级(INFO)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("打开系统日志等级(INFO)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }
        private async void BtnINFOClose_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "INFO";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("关闭系统日志等级(INFO)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("关闭系统日志等级(INFO)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnWARNOpen_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "WARN";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("打开系统日志等级(WARN)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("打开系统日志等级(WARN)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnWARNClose_Click(object sender, EventArgs e)
        {
            JObject ReqJson = new JObject();
            ReqJson["Level"] = "WARN";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.UpdateSysOutLevel(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("关闭系统日志等级(WARN)失败:" + res.Message);
            }
            else
            {
                MessageBox.Show("关闭系统日志等级(WARN)成功:");
                RefreshLevel((bool)res.Data["TRACE"], (bool)res.Data["DEBUG"], (bool)res.Data["INFO"], (bool)res.Data["WARN"]);
            }

        }

        private async void BtnRestart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要重启系统吗,在线用户的部分数据可能会丢失", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            JObject ReqJson = new JObject();
            ReqJson["Instruction"] = "restart";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.Instructions(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("系统操作失败(" + res.Message + ")");
            }
            else
            {
                MessageBox.Show("系统操作成功(" + res.Message + ")");
            }

        }

        private async void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要关闭系统吗,关闭后需要到手动才能开启", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return ;
            }
            JObject ReqJson = new JObject();
            ReqJson["Instruction"] = "close";
            // 发送请求
            var SearchRes = Task<MyResponse>.Run(() => Tools.API.Root.System.Instructions(ReqJson));

            MyResponse res = await SearchRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("系统操作失败(" + res.Message + ")");
            }
            else
            {
                MessageBox.Show("系统操作成功(" + res.Message + ")");
            }
        }
    }
}
