using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm
{
    public partial class FormPersonalData : Form
    {
        public FormPersonalData()
        {
            InitializeComponent();
        }

        public override void Refresh()
        {
            base.Refresh();
            UserRefresh();
        }

        public void UserRefresh()
        {
            if(!models.User.IsInit)
            {
                MessageBox.Show("用户未初始化,请重新登入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.LabelUserIDValue.Text = Convert.ToString(models.User.User_ID);
            this.LabelLevelValue.Text = Convert.ToString(models.User.Level);
            this.LabelPowerValue.Text = Convert.ToString(models.User.Power);
            this.LabelIntegralValue.Text = Convert.ToString(models.User.Integral);
            this.LabelTotalIntegralValue.Text = Convert.ToString(models.User.Total_Integral);
            this.LabelNameValue.Text = models.User.Name;
            this.LabelSexValue.Text = models.User.Sex;
            this.LabelStatusValue.Text = models.User.Status;
            return;
        }
    }
}
