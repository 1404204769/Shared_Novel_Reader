using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.ToolForm
{
    public partial class FormPwd : Form
    {
        public FormPwd()
        {
            InitializeComponent();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TextPwd_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
