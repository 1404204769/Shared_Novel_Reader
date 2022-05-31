using log4net;
using Newtonsoft.Json.Linq;
using Shared_Novel_Reader.Tools;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm
{
    public partial class FormLogin : Form
    {
        private CancellationTokenSource CancelLoginControl = null;
        ILog log = LogManager.GetLogger(typeof(FormLogin));
        /// <summary>
        /// Logo初始位置
        /// </summary>
        private Point InitialPosition;
        public FormLogin()
        {
            InitializeComponent();
        }


        private void FormLogin_Load(object sender, EventArgs e)
        {
            InitialPosition = this.PictureLogo.Location;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            // 判断数据是否完整
            if (TextAccount.Text == "" || TextPassword.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CancelLoginControl = new CancellationTokenSource();
            // 发送请求
            var LoginResult = Task<bool>.Run(() => Tools.API.GPI.Login(Convert.ToInt32(TextAccount.Text), TextPassword.Text, CancelLoginControl.Token));

            // 界面变化
            TimerLogoMove.Start();
            this.BtnLogin.Visible = false;
            this.BtnCancel.Visible = false;
            this.LabelAccount.Visible = false;
            this.LabelPassword.Visible = false;
            this.TextAccount.Visible = false;
            this.TextPassword.Visible = false;
            this.Label_Pwd_IMG.Visible = false;

            MyResponse res = await LoginResult;
            bool LoginRes = false;
            string ErrorMsg = string.Empty;
            if (res == null)
            {
                ErrorMsg="服务器异常,登入失败";
            }
            else if (!res.Result)
            {
                ErrorMsg = res.Message;
            }
            else if (res.Data == null)
            {
                ErrorMsg = "用户不存在,请注册";
            }
            else
            {
                MyClient.Token = res.Data["Token"].ToString();
                if (!models.User.Init((JObject)res.Data["User_Data"]))
                {
                    log.Info("用户初始化失败");
                    ErrorMsg = "用户初始化失败";
                }
                else
                {
                    log.Info("用户初始化成功");
                    LoginRes = true;
                }
            }

            if (!LoginRes)
            {
                if (CancelLoginControl.IsCancellationRequested)
                {
                    MessageBox.Show("登入失败,用户已取消", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("登入失败("+ ErrorMsg + "),请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.BtnCancelLogin.PerformClick();
                }
                // 清除残留数据
                this.BtnCancel.PerformClick();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                //this.Dispose();
                MessageBox.Show("登入成功");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(this.TextAccount.Text == "" && this.TextPassword.Text == "")
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            this.TextAccount.Text = null;
            this.TextPassword.Text = null;
        }

        private void TimerLogoMove_Tick(object sender, EventArgs e)
        {
            if(this.PictureLogo.Location.X < 140)
                this.PictureLogo.Location = new Point(this.PictureLogo.Location.X + 1, this.PictureLogo.Location.Y);
            else
            {
                TimerLogoMove.Stop();
                this.BtnCancelLogin.Visible = true;
            }
                
        }

        private void BtnCancelLogin_Click(object sender, EventArgs e)
        {
            // 先取消登入
            if (!CancelLoginControl.IsCancellationRequested)
            {
                Console.WriteLine("开始准备取消登入");
                CancelLoginControl.Cancel();
                Console.WriteLine("取消登入完成");
            }

            this.PictureLogo.Location = InitialPosition;
            this.BtnLogin.Visible = true;
            this.BtnCancel.Visible = true;
            this.BtnCancelLogin.Visible = false;
            this.LabelAccount.Visible = true;
            this.LabelPassword.Visible = true;
            this.TextAccount.Visible = true;
            this.TextPassword.Visible = true;
            this.Label_Pwd_IMG.Visible = true;
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

        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            LabelPasswordExplain.Visible = true;
            if(e.KeyChar != '\b' && !(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') && !(e.KeyChar >= 'a' && e.KeyChar <= 'z'))
            {
                e.KeyChar = (char)0;   //处理非法字符  
            }
            else
            {
                // 输入正确则无需提示
                LabelPasswordExplain.Visible = false;
            }
            
        }

        private void Label_Pwd_IMG_Click(object sender, EventArgs e)
        {
            if (TextPassword.PasswordChar == '*')
            {
                TextPassword.PasswordChar = Char.MinValue;
                this.Label_Pwd_IMG.Image = global::Shared_Novel_Reader.Properties.Resources.show;
            }
            else
            {
                TextPassword.PasswordChar = '*';
                this.Label_Pwd_IMG.Image = global::Shared_Novel_Reader.Properties.Resources.hide;
            }
        }
    }
}
