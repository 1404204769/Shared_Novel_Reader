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
    public partial class FormBookTitle : Form
    {
        public bool IsEdit = false;
        public string OriginBookName = string.Empty;
        public string newBookName = string.Empty;
        public string OriginBookAuthor = string.Empty;
        public string newBookAuthor = string.Empty;
        public string OriginBookPublisher = string.Empty;
        public string newBookPublisher = string.Empty;
        public string OriginBookSynopsis = string.Empty;
        public string newBookSynopsis = string.Empty;
        public FormBookTitle()
        {
            InitializeComponent();
        }

        public void setBookName(string BookName)
        {
            OriginBookName = newBookName = BookName;
            this.TextBookNameValue.Text = newBookName;
        }

        public void setBookAuthor(string BookAuthor)
        {
            OriginBookAuthor = newBookAuthor = BookAuthor;
            this.TextBookAuthorValue.Text = newBookAuthor;
        }
        public void setBookPublisher(string BookPublisher)
        {
            OriginBookPublisher = newBookPublisher = BookPublisher;
            this.TextBookPublisherValue.Text = newBookPublisher;
        }
        public void setBookSynopsis(string BookSynopsis)
        {
            OriginBookAuthor = newBookSynopsis = BookSynopsis;
            this.TextBookSynopsisValue.Text = newBookSynopsis;
        }

        public void OpenEdit()
        {
            this.TextBookPublisherValue.ReadOnly = false;
            this.TextBookPublisherValue.Visible = false;
            this.ComboBoxBookPublisherValue.Visible = true;
            switch (newBookPublisher)
            {
                case "":
                case "未知":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 0;
                    break;
                case "起点中文网":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 1;
                    break;
                case "创世中文网":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 2;
                    break;
                case "纵横中文网":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 3;
                    break;
                case "云起书院":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 4;
                    break;
                case "潇湘书院":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 5;
                    break;
                case "晋江文学城":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 6;
                    break;
                case "17K小说网":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 7;
                    break;
                case "小说阅读网":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 8;
                    break;
                case "红袖添香":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 9;
                    break;
                case "刺猬猫":
                    this.ComboBoxBookPublisherValue.SelectedIndex = 10;
                    break;
            }
            this.TextBookAuthorValue.ReadOnly = false;
            this.TextBookNameValue.ReadOnly = false;
            this.TextBookSynopsisValue.ReadOnly = false;
        }
        private void LabelEdit_Click(object sender, EventArgs e)
        {
            OpenEdit();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            if (OriginBookName != newBookName)
                IsEdit = true;
            if (OriginBookAuthor != newBookAuthor)
                IsEdit = true;
            if (OriginBookPublisher != newBookPublisher)
                IsEdit = true;
            if (OriginBookSynopsis != newBookSynopsis)
                IsEdit = true;
            DialogResult = DialogResult.OK;
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ComboBoxBookPublisherValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            newBookPublisher = ((ComboBox)sender).SelectedItem.ToString();
        }

        private void TextBookNameValue_TextChanged(object sender, EventArgs e)
        {
            newBookName = this.TextBookNameValue.Text;
        }

        private void TextBookAuthorValue_TextChanged(object sender, EventArgs e)
        {
            newBookAuthor = this.TextBookAuthorValue.Text;
        }

        private void TextBookPublisherValue_TextChanged(object sender, EventArgs e)
        {
            newBookPublisher = this.TextBookPublisherValue.Text;
        }

        private void TextBookSynopsisValue_TextChanged(object sender, EventArgs e)
        {
            newBookSynopsis = this.TextBookSynopsisValue.Text;
        }
    }
}
