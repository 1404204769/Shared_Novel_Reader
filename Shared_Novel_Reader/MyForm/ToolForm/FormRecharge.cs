using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.models;
using Shared_Novel_Reader.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.ToolForm
{
    public partial class FormRecharge : Form
    {
        public FormRecharge()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if(TextNum.Text.Trim() == string.Empty)
            {
                MessageBox.Show("金额不能为空");
                return;
            }
            Regex rx = new Regex("^[0-9]*$");
            Match res = rx.Match(TextNum.Text);
            if (!res.Success)
            {
                MessageBox.Show("必须是正整数");
                return;
            }
            Recharge(Convert.ToInt32(res.Value));
        }
        private async void Recharge(int num)
        {
            DialogResult result = MessageBox.Show("确认充值"+num+"元吗？", "充值确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
                // DialogResult = DialogResult.Cancel;
            }
            // 发送请求
            var RechargeRes = Task<MyResponse>.Run(() => Tools.API.User.User.Recharge(num));

            MyResponse res = await RechargeRes;

            if (res == null)
            {
                MessageBox.Show("网络异常,请重试");
                return ;
            }
            else if (!res.Result || res.Data.ToString() == "")
            {
                MessageBox.Show("充值失败:" + res.Message);
                return ;
            }
            else
            {
                JObject UserData = res.Data["User_Data"] as JObject;
                // 设置校验条件
                Dictionary<string, JTokenType> usermap = new Dictionary<string, JTokenType>();
                usermap.Add("Integral", JTokenType.Integer);
                usermap.Add("TotalIntegral", JTokenType.Integer);
                usermap.Add("Level", JTokenType.Integer);
                MyJson.CheckColAndTypeFromMap(UserData, usermap);
                User.Level = Convert.ToInt32(UserData["Level"].ToString());
                User.Integral = Convert.ToInt32(UserData["Integral"].ToString());
                User.Total_Integral = Convert.ToInt32(UserData["TotalIntegral"].ToString());
                DialogResult = DialogResult.OK;
            }
        }

        private void Btn1dollor_Click(object sender, EventArgs e)
        {
            Recharge(1);
        }

        private void Btn5dollor_Click(object sender, EventArgs e)
        {
            Recharge(5);
        }

        private void Btn10dollor_Click(object sender, EventArgs e)
        {
            Recharge(10);
        }

        private void Btn30dollor_Click(object sender, EventArgs e)
        {
            Recharge(30);
        }

        private void Btn50dollor_Click(object sender, EventArgs e)
        {
            Recharge(50);
        }

        private void Btn100dollor_Click(object sender, EventArgs e)
        {
            Recharge(100);
        }
    }
}
