using Shared_Novel_Reader.Tools.API.Admin;
using Shared_Novel_Reader.Tools;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System;
using log4net;

namespace Shared_Novel_Reader.MyForm.AdminForm
{
    public partial class FormUserManagement : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormUserManagement));

        public bool IsFindAll = true;
        public string UserIDStr = String.Empty;
        public string UserNameStr = String.Empty;
        public string UserSexStr = String.Empty;
        public FormUserManagement()
        {
            InitializeComponent();
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
            log.Info("正在查询指定用户(ID:"+ UserID + ",Name:"+ UserNameStr + ",Sex:"+ UserSexStr + ")");

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

            for (int i = 0;i < UserListJson.Count;i++)
            {
                string[] RowData = new string[DataGridViewUser.ColumnCount];
                for (int j = 0; j < DataGridViewUser.ColumnCount; j++)
                {
                    if(ColName[j] == "User_Name")
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
            int RowIndex = DataGridViewUser.CurrentRow.Index;
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
            if((string)DataGridViewUser.Rows[RowIndex].Cells[7].Value == "Ban")
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
                show +="封号截止时间:"+Time;
            }

            MessageBox.Show(show);
        }

        private async void InitPwd_Click(object sender, EventArgs e)
        {
            int RowIndex = DataGridViewUser.CurrentRow.Index;
            int UserID = Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells["User_ID"].Value);
            DialogResult result = MessageBox.Show("确认初始化此用户(User_ID = "+ UserID + ")的密码嘛？", "初始化用户密码", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            /*"Change_Target":[
                {
                        ""      :   911220 ,
                    ""    :   "陈彤磊",
                    "":   "chentonlei",
                    ""     :   "男",
                    ""   :   0,
                    ""  :   "Add",
                    "Change_Col"     :   ["Change_Name","Change_Password","Change_Sex","ss"]
                }
            ]*/

            // 数据处理


            JObject ReqJson = new JObject();
            JArray Target = new JArray();
            JArray ChangeCol = new JArray();
            JObject UserJson = new JObject();
            ChangeCol.Add("Change_Password");
            UserJson["Change_ID"] = UserID;
            UserJson["Change_Password"] = "123456";
            UserJson["Change_Name"] = "";
            UserJson["Change_Sex"] = "";
            UserJson["Change_Integral_Num"] = "";
            UserJson["Change_Integral_Type"] = "";
            UserJson["Change_Col"] = ChangeCol;
            Target.Add(UserJson);
            ReqJson["Change_Target"] = Target;

            // 发送请求
            var UpdateResult = Task<MyResponse>.Run(() => User.UpdateUserList(ReqJson));

            MyResponse res = await UpdateResult;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
                return;
            }
            else if(!res.Result||res.Data.ToString() == "")
            {
                MessageBox.Show("初始化密码失败");
                return;
            }
            JArray TargetRes = (JArray)res.Data["ChangeTarget"];
            if(TargetRes.Count == 0 || TargetRes.Count > 1)
            {
                MessageBox.Show("数据异常，初始化密码失败");
                return;
            }
            JObject ans = TargetRes[0] as JObject;
            if((bool)ans["Result"] == false)
            {
                MessageBox.Show("初始化密码失败:"+ ans["ErrorMsg"][0].ToString());
                return;
            }
            MessageBox.Show("初始化密码成功");
        }

        public bool IsNumber(in string NumStr,out int Num)
        {
            try
            {
                //当数字字符串的为是少于4时，以下三种都可以转换，任选一种
                //如果位数超过4的话，请选用Convert.ToInt32() 和int.Parse()

                //result = int.Parse(message);
                //result = Convert.ToInt16(message);
                Num = Convert.ToInt32(NumStr);
            }
            catch
            {
                Num = -1;
                MessageBox.Show("输入的不是数字,请重新输入");
                return false;
            }
            return true;
        }

        // 奖励积分
        private async void Reward_Click(object sender, EventArgs e)
        {
            ToolForm.FormInput formInput = new ToolForm.FormInput();
            formInput.Text = "奖励积分:请输入要奖励的积分数量";
            DialogResult DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            string NumStr = formInput.getValue();
            int Num;
            if(!IsNumber(in NumStr,out Num))
            {
                return;
            }
            if(Num <= 0 || Num >= 10000)
            {
                MessageBox.Show("输入的数字不规范,请重新输入(有效范围:0<x<10000)");
                return;
            }
            int RowIndex = DataGridViewUser.CurrentRow.Index;
            int UserID = Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells["User_ID"].Value);

            DialogResult result = MessageBox.Show("确认奖励此用户(User_ID = " + UserID + ") "+Num+" 积分嘛？", "奖励用户积分", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            /*
                {
                    "Change_ID" : 911221,
                    "Change_Num" : 20,
                    "Change_Type" : "Sub",
                    "Change_Explain" : "看你小子不顺眼"
                } 
            */

            // 数据处理

            // 获取操作说明
            formInput.Text = "奖励积分:请输入奖励的原因";
            formInput.setValue("");
            DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;

            JObject ReqJson = new JObject();
            ReqJson["Change_Explain"] = formInput.getValue();
            ReqJson["Change_ID"] = UserID;
            ReqJson["Change_Num"] = Num;
            ReqJson["Change_Type"] = "Add";

            // 发送请求
            var UpdateResult = Task<MyResponse>.Run(() => User.UpdateUserIntegral(ReqJson));

            MyResponse res = await UpdateResult;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
                return;
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("奖励用户积分失败: " + res.Message);
                return;
            }
            DataGridViewUser.Rows[RowIndex].Cells["Integral"].Value = res.Data["Integral"];
            DataGridViewUser.Rows[RowIndex].Cells["Total_Integral"].Value = res.Data["Total_Integral"];
            MessageBox.Show("奖励用户积分成功");
        }

        // 扣除积分
        private async void Punishment_Click(object sender, EventArgs e)
        {
            ToolForm.FormInput formInput = new ToolForm.FormInput();
            formInput.Text = "扣除积分:请输入要扣除的积分数量";
            DialogResult DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            string NumStr = formInput.getValue();
            int Num;
            if (!IsNumber(in NumStr, out Num))
            {
                return;
            }
            if (Num <= 0 || Num >= 10000)
            {
                MessageBox.Show("输入的数字不规范,请重新输入(有效范围:0<x<10000)");
                return;
            }
            int RowIndex = DataGridViewUser.CurrentRow.Index;
            int UserID = Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells["User_ID"].Value);

            DialogResult result = MessageBox.Show("确认扣除此用户(User_ID = " + UserID + ") " + Num + " 积分嘛？", "扣除用户积分", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            /*
                {
                    "Change_ID" : 911221,
                    "Change_Num" : 20,
                    "Change_Type" : "Sub",
                    "Change_Explain" : "看你小子不顺眼"
                } 
            */

            // 数据处理

            // 获取操作说明
            formInput.Text = "扣除积分:请输入扣除积分的原因";
            formInput.setValue("");
            DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;

            JObject ReqJson = new JObject();
            ReqJson["Change_Explain"] = formInput.getValue();
            ReqJson["Change_ID"] = UserID;
            ReqJson["Change_Num"] = Num;
            ReqJson["Change_Type"] = "Sub";

            // 发送请求
            var UpdateResult = Task<MyResponse>.Run(() => User.UpdateUserIntegral(ReqJson));

            MyResponse res = await UpdateResult;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
                return;
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("扣除用户积分失败: " + res.Message);
                return;
            }
            DataGridViewUser.Rows[RowIndex].Cells["Integral"].Value = res.Data["Integral"];
            DataGridViewUser.Rows[RowIndex].Cells["Total_Integral"].Value = res.Data["Total_Integral"];
            MessageBox.Show("扣除用户积分成功");

        }

        // 封号
        private async void Ban_Click(object sender, EventArgs e)
        {
            int RowIndex = DataGridViewUser.CurrentRow.Index;
            int UserID = Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells["User_ID"].Value);
            int Power = Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells["Power"].Value);
            if (UserID == models.User.User_ID)
            {
                MessageBox.Show("不能自己封号自己哦~");
                return;
            }

            if (Power >= 10000)
            {
                MessageBox.Show("不能将管理员封号哦~");
                return;
            }

            ToolForm.FormInput formInput = new ToolForm.FormInput();
            formInput.Text = "封号:请输入要封号的时间(单位:天)";
            DialogResult DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            string NumStr = formInput.getValue();
            int Num;
            if (!IsNumber(in NumStr, out Num))
            {
                return;
            }
            if (Num <= 0)
            {
                MessageBox.Show("输入的数字不规范,请重新输入(有效范围:x>0");
                return;
            }

            DialogResult result = MessageBox.Show("确认将此用户(User_ID = " + UserID + ") 封号 " + Num + " 天嘛？", "封号", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            /*
                {
                    "Change_ID" : 911223,
                    "Change_Type" : "Ban",
                    "Limit_Time"  : 1,
                    "Change_Explain" : "看你小子不顺眼"
                }
            */

            // 数据处理

            // 获取操作说明
            formInput.Text = "封号:请输入封号的原因";
            formInput.setValue("");
            DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;

            JObject ReqJson = new JObject();
            ReqJson["Change_ID"] = UserID;
            ReqJson["Change_Type"] = "Ban";
            ReqJson["Limit_Time"] = Num;
            ReqJson["Change_Explain"] = formInput.getValue();

            // 发送请求
            var UpdateResult = Task<MyResponse>.Run(() => User.UpdateUserStatus(ReqJson));

            MyResponse res = await UpdateResult;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
                return;
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("用户封号失败: " + res.Message);
                return;
            }
            DataGridViewUser.Rows[RowIndex].Cells["Status"].Value = res.Data["Status"].ToString();
            MessageBox.Show("用户封号成功");

        }

        // 解封
        private async void Unseal_Click(object sender, EventArgs e)
        {

            int RowIndex = DataGridViewUser.CurrentRow.Index;
            int UserID = Convert.ToInt32(DataGridViewUser.Rows[RowIndex].Cells["User_ID"].Value);

            DialogResult result = MessageBox.Show("确认解封此用户(User_ID = " + UserID + ") 嘛？", "解封", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            /*
                {
                    "Change_ID" : 123456,
                    "Change_Type" : "Unseal",
                    "Change_Explain" : "看你小子顺眼"
                }
            */

            // 数据处理

            // 获取操作说明
            ToolForm.FormInput formInput = new ToolForm.FormInput();
            formInput.Text = "解封:请输入解封的原因";
            DialogResult DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;

            JObject ReqJson = new JObject();
            ReqJson["Change_ID"] = UserID;
            ReqJson["Change_Type"] = "Unseal";
            ReqJson["Change_Explain"] = formInput.getValue();

            // 发送请求
            var UpdateResult = Task<MyResponse>.Run(() => User.UpdateUserStatus(ReqJson));

            MyResponse res = await UpdateResult;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
                return;
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("用户解封失败: " + res.Message);
                return;
            }
            DataGridViewUser.Rows[RowIndex].Cells["Status"].Value = res.Data["Status"];
            MessageBox.Show("用户解封成功");
        }
    }


}
