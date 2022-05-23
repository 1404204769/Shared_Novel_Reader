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
    public partial class FormDateSelect : Form
    {
        public string Begin = String.Empty;
        public string End = String.Empty;
        public FormDateSelect(string BeginTime,string EndTime)
        {
            InitializeComponent();
            if(BeginTime != String.Empty)
            {
                DateBegin.Value = DateTime.Parse(BeginTime);
            }
            else
            {
                DateBegin.Value = DateTime.Parse(DateTime.Now.Year.ToString() + "-01-01");
            }
            if(EndTime != String.Empty)
            {
                DateOver.Value = DateTime.Parse(EndTime);
            }
            else
            {
                DateOver.Value = DateTime.Now;
            }
            DateBegin.CustomFormat = "yyyy-MM-dd";
            DateOver.CustomFormat = "yyyy-MM-dd";
            Begin = DateBegin.Value.Year+"-"+ DateBegin.Value.Month + "-" + DateBegin.Value.Day + " 00:00:00";
            End = DateOver.Value.Year + "-" + DateOver.Value.Month + "-" + DateOver.Value.Day + " 00:00:00";
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            //MessageBox.Show("开始时间:" + Begin + "\n结束时间:" + End);
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DateBegin_ValueChanged(object sender, EventArgs e)
        {
            Begin = DateBegin.Text + " 00:00:00";
        }

        private void DateOver_ValueChanged(object sender, EventArgs e)
        {
            End = DateOver.Text + " 00:00:00";
        }
    }
}
