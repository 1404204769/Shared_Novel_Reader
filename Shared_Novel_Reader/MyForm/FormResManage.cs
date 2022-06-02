using log4net;
using Shared_Novel_Reader.models;
using System;
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


                col[2] = Convert.ToString(book["PartNum"]);
                col[3] = Convert.ToString(book["ChapterNum"]);
                col[4] = Convert.ToString(book["ContentNum"]);
                int tempPartNum = Convert.ToInt32(Convert.ToString(book["PartNum"]));
                int tempChapterNum = Convert.ToInt32(Convert.ToString(book["ChapterNum"]));
                int tempContentNum = Convert.ToInt32(Convert.ToString(book["ContentNum"]));

                if (tempPartNum == 0 && tempChapterNum == 0)
                {
                    col[5] = "还未阅读过此书";
                }
                else
                {
                    col[5] = "上次阅读到第" + tempPartNum + "卷第" + tempChapterNum + "章第"+ tempContentNum + "行";
                }
                this.DataGridViewLocal.Rows.Add(col);
            }
            log.Info("本地书架加载成功");
        }

    }
}
