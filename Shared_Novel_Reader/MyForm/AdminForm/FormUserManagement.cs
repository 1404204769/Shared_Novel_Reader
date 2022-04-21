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
        public FormUserManagement()
        {
            InitializeComponent();
            LoadUserList();
        }

        public async void LoadUserList()
        {


            // 发送请求
            var UserListResult = Task<MyResponse>.Run(() => User.UserList());


            MyResponse res = await UserListResult;
            
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
    }


}
