using Shared_Novel_Reader.Tools;
using Shared_Novel_Reader.models;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Newtonsoft.Json.Linq;

namespace Shared_Novel_Reader.MyForm.UserForm
{
    public partial class FormActionList : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormActionList));
        public FormActionList()
        {
            InitializeComponent();
        }
        public async Task<bool> LoadList(int UserID)
        {
            // 发送请求
            var UserListResult = Task<MyResponse>.Run(() => Tools.API.User.User.SearchAction(UserID));

            MyResponse res = await UserListResult;

            // 加载前把残留的数据删除
            DataGridViewUser.Rows.Clear();


            if (res == null)
            {
                // 清除残留数据
                MessageBox.Show("网络异常,请重试");
                log.Info("用户行为查询失败:网络异常,请重试");
                return false;
            }
            else if(!res.Result)
            {
                MessageBox.Show("查询失败:"+res.Message);
                log.Info("用户行为查询失败:" + res.Message);
                return false;
            }
            else if (res.Data["Action_List"].ToString() == "")
            {
                MessageBox.Show("用户行为列表为空");
                log.Info("用户行为查询失败:用户行为列表为空");
                return false;
            }

            JArray ActionListJson = (JArray)res.Data["Action_List"];
            // log.Info(UserListJson.ToString());
            for (int i = 0; i < ActionListJson.Count; i++)
            {
                string[] str = new string[3];
                str[0] = ActionListJson[i]["Type"].ToString();
                str[1] = ActionListJson[i]["Memo"].ToString();
                str[2] = ActionListJson[i]["Time"].ToString();
                DataGridViewUser.Rows.Add(str);
            }
            log.Info("用户行为查询成功");
            return true;
        }

        private void ViewDetails_Click(object sender, System.EventArgs e)
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


            MessageBox.Show(show);
        }
    }
}
