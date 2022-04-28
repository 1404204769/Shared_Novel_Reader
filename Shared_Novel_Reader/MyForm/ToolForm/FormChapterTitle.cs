using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Novel_Reader.MyForm.ToolForm
{
    public partial class FormChapterTitle : Form
    {
        /// <summary>
        /// 处理章节信息
        /// </summary>
        public FormChapterTitle()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 禁止编辑
        /// </summary>
        public void UnEdit()
        {
            this.TextChapterNumValue.ReadOnly = true;
            this.TextVolNumValue.ReadOnly = true;
            this.TextChapterTitleValue.Focus();
            this.ActiveControl = TextChapterTitleValue;
        }
        public int getVolNum()
        {
            return Convert.ToInt32( this.TextVolNumValue.Text.ToString() );
        }
        public void setVolNum(int volNum)
        {
            this.TextVolNumValue.Text = Convert.ToString(volNum) ;
        }
        public int getChapterNum()
        {
            return Convert.ToInt32(this.TextChapterNumValue.Text.ToString());
        }
        public void setChapterNum(int chapterNum)
        {
            this.TextChapterNumValue.Text = Convert.ToString(chapterNum); 
        }

        public string getTitle()
        {
            return this.TextChapterTitleValue.Text.Trim();
        }

        public void setTitle(string title)
        {
           this.TextChapterTitleValue.Text = title;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void TextVolNumValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = false;
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                    // 输入正确则无需提示
                    right = true;
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
            if(!right)
                MessageBox.Show("请输入数字0-9");
        }

        private void TextChapterNumValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool right = false;
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                    // 输入正确则无需提示
                    right = true;
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }
            if (!right)
                MessageBox.Show("请输入数字0-9");

        }
    }
}
