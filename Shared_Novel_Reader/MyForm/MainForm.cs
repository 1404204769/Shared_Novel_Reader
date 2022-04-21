using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 窗体是否移动
        /// </summary>
        private bool IsMove = false;

        /// <summary>
        /// PrePoint 移动前鼠标的位置
        /// </summary>
        private Point PrePoint;

        /// <summary>
        /// AfterPoint 移动后窗口的位置
        /// </summary>
        private Point AfterPoint;

        /// <summary>
        /// Difference 移动前后鼠标位置的差值
        /// </summary>
        private Point Difference;

        public MainForm()
        {
            InitializeComponent();
            UserPowerInit();
        }

        public void UserPowerInit()
        {
            // 游客权限
            //if(!models.User.IsInit)
            {
                BtnBookShelf.Visible = true;
                BtnResManage.Visible = true;
                // return;
            }

            // 用户权限
            //if(models.User.Power > 0)
            {
                BtnPersonalData.Visible = true;
                // 平台界面 包括论坛界面、在线看书界面
                BtnBookPlatform.Visible = true;
            }

            // 管理员权限
            //if(models.User.Power > 10000)
            {
                // 管理员界面
                BtnAdminControl.Visible = true;
            }

            // 超级管理员权限
            //if (models.User.Power > int.MaxValue)
            {
                // 超级管理员界面
                BtnRootControl.Visible = true;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LabelTime.Text = DateTime.Now.ToString();
            this.TimerTopPanelTime.Start();
        }

        /// <summary>
        /// 关闭程序的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// 页面顶端点击鼠标左键开始准备移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // PrePoint = new Point();
                // Console.WriteLine("页面顶端点击鼠标左键开始准备移动");
                PrePoint = Control.MousePosition;// new Point(e.X, e.Y);//获取鼠标在窗口上的坐标
                //formPoint = new Point(e.X,e.Y); 
                IsMove = true;//开始移动
            }
        }

        /// <summary>
        /// 页面顶端点击鼠标左键开始移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMove == true && ( ! Control.MousePosition.Equals(PrePoint)))
            {
                // Console.WriteLine("页面顶端点击鼠标左键开始移动");
                //获取鼠标在屏幕上的坐标 计算移动前后的差值
                Difference = new Point(Control.MousePosition.X - PrePoint.X, Control.MousePosition.Y - PrePoint.Y);
                AfterPoint = new Point(this.Location.X + Difference.X, this.Location.Y + Difference.Y);
                // 更新鼠标移动前的位置，防止重复移动
                PrePoint = Control.MousePosition;
                //设置窗口坐标
                this.Location = AfterPoint;
            }
        }

        /// <summary>
        /// 页面顶端松开鼠标左键停止移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//按下的是鼠标左键
            {
                // Console.WriteLine("页面顶端松开鼠标左键停止移动");
                IsMove = false;//停止移动
            }
        }


        private void BtnBookShelf_Click(object sender, EventArgs e)
        {
            Form MainTagFrom = this.MainPanel.Tag as Form;
            if (MainTagFrom != null)
                MainTagFrom.Hide();

            Form FormBookShelf = null;
            Control[] controls = this.MainPanel.Controls.Find("FormBookShelf", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormBookShelf");
                Console.WriteLine("开始准备导入FormBookShelf");
                FormBookShelf = new FormBookShelf();
                FormBookShelf.TopLevel = false;
                this.MainPanel.Controls.Add(FormBookShelf);
                controls = this.MainPanel.Controls.Find("FormBookShelf", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormBookShelf失败");
                    return;
                }
                Console.WriteLine("导入FormBookShelf成功");
            }
            else
                FormBookShelf = controls[0] as Form;

            FormBookShelf.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = FormBookShelf;
            FormBookShelf.Show();
        }

        private void BtnResManage_Click(object sender, EventArgs e)
        {
            Form MainTagFrom = this.MainPanel.Tag as Form;
            if (MainTagFrom != null)
                MainTagFrom.Hide();

            Form FormResManage = null;
            Control[] controls = this.MainPanel.Controls.Find("FormResManage", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormResManage");
                Console.WriteLine("开始准备导入FormResManage");
                FormResManage = new FormResManage();
                FormResManage.TopLevel = false;
                this.MainPanel.Controls.Add(FormResManage);
                controls = this.MainPanel.Controls.Find("FormResManage", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormResManage失败");
                    return;
                }
                Console.WriteLine("导入FormResManage成功");
            }
            else
                FormResManage = controls[0] as Form;

            FormResManage.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = FormResManage;
            FormResManage.Show();
        }

        private void BtnPersonalData_Click(object sender, EventArgs e)
        {
            Form MainTagFrom = this.MainPanel.Tag as Form;
            if (MainTagFrom != null)
                MainTagFrom.Hide();

            Form FormPersonalData = null;
            Control[] controls = this.MainPanel.Controls.Find("FormPersonalData", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormPersonalData");
                Console.WriteLine("开始准备导入FormPersonalData");
                FormPersonalData = new FormPersonalData();
                FormPersonalData.TopLevel = false;
                this.MainPanel.Controls.Add(FormPersonalData);
                controls = this.MainPanel.Controls.Find("FormPersonalData", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormPersonalData失败");
                    return;
                }
                Console.WriteLine("导入FormPersonalData成功");
            }
            else
                FormPersonalData = controls[0] as Form;

            FormPersonalData.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = FormPersonalData;
            FormPersonalData.Refresh();

            FormPersonalData.Show();
        }

        private void TimerTopPanelTime_Tick(object sender, EventArgs e)
        {
            this.LabelTime.Text = DateTime.Now.ToString();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Form FormLogin = new FormLogin();
            DialogResult LoginRes = FormLogin.ShowDialog();
            Console.WriteLine("DialogResult : " + LoginRes.ToString());
            if (LoginRes == DialogResult.OK)
            {
                UserPowerInit();
                BtnPersonalData.PerformClick();
            }
            else if(LoginRes == DialogResult.Cancel)
            {
                // 用户取消登入
                Console.WriteLine("用户取消登入");
            }
            // 释放资源
            FormLogin.Dispose();
        }

        private void BtnBookPlatform_Click(object sender, EventArgs e)
        {
            Form MainTagFrom = this.MainPanel.Tag as Form;
            if (MainTagFrom != null)
                MainTagFrom.Hide();

            Form FormBookPlatform = null;
            Control[] controls = this.MainPanel.Controls.Find("FormBookPlatform", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormBookPlatform");
                Console.WriteLine("开始准备导入FormBookPlatform");
                FormBookPlatform = new FormBookPlatform();
                FormBookPlatform.TopLevel = false;
                this.MainPanel.Controls.Add(FormBookPlatform);
                controls = this.MainPanel.Controls.Find("FormBookPlatform", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormBookPlatform失败");
                    return;
                }
                Console.WriteLine("导入FormBookPlatform成功");
            }
            else
                FormBookPlatform = controls[0] as Form;

            FormBookPlatform.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = FormBookPlatform;
            FormBookPlatform.Refresh();

            FormBookPlatform.Show();

        }

        private void BtnAdminControl_Click(object sender, EventArgs e)
        {
            Form MainTagFrom = this.MainPanel.Tag as Form;
            if (MainTagFrom != null)
                MainTagFrom.Hide();

            Form FormAdminControl = null;
            Control[] controls = this.MainPanel.Controls.Find("FormAdminControl", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormAdminControl");
                Console.WriteLine("开始准备导入FormAdminControl");
                FormAdminControl = new FormAdminControl();
                FormAdminControl.TopLevel = false;
                this.MainPanel.Controls.Add(FormAdminControl);
                controls = this.MainPanel.Controls.Find("FormAdminControl", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormAdminControl失败");
                    return;
                }
                Console.WriteLine("导入FormAdminControl成功");
            }
            else
                FormAdminControl = controls[0] as Form;

            FormAdminControl.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = FormAdminControl;
            FormAdminControl.Refresh();

            FormAdminControl.Show();
        }

        private void BtnRootControl_Click(object sender, EventArgs e)
        {
            Form MainTagFrom = this.MainPanel.Tag as Form;
            if (MainTagFrom != null)
                MainTagFrom.Hide();

            Form FormRootControl = null;
            Control[] controls = this.MainPanel.Controls.Find("FormRootControl", false);
            if (controls.Length == 0)
            {
                Console.WriteLine("控件中不存在FormRootControl");
                Console.WriteLine("开始准备导入FormRootControl");
                FormRootControl = new FormRootControl();
                FormRootControl.TopLevel = false;
                this.MainPanel.Controls.Add(FormRootControl);
                controls = this.MainPanel.Controls.Find("FormRootControl", false);
                if (controls.Length == 0)
                {
                    Console.WriteLine("导入FormRootControl失败");
                    return;
                }
                Console.WriteLine("导入FormRootControl成功");
            }
            else
                FormRootControl = controls[0] as Form;

            FormRootControl.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = FormRootControl;
            FormRootControl.Refresh();

            FormRootControl.Show();
        }
    }
}
