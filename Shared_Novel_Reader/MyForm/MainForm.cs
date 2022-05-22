using log4net;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm
{
    public partial class MainForm : Form
    {
        ILog log = LogManager.GetLogger(typeof(MainForm));
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


        private string TipString = "免责声明:\n"
            + "1.本软件书籍信息全部来自于用户上传或管理员修改，本软件不会修改任何书籍信息。\n"
            + "2.书籍版本属于原作者，本软件只提供信息存储服务，任何信息均由用户自主上传，若侵犯了您的权益，请联系我们删除此信息。\n"
            + "3.因本服务搜索结果根据您键入的关键字自动搜索其余用户上传的内容，不代表本软件赞成用户上传的所有信息。\n"
            + "4.您应对使用搜索的结果自行承担风险。\n"
            + "本软件不做任何形式的保证：不保证搜索结果满足您的要求，不保证搜索服务不中断，不保证搜索结果的安全性、准确性、及时性、合法性。\n"
            + "因网络状况、通讯故障、第三方网站等任何原因而导致您不能正常使用本服务的，本软件不承担任何法律责任。";
        private int TipPosX = 0; // 定义全局变量
        public MainForm()
        {
            log.Info("调用了MainForm的构造函数");
            InitializeComponent();
            UserPowerInit();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Info("调用了MainForm_FormClosed函数");
            // 窗口关闭前先保存图书资源
            CloseFormBookShelf();
            this.Dispose();
        }

        public override void Refresh()
        {
            base.Refresh();
            UserPowerInit();
            if(!models.User.IsInit)
            {
                LabelWelcome.Text = "游客,请登入~";
            }
            else
            {
                LabelWelcome.Text = "欢迎登入~";
            }
        }

        public void UserPowerInit()
        {
            // 游客权限

            BtnBookShelf.Visible = true;
            BtnPersonalData.Visible = false;
            BtnBookPlatform.Visible = false;
            BtnAdminControl.Visible = false;
            BtnRootControl.Visible = false;
            if (!models.User.IsInit) return;
            // 用户权限
            if(models.User.Power > 0)
            {
                BtnPersonalData.Visible = true;
                // 平台界面 包括论坛界面、在线看书界面
                BtnBookPlatform.Visible = true;
            }

            // 管理员权限
            if(models.User.Power >= 10000)
            {
                // 管理员界面
                BtnAdminControl.Visible = true;
            }

            // 超级管理员权限
            if (models.User.Power >= 1000000000)
            {
                // 超级管理员界面
                BtnRootControl.Visible = true;
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LabelTime.Text = DateTime.Now.ToString();
            this.TimerTopPanelTime.Start();

            this.TipPosX = this.TipPanel.Width;  // 获取初始位置
            this.LabelTipString.Location = new Point(this.TipPosX, this.TipPanel.Top+10);  // 设置label开始滚动的位置
            string tip = TipString.Replace("\n", "");
            this.LabelTipString.Text = tip;  // 设置滚动字幕内容，如内容需要变化，也可以设置变量，将变量赋值给label.Text，
            this.LabelTipString.AutoSize = true;
            //this.LabelTipString.Visible = true;
            this.LabelTipString.TextAlign = ContentAlignment.MiddleCenter;
            this.LabelTipString.ForeColor = Color.AliceBlue;
            this.LabelTipString.Parent = this.TipPanel;
            this.LabelTipString.BackColor = SystemPens.ActiveCaption.Color;  // 设置滚动条背景色
        }

        /// <summary>
        /// 提示语滚动
        /// </summary>
        private void ScrollDisplay()
        {
            if (TipPosX <= -this.LabelTipString.Size.Width)
            {
                TipPosX = this.TipPanel.Width + 3;
            }
            TipPosX = TipPosX - 3;  // 位置偏差，可控制字幕移动的快慢
            this.LabelTipString.Location = new Point(TipPosX, this.LabelTipString.Top);
        }

        private void TimerTip_Tick(object sender, EventArgs e)
        {
            ScrollDisplay();
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

            FormBookShelf FormBookShelf = null;
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
                FormBookShelf = controls[0] as FormBookShelf;

            if(models.User.IsInit)
                FormBookShelf.OpenInternetBookShelf();
            FormBookShelf.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = FormBookShelf;
            FormBookShelf.Show();
        }

        /// <summary>
        /// 程序退出时调用,用于保存图书资源
        /// </summary>
        public void CloseFormBookShelf()
        {
            FormBookShelf FormBookShelf = null;
            Control[] controls = this.MainPanel.Controls.Find("FormBookShelf", false);
            // 说明书架已加载
            if (controls.Length != 0)
            {
                FormBookShelf = controls[0] as FormBookShelf;
                if (models.User.IsInit)
                    FormBookShelf.closeInternetBookShelf();
                FormBookShelf.closeLocalBookShelf();
            }
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

            FormPersonalData FormPersonalData = null;
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
                FormPersonalData = controls[0] as FormPersonalData;

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

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Form FormRegister = new FormRegister();
            DialogResult RegisterRes = FormRegister.ShowDialog();
            Console.WriteLine("DialogResult : " + RegisterRes.ToString());
            if (RegisterRes == DialogResult.OK)
            {
                // 注册成功则自动打开登入界面
                BtnLogin.PerformClick();
            }
            else if (RegisterRes == DialogResult.Cancel)
            {
                // 用户取消登入
                Console.WriteLine("用户取消注册");
            }
            // 释放资源
            FormRegister.Dispose();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            FormLogin FormLogin = new FormLogin();
            DialogResult LoginRes = FormLogin.ShowDialog();
            Console.WriteLine("DialogResult : " + LoginRes.ToString());
            if (LoginRes == DialogResult.OK)
            {
                this.BtnLogin.Visible = false;
                this.BtnRegister.Visible = false;
                this.BtnLogout.Visible = true;
                Refresh();
                BtnPersonalData.PerformClick();
            }
            else if (LoginRes == DialogResult.Cancel)
            {
                // 用户取消登入
                Console.WriteLine("用户取消登入");
            }
            // 释放资源
            FormLogin.Dispose();
        }
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // 子窗口关闭前 用户退出前 先保存图书资源
            CloseFormBookShelf();
            models.User.Logout();
            this.BtnLogin.Visible = true;
            this.BtnRegister.Visible = true;
            this.BtnLogout.Visible = false;
            Refresh();
            this.MainPanel.Controls.Clear();
        }

        private void LabelTip_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TipString);
        }
    }
}
