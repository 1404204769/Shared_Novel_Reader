using System;
using System.Windows.Forms;
using log4net;
using Shared_Novel_Reader.models;
using Shared_Novel_Reader.MyForm.ResourceForm;
namespace Shared_Novel_Reader.MyForm
{
    public partial class FormBookShelf : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormBookShelf));
        public bool IsInternetBookShelfOpen = false;
        FormNovelReader FormNovelReader = null;
        public FormBookShelf()
        {
            log.Info("调用了FormBookShelf的构造函数");
            InitializeComponent();
            this.tabPageInternetBook.Parent = null;
            LoadLocalRes();
            OpenInternetBookShelf();
        }
        private void FormBookShelf_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Info("调用了FormBookShelf_FormClosed函数");
        }

        /// <summary>
        /// 只有用户登入且网络书架关闭的情况下才会初始化网络书架
        /// </summary>
        public void OpenInternetBookShelf()
        {
            if (User.IsInit && !IsInternetBookShelfOpen)
            {
                this.tabPageInternetBook.Parent = this.tabControl1;
                LoadInternetRes();
                IsInternetBookShelfOpen = true;
            }
        }

        /// <summary>
        /// 用户退出时关闭网络书架
        /// </summary>
        public void closeInternetBookShelf()
        {
            if (!InternetBookShelf.close())
            {
                MessageBox.Show("网络书架关闭失败");
            }
            else
            {
                MessageBox.Show("网络书架关闭成功");
            }
            this.tabPageInternetBook.Parent = null;
            IsInternetBookShelfOpen = false;
        }

        /// <summary>
        /// 关闭本地书架
        /// </summary>
        public void closeLocalBookShelf()
        {
            if (!LocalBookShelf.close())
            {
                MessageBox.Show("本地书架关闭失败");
            }
            else
            {
                MessageBox.Show("本地书架关闭成功");
            }
        }


        public void LoadLocalRes()
        {
            if (!models.LocalBookShelf.open())
            {
                MessageBox.Show("书架打开失败");
                return;
            }
            MessageBox.Show("书架打开成功");

            this.DataGridViewLocal.Rows.Clear();
            foreach (var book in LocalBookShelf.LocalResArray)
            {
                string[] col = new string[5];
                col[0] = (string)book["Book_Name"];
                col[1] = (string)book["Link_Num"];
                this.DataGridViewLocal.Rows.Add(col);
            }
        }

        /// <summary>
        /// 加载网络图书
        /// </summary>
        public void LoadInternetRes()
        {
            if (!User.IsInit) return;
            if (!InternetBookShelf.open())
            {
                MessageBox.Show("网络书架打开失败");
                return;
            }
            MessageBox.Show("书架打开成功");

            this.DataGridViewInternet.Rows.Clear();
            foreach (var book in InternetBookShelf.InternetResArray)
            {
                string[] col = new string[2];
                col[0] = (string)book["BookName"];
                col[1] = Convert.ToString(book["BookID"]);
                this.DataGridViewInternet.Rows.Add(col);
            }
        }

        private void DataGridViewLocal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormNovelReader != null)
            {
                FormNovelReader.Dispose();
            }
            FormNovelReader = new FormNovelReader(this.DataGridViewLocal.Rows[e.RowIndex].Cells[0].Value.ToString(), Convert.ToInt32(this.DataGridViewLocal.Rows[e.RowIndex].Cells[1].Value.ToString()), true);
            //FormNovelReader = new FormNovelReader("次元论坛", 17, false);
            FormNovelReader.Show();
        }

        private void DataGridViewInternet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FormNovelReader != null)
            {
                FormNovelReader.Dispose();
            }
            FormNovelReader = new FormNovelReader(this.DataGridViewInternet.Rows[e.RowIndex].Cells[0].Value.ToString(), Convert.ToInt32(this.DataGridViewInternet.Rows[e.RowIndex].Cells[1].Value.ToString()), false);
            FormNovelReader.Show();
        }

    }
}
