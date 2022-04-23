using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Novel_Reader.MyForm.AdminForm;

namespace Shared_Novel_Reader.MyForm
{
    public partial class FormAdminControl : Form
    {
        public FormAdminControl()
        {
            InitializeComponent();
        }



        private void BtnUserManagement_Click(object sender, EventArgs e)
        {
            Form AdminTagFrom = this.AdminMainPanel.Tag as Form;
            if (AdminTagFrom != null)
                AdminTagFrom.Hide();

            FormUserManagement FormUserManagement = null;
            Control[] controls = this.AdminMainPanel.Controls.Find("FormUserManagement", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormUserManagement");
                Console.WriteLine("开始准备导入FormUserManagement");
                FormUserManagement = new FormUserManagement();
                FormUserManagement.TopLevel = false;
                this.AdminMainPanel.Controls.Add(FormUserManagement);
                controls = this.AdminMainPanel.Controls.Find("FormUserManagement", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormUserManagement失败");
                    return;
                }
                Console.WriteLine("导入FormUserManagement成功");
            }
            else
            {
                FormUserManagement = controls[0] as FormUserManagement;
                /*
                 * 删除原有的界面重新生成表单
                FormUserManagement = controls[0] as FormUserManagement;
                FormUserManagement.Dispose();
                this.AdminMainPanel.Controls.RemoveByKey("FormUserManagement");
                FormUserManagement = new FormUserManagement();
                FormUserManagement.TopLevel = false;
                this.AdminMainPanel.Controls.Add(FormUserManagement);
                controls = this.AdminMainPanel.Controls.Find("FormUserManagement", false);
                Console.WriteLine("导入FormUserManagement成功");
                FormUserManagement = controls[0] as FormUserManagement;
                */
            }
                

            FormUserManagement.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.AdminMainPanel.Tag = FormUserManagement;

            FormUserManagement.Show();
            FormUserManagement.ReFind.PerformClick();
        }

        private void BtnResourceManagement_Click(object sender, EventArgs e)
        {
            Form AdminTagFrom = this.AdminMainPanel.Tag as Form;
            if (AdminTagFrom != null)
                AdminTagFrom.Hide();

            FormResourceManagement FormResourceManagement = null;
            Control[] controls = this.AdminMainPanel.Controls.Find("FormResourceManagement", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormResourceManagement");
                Console.WriteLine("开始准备导入FormResourceManagement");
                FormResourceManagement = new FormResourceManagement();
                FormResourceManagement.TopLevel = false;
                this.AdminMainPanel.Controls.Add(FormResourceManagement);
                controls = this.AdminMainPanel.Controls.Find("FormResourceManagement", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormResourceManagement失败");
                    return;
                }
                Console.WriteLine("导入FormResourceManagement成功");
            }
            else
                FormResourceManagement = controls[0] as FormResourceManagement;

            FormResourceManagement.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.AdminMainPanel.Tag = FormResourceManagement;
            FormResourceManagement.Show();
            FormResourceManagement.ReFind.PerformClick();
        }

        private void BtnUserApplication_Click(object sender, EventArgs e)
        {
            Form AdminTagFrom = this.AdminMainPanel.Tag as Form;
            if (AdminTagFrom != null)
                AdminTagFrom.Hide();

            FormUserApplication FormUserApplication = null;
            Control[] controls = this.AdminMainPanel.Controls.Find("FormUserApplication", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormUserApplication");
                Console.WriteLine("开始准备导入FormUserApplication");
                FormUserApplication = new FormUserApplication();
                FormUserApplication.TopLevel = false;
                this.AdminMainPanel.Controls.Add(FormUserApplication);
                controls = this.AdminMainPanel.Controls.Find("FormUserApplication", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormUserApplication失败");
                    return;
                }
                Console.WriteLine("导入FormUserApplication成功");
            }
            else
                FormUserApplication = controls[0] as FormUserApplication;

            FormUserApplication.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.AdminMainPanel.Tag = FormUserApplication;
            FormUserApplication.Show();
            FormUserApplication.ReFind.PerformClick();
        }

        private void BtnUserFeedback_Click(object sender, EventArgs e)
        {
            Form AdminTagFrom = this.AdminMainPanel.Tag as Form;
            if (AdminTagFrom != null)
                AdminTagFrom.Hide();

            FormUserFeedback FormUserFeedback = null;
            Control[] controls = this.AdminMainPanel.Controls.Find("FormUserFeedback", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormUserFeedback");
                Console.WriteLine("开始准备导入FormUserFeedback");
                FormUserFeedback = new FormUserFeedback();
                FormUserFeedback.TopLevel = false;
                this.AdminMainPanel.Controls.Add(FormUserFeedback);
                controls = this.AdminMainPanel.Controls.Find("FormUserFeedback", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormUserFeedback失败");
                    return;
                }
                Console.WriteLine("导入FormUserFeedback成功");
            }
            else
                FormUserFeedback = controls[0] as FormUserFeedback;

            FormUserFeedback.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.AdminMainPanel.Tag = FormUserFeedback;
            FormUserFeedback.Show();

            FormUserFeedback.ReFind.PerformClick();
        }
    }
}
