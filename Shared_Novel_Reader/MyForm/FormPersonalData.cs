using System;
using System.Windows.Forms;
using Shared_Novel_Reader.models;
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

        public bool UserRefresh()
        {
            if(!User.IsInit)
            {
                MessageBox.Show("用户未初始化,请重新登入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            this.LabelUserIDValue.Text = Convert.ToString(User.User_ID);
            this.LabelLevelValue.Text = Convert.ToString(User.Level);
            this.LabelPowerValue.Text = Convert.ToString(User.Power);
            this.LabelIntegralValue.Text = Convert.ToString(User.Integral);
            this.LabelTotalIntegralValue.Text = Convert.ToString(User.Total_Integral);
            this.LabelNameValue.Text = User.Name;
            this.LabelSexValue.Text = User.Sex;
            this.LabelStatusValue.Text = User.Status;
            return true;
        }
    }
}
