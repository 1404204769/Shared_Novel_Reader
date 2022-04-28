using log4net;
using Shared_Novel_Reader.models;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm
{
    public partial class FormResManage : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormResManage));
        public FormResManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 关闭本地书架
        /// </summary>
        public void closeLocalBookShelf()
        {
            if (!LocalBookShelf.close())
            {
                log.Info("本地书架关闭失败");
            }
            else
            {
                log.Info("本地书架关闭成功");
            }
        }

        public void LoadLocalRes()
        {
            if (!models.LocalBookShelf.open())
            {
                log.Info("本地书架打开失败");
                return;
            }
            log.Info("本地书架打开成功");
            this.DataGridViewLocal.Rows.Clear();
            foreach (var book in LocalBookShelf.LocalResArray)
            {
                string[] col = new string[5];
                col[0] = (string)book["Book_Name"];
                col[1] = (string)book["Link_Num"];
                this.DataGridViewLocal.Rows.Add(col);
            }
            log.Info("本地书架加载成功");
        }

    }
}
