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
    public partial class FormNote : Form
    {
        public FormNote()
        {
            InitializeComponent();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            if(this.TextTitle.Text.Trim().Length <= 0)
            {
                MessageBox.Show("求助帖标题不能为空");
                return;
            }
            if (this.TextContent.Text.Trim().Length <= 0)
            {
                MessageBox.Show("求助帖内容不能为空");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
