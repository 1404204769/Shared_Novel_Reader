using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm
{
    public partial class FormRegister : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormRegister));
        /*
             "User_ID": 911123,
            "User_Name": "孙芳文",
            "User_Pwd": "sunfangwen",
            "User_Sex": "男"
         */
        private int UserID = -1;
        private string UserName = string.Empty;
        private string Password = string.Empty;
        private string UserSex = string.Empty;
        private CancellationTokenSource CancelRegisterControl = null;

        public FormRegister()
        {
            InitializeComponent();
            this.ComboBoxSex.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("选择的项 ： " + this.ComboBoxSex.SelectedItem.ToString());
            this.UserSex = this.ComboBoxSex.SelectedItem.ToString();
        }

        private void TextAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            LabelAccountExplain.Visible = true;
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                    // 输入正确则无需提示
                    LabelAccountExplain.Visible = false;
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

        private void TextBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            LabelPasswordExplain.Visible = true;
            if (e.KeyChar != '\b' && !(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') && !(e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.KeyChar = (char)0;   //处理非法字符  
            }
            else
            {
                // 输入正确则无需提示
                LabelPasswordExplain.Visible = false;
            }
        }

        private void TextBoxPasswordAgain_KeyPress(object sender, KeyPressEventArgs e)
        {
            LabelPasswordAgainExplain.Visible = true;
            if (e.KeyChar != '\b' && !(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') && !(e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.KeyChar = (char)0;   //处理非法字符  
            }
            else
            {
                // 输入正确则无需提示
                LabelPasswordAgainExplain.Visible = false;
            }
            if(TextPassword.Text.Length <= TextPasswordAgain.Text.Length)
            {
                LabelPasswordAgainExplain.Text = "两次密码输入不一致";
                LabelPasswordAgainExplain.Visible = true;
            }
            else
            {
                LabelPasswordAgainExplain.Text = "请输入数字或字母";
            }
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            LabelErrorExpain.Visible = false;
            string msg = "账户: " + UserID + "\n昵称: " + UserName +"\n性别: " + UserSex + "\n密码: " + TextPassword.Text + "\n确认密码: " + TextPasswordAgain.Text;
            log.Info(msg);
            // 先校验一遍数据是否合法
            if (TextPassword.Text != TextPasswordAgain.Text)
            {
                LabelErrorExpain.Visible = true;
                LabelErrorExpain.Text = "输入的密码不一致,请确认密码";
                return;
            }
            if (TextPassword.Text == "")
            {
                LabelErrorExpain.Visible = true;
                LabelErrorExpain.Text = "密码不能为空,请输入密码";
                return;
            }
            if (TextPassword.Text.Length < 6)
            {
                LabelErrorExpain.Visible = true;
                LabelErrorExpain.Text = "密码不能小于6位,请重新输入";
                return;
            }
            // 昵称是空的
            if (TextName.Text == "")
            {
                this.labelNameExplain.Visible = true;
                return;
            }

            CancelRegisterControl = new CancellationTokenSource();
            // 发送请求
            var RegisterResult = Task<bool>.Run(() => Tools.API.GPI.Register(this.UserID,this.Password,this.UserName,this.UserSex,CancelRegisterControl.Token));

            if (!await RegisterResult)
            {
                MessageBox.Show("注册失败,请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Dispose();
                MessageBox.Show("注册成功");
            }

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (this.TextAccount.Text == "" && this.TextPassword.Text == "")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            this.TextAccount.Text = null;
            this.TextName.Text = null;
            this.ComboBoxSex.SelectedIndex = 0;
            this.TextPassword.Text = null;
            this.TextPasswordAgain.Text = null;
            this.LabelErrorExpain.Visible=false;
            this.LabelAccountExplain.Visible=false;
            this.LabelPasswordExplain.Visible = false;
            this.LabelPasswordAgainExplain.Visible = false;
            this.labelNameExplain.Visible = false;
        }


        private void TextAccount_TextChanged(object sender, EventArgs e)
        {
            if(this.TextAccount.Text == "")
            {
                this.UserID = -1;
            }
            else
            {
                this.UserID = Convert.ToInt32(((TextBox)sender).Text);
            }
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {
            this.labelNameExplain.Visible = false;
            this.UserName = this.TextName.Text;
        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {
            this.LabelPasswordExplain.Visible = false;
            this.Password = this.TextPassword.Text;
        }
    }
}
