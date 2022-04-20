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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Form f = new FormBookShelf();
            f.TopLevel = false;
            this.MainPanel.Controls.Add(f);
            f = new FormResManage();
            f.TopLevel = false;
            this.MainPanel.Controls.Add(f);
            f = new FormPersonalData();
            f.TopLevel = false;
            this.MainPanel.Controls.Add(f);
            BtnBookShelf.PerformClick();
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
                Console.WriteLine("页面顶端点击鼠标左键开始准备移动");
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
                Console.WriteLine("页面顶端点击鼠标左键开始移动");
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
                Console.WriteLine("页面顶端松开鼠标左键停止移动");
                IsMove = false;//停止移动
            }
        }

        private void BtnBookShelf_Click(object sender, EventArgs e)
        {
            Form f = this.MainPanel.Tag as Form;
            if (f != null)
                f.Hide();

            f = this.MainPanel.Controls[BtnBookShelf.TabIndex] as Form;
            f.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void BtnResManage_Click(object sender, EventArgs e)
        {
            Form f = this.MainPanel.Tag as Form;
            if (f != null)
                f.Hide();
            
            f = this.MainPanel.Controls.Find("FormResManage", false)[0] as Form;
            f.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void BtnPersonalData_Click(object sender, EventArgs e)
        {
            Form f = this.MainPanel.Tag as Form;
            if (f != null)
                f.Hide();
            
            f = this.MainPanel.Controls.Find("FormPersonalData", false)[0] as Form;
            f.Dock = DockStyle.Fill;
            // this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void TimerTopPanelTime_Tick(object sender, EventArgs e)
        {
            this.LabelTime.Text = DateTime.Now.ToString();
        }
    }
}
