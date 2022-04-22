using Shared_Novel_Reader.Tools.API.Admin;
using Shared_Novel_Reader.Tools;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System;

namespace Shared_Novel_Reader.MyForm.AdminForm
{
    public partial class FormUserManagement : Form
    {
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
                MessageBox.Show("用户列表查询失败");
            }
            else
            {

                string[][] UserListStr;
                JArray UserListJson = (JArray)res.Data["UserList"];
                MessageBox.Show(UserListJson.ToString());
                GetUserList(in UserListJson, out UserListStr);
                for (int i = 0; i < UserListJson.Count; i++)
                {
                    DataGridViewUser.Rows.Add(UserListStr[i]);
                }
                MessageBox.Show("用户列表查询成功");
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
            MessageBox.Show("正在查询指定用户(ID:"+ UserID + ",Name:"+ UserNameStr + ",Sex:"+ UserSexStr + ")");

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
                MessageBox.Show("指定用户查询失败");
            }
            else
            {
                string[][] UserListStr;
                JArray UserListJson = (JArray)res.Data["UserList"];
                MessageBox.Show(UserListJson.ToString());
                GetUserList(in UserListJson, out UserListStr);
                for (int i = 0; i < UserListJson.Count; i++)
                {
                    DataGridViewUser.Rows.Add(UserListStr[i]);
                }
                MessageBox.Show("指定用户查询成功");
            }

        }

        private void GetUserList(in JArray UserListJson, out string[][] UserListStr)
        {
            UserListStr = new string[UserListJson.Count][];
            
            for(int i = 0;i < UserListJson.Count;i++)
            {
                string[] RowData = { Convert.ToString(UserListJson[i]["User_ID"]),(string)UserListJson[i]["Name"],
                    (string)UserListJson[i]["Sex"],Convert.ToString(UserListJson[i]["Level"]),Convert.ToString(UserListJson[i]["Power"]),
                Convert.ToString(UserListJson[i]["Integral"]),Convert.ToString(UserListJson[i]["Total_Integral"]),(string)UserListJson[i]["Status"]};
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
            }
            else if (res == DialogResult.Yes)
            {
                this.IsFindAll = false;
                this.UserIDStr = FilterUserList.TextUserID.Text;
                this.UserNameStr = FilterUserList.TextName.Text;
                this.UserSexStr = FilterUserList.ComboBoxSex.SelectedItem.ToString();

                this.LoadSomeUser();
            }
            else
            {

            }

            FilterUserList.Dispose();
        }
    }


}
