using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.AdminForm.Resource
{
    public partial class FormChapterContent : Form
    {
        ILog log = LogManager.GetLogger(typeof(FormChapterContent));
        int PartNum, ChapterNum, VersionNum;
        string BookName,ChapterTitle;
        JArray ContentArray = null;
        
        public FormChapterContent(string Book_Name,int Part_Num, int Chapter_Num, string Chapter_Title, int Version_Num,JArray Content_Array)
        {
            PartNum = Part_Num;
            ChapterNum = Chapter_Num;
            BookName = Book_Name;
            ChapterTitle = Chapter_Title;
            ContentArray = Content_Array;
            VersionNum = Version_Num;
            InitializeComponent();
            LoadChapterContent();
        }


        /// <summary>
        /// 显示章节内容
        /// </summary>
        private void LoadChapterContent()
        {
            this.toolStripLabelBookNameValue.Text = BookName;
            this.toolStripLabelChapterTitleValue.Text = ChapterTitle;
            this.toolStripLabelPartNumValue.Text = Convert.ToString( PartNum );
            this.toolStripLabelChapterNumValue.Text = Convert.ToString(ChapterNum);
            this.toolStripLabelVersionValue.Text = Convert.ToString(VersionNum);
            this.toolStripLabelRowNumValue.Text = Convert.ToString(ContentArray.Count);
            int ChineseNum = 0;
            // 加载前把残留的数据删除
            DataGridViewChapterContent.Rows.Clear();
            
            if (ContentArray == null || ContentArray.Count == 0)
            {
                log.Info("章节内容为空");
            }
            else
            {
                for (int i = 0; i < ContentArray.Count; i++)
                {
                    ChineseNum += Tools.Novel_Analysis.GetHanNumFromString(ContentArray[i].ToString());
                    DataGridViewChapterContent.Rows.Add(ContentArray[i].ToString());
                }
                log.Info("章节内容如下");
            }
            this.toolStripLabelChineseNumValue.Text = Convert.ToString(ChineseNum);
        }
    }
}
