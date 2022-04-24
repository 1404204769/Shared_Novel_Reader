using System;
using System.Windows.Forms;
using Shared_Novel_Reader.models;
using Shared_Novel_Reader.MyForm.ResourceForm;
namespace Shared_Novel_Reader.MyForm
{
    public partial class FormBookShelf : Form
    {
        FormNovelReader FormNovelReader = null;
        public FormBookShelf()
        {
            InitializeComponent();
            LoadLocalRes();
        }

        public void LoadLocalRes()
        {
            if (!models.LocalBookShelf.open())
            {
                MessageBox.Show("书架打开失败");
                return;
            }
            MessageBox.Show("书架打开成功");

            this.DataGridView.Rows.Clear();
            foreach (var book in LocalBookShelf.LocalResArray)
            {
                string[] col = new string[5];
                col[0] = (string)book["Book_Name"];
                col[1] = (string)book["Link_Num"];
                this.DataGridView.Rows.Add(col);
            }
        }

        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(FormNovelReader!=null)
            {
                FormNovelReader.Dispose();
            }
            FormNovelReader = new FormNovelReader(this.DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(), Convert.ToInt32(this.DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString()), true);
            FormNovelReader.Show();
        }
    }
}
