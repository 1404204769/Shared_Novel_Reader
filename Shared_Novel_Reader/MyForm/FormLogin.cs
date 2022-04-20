﻿using System;
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
    public partial class FormLogin : Form
    {

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

            // 发送请求
            var LoginResult = Task<bool>.Run(() => Tools.API.Login(Convert.ToInt32(TextAccount.Text), TextPassword.Text));

            // 界面变化
            TimerLogoMove.Start();
            this.BtnLogin.Visible = false;
            this.BtnCancel.Visible = false;
            this.LabelAccount.Visible = false;
            this.LabelPassword.Visible = false;
            this.TextAccount.Visible = false;
            this.TextPassword.Visible = false;


            if (!await LoginResult)
            {
                MessageBox.Show("登入失败,请重试", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.BtnCancelLogin.PerformClick();
                this.BtnCancel.PerformClick();
            }
            else
            {
                this.Dispose();
                MessageBox.Show("登入成功");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(this.TextAccount.Text == "" && this.TextPassword.Text == "")
            {
                this.OnClosed(e);
                this.Dispose();
                return;
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

            this.PictureLogo.Location = InitialPosition;
            this.BtnLogin.Visible = true;
            this.BtnCancel.Visible = true;
            this.BtnCancelLogin.Visible = false;
            this.LabelAccount.Visible = true;
            this.LabelPassword.Visible = true;
            this.TextAccount.Visible = true;
            this.TextPassword.Visible = true;
        }

        private void TextAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar != '\b' && !(e.KeyChar >= '0' && e.KeyChar <= '9') && !(e.KeyChar >= 'A' && e.KeyChar <= 'Z') && !(e.KeyChar >= 'a' && e.KeyChar <= 'z'))
                e.KeyChar = (char)0;   //处理非法字符  
        }
    }
}