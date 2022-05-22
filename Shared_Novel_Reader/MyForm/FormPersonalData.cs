using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.models;
using Shared_Novel_Reader.Tools;

namespace Shared_Novel_Reader.MyForm
{
    public partial class FormPersonalData : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormPersonalData));
        UserForm.FormActionList FormActionList = null;
        public bool IsEdit = false;
        public FormPersonalData()
        {
            InitializeComponent();
        }

        public override void Refresh()
        {
            base.Refresh();
            UserRefresh();
        }

        public bool UserRefresh()
        {
            if (!User.IsInit)
            {
                MessageBox.Show("用户未初始化,请重新登入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            this.TextUserIDValue.Text = Convert.ToString(User.User_ID);
            this.TextLevelValue.Text = Convert.ToString(User.Level);
            this.TextPowerValue.Text = Convert.ToString(User.Power);
            this.TextIntegralValue.Text = Convert.ToString(User.Integral);
            this.TextTotalIntegralValue.Text = Convert.ToString(User.Total_Integral);
            this.TextNameValue.Text = User.Name;
            this.TextSexValue.Text = User.Sex;
            this.TextStatusValue.Text = User.Status;
            return true;
        }

        private void LabelEdit_Click(object sender, EventArgs e)
        {
            IsEdit = true;
            this.LabelEdit.Visible = false;
            this.LabelSave.Visible = true;
            this.TextNameValue.BackColor = Color.White;
            this.TextNameValue.Cursor = Cursors.IBeam;
            this.TextNameValue.ReadOnly = false;
            this.TextSexValue.Visible = false;
            this.ComboBoxSex.Visible = true;
            switch (TextSexValue.Text)
            {
                case "女":
                    this.ComboBoxSex.SelectedIndex = 1;
                    break;
                default:
                    this.ComboBoxSex.SelectedIndex = 0;
                    break;
            }
        }

        private void ComboBoxSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextSexValue.Text = ((ComboBox)sender).SelectedItem.ToString();
        }

        private async void LabelSave_Click(object sender, EventArgs e)
        {
            if (!IsEdit) return;
            if (!User.IsInit) return;

            // 准备数据
            JObject ReqJson = new JObject();
            JArray Change_Col = new JArray();
            Change_Col.Add("Change_Name");
            Change_Col.Add("Change_Sex");
            ReqJson["Change_Sex"] = this.TextSexValue.Text;
            ReqJson["Change_Name"] = this.TextNameValue.Text;
            ReqJson["Change_ID"] = User.User_ID;
            ReqJson["Change_Col"] = Change_Col;

            // 发送请求
            var ChangeRes = Task<MyResponse>.Run(() => Tools.API.User.User.ChangeUserData(ReqJson));

            MyResponse res = await ChangeRes;

            if (res == null)
            {
                // 清除残留数据
                MessageBox.Show("网络异常，请重试");
                return;
            }
            else if (!res.Result)
            {
                MessageBox.Show("个人资料保存失败:" + res.Message);
            }
            else
            {
                if (res.Data == null)
                {
                    MessageBox.Show(res.Message);
                }
                else
                {
                    User.Level = (int)res.Data["Level"];
                    User.Power = (int)res.Data["Power"];
                    User.Integral = (int)res.Data["Integral"];
                    User.Total_Integral = (int)res.Data["Total_Integral"];
                    User.Name = (string)res.Data["Name"];
                    User.Password = (string)res.Data["Password"];
                    User.Status = (string)res.Data["Status"];
                    User.Sex = (string)res.Data["Sex"];
                    MessageBox.Show("个人资料更新成功");
                }
            }

            // 修改界面
            this.TextNameValue.ReadOnly = true;
            this.TextNameValue.BackColor = Color.LightGray;
            this.TextNameValue.Cursor = Cursors.Default;
            this.TextSexValue.Visible = true;
            this.ComboBoxSex.Visible = false;

            IsEdit = false;
            this.LabelEdit.Visible = true;
            this.LabelSave.Visible = false;
        }

        private async void LabelPwd_Click(object sender, EventArgs e)
        {
            if (!User.IsInit) return;
            ToolForm.FormPwd formPwd = new ToolForm.FormPwd();
            DialogResult DiaRes = formPwd.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;

            // 准备数据
            JObject ReqJson = new JObject();
            JArray Change_Col = new JArray();
            Change_Col.Add("Change_Password");
            ReqJson["Change_Password"] = formPwd.TextPwd.Text;
            ReqJson["Change_ID"] = User.User_ID;
            ReqJson["Change_Col"] = Change_Col;

            // 发送请求
            var ChangeRes = Task<MyResponse>.Run(() => Tools.API.User.User.ChangeUserData(ReqJson));

            MyResponse res = await ChangeRes;

            if (res == null)
            {
                // 清除残留数据
                MessageBox.Show("网络异常，请重试");
                return;
            }
            else if (!res.Result)
            {
                MessageBox.Show("密码更改失败");
            }
            else if (res.Data.ToString() == "")
            {
                MessageBox.Show("用户数据异常，请重试");
            }
            else
            {
                MessageBox.Show("密码更改成功");
            }

        }

        private async void LabelFeedback_Click(object sender, EventArgs e)
        {
            ToolForm.FormInput formInput = new ToolForm.FormInput();
            formInput.Text = "意见反馈";
            DialogResult DiaRes = formInput.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;

            // 准备数据
            JObject ReqJson = new JObject();
            ReqJson["Content"] = formInput.getValue();

            // 发送请求
            var FeedbackRes = Task<MyResponse>.Run(() => Tools.API.User.User.Feedback(ReqJson));

            MyResponse res = await FeedbackRes;

            if (res == null)
            {
                // 清除残留数据
                MessageBox.Show("网络异常，请重试");
                return;
            }
            else if (!res.Result)
            {
                MessageBox.Show("意见反馈失败");
            }
            else if (res.Data.ToString() == "")
            {
                MessageBox.Show("数据异常，请重试");
            }
            else
            {
                MessageBox.Show("意见反馈成功");
            }

        }

        private async void LabelHistoryAction_Click(object sender, EventArgs e)
        {
            if (FormActionList == null || FormActionList.IsDisposed)
                FormActionList = new UserForm.FormActionList();
            else
                return;
            bool res = await FormActionList.LoadList(User.User_ID);
            if (res)
            {
                FormActionList.Show();
            }else
            {
                FormActionList.Dispose();
                FormActionList=null;
            }
        }

        private void LabelRecharge_Click(object sender, EventArgs e)
        {
            MyForm.ToolForm.FormRecharge FormRecharge = new MyForm.ToolForm.FormRecharge();
            DialogResult DiaRes = FormRecharge.ShowDialog();
            if (DiaRes == DialogResult.Cancel)
                return;
            MessageBox.Show("积分充值成功");
            Refresh();
        }
    }
}
