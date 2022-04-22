﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.AdminForm
{
    public partial class FormFilterUserFeedback : Form
    {
        public FormFilterUserFeedback()
        {
            InitializeComponent();
        }


        private void BtnFindAll_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }

        private void BtnFindSome_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TextProviderID_KeyPress(object sender, KeyPressEventArgs e)
        {
            LabelProviderIDExplain.Visible = true;
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                    // 输入正确则无需提示
                    LabelProviderIDExplain.Visible = false;
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
        }

    }
}
