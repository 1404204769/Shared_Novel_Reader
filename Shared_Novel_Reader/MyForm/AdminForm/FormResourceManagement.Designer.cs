namespace Shared_Novel_Reader.MyForm.AdminForm
{
    partial class FormResourceManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewResourceBook = new System.Windows.Forms.DataGridView();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Synopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripFindResourceBook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReFind = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewChapters = new System.Windows.Forms.ToolStripMenuItem();
            this.Manage = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewResourceBook)).BeginInit();
            this.ContextMenuStripFindResourceBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewResourceBook
            // 
            this.DataGridViewResourceBook.AllowUserToAddRows = false;
            this.DataGridViewResourceBook.AllowUserToDeleteRows = false;
            this.DataGridViewResourceBook.AllowUserToOrderColumns = true;
            this.DataGridViewResourceBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewResourceBook.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewResourceBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewResourceBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewResourceBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewResourceBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_ID,
            this.Book_Name,
            this.Author,
            this.Memo,
            this.Synopsis,
            this.Publisher,
            this.Status,
            this.Create_Time,
            this.Update_Time});
            this.DataGridViewResourceBook.ContextMenuStrip = this.ContextMenuStripFindResourceBook;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewResourceBook.DefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewResourceBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewResourceBook.GridColor = System.Drawing.Color.Peru;
            this.DataGridViewResourceBook.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewResourceBook.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewResourceBook.MultiSelect = false;
            this.DataGridViewResourceBook.Name = "DataGridViewResourceBook";
            this.DataGridViewResourceBook.ReadOnly = true;
            this.DataGridViewResourceBook.RowHeadersVisible = false;
            this.DataGridViewResourceBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewResourceBook.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewResourceBook.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewResourceBook.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewResourceBook.RowTemplate.Height = 30;
            this.DataGridViewResourceBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewResourceBook.Size = new System.Drawing.Size(1150, 690);
            this.DataGridViewResourceBook.TabIndex = 3;
            this.DataGridViewResourceBook.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewResourceBook_CellMouseDown);
            // 
            // Book_ID
            // 
            this.Book_ID.HeaderText = "图书ID";
            this.Book_ID.MinimumWidth = 8;
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.ReadOnly = true;
            // 
            // Book_Name
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Book_Name.DefaultCellStyle = dataGridViewCellStyle2;
            this.Book_Name.HeaderText = "图书名称";
            this.Book_Name.MinimumWidth = 8;
            this.Book_Name.Name = "Book_Name";
            this.Book_Name.ReadOnly = true;
            // 
            // Author
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Author.DefaultCellStyle = dataGridViewCellStyle3;
            this.Author.HeaderText = "图书作者";
            this.Author.MinimumWidth = 8;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // Memo
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Memo.DefaultCellStyle = dataGridViewCellStyle4;
            this.Memo.HeaderText = "图书详情";
            this.Memo.MinimumWidth = 8;
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            // 
            // Synopsis
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Synopsis.DefaultCellStyle = dataGridViewCellStyle5;
            this.Synopsis.HeaderText = "图书简介";
            this.Synopsis.MinimumWidth = 8;
            this.Synopsis.Name = "Synopsis";
            this.Synopsis.ReadOnly = true;
            // 
            // Publisher
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Publisher.DefaultCellStyle = dataGridViewCellStyle6;
            this.Publisher.HeaderText = "出版社";
            this.Publisher.MinimumWidth = 8;
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // Status
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.DefaultCellStyle = dataGridViewCellStyle7;
            this.Status.HeaderText = "图书状态";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Create_Time
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Create_Time.DefaultCellStyle = dataGridViewCellStyle8;
            this.Create_Time.HeaderText = "创建时间";
            this.Create_Time.MinimumWidth = 8;
            this.Create_Time.Name = "Create_Time";
            this.Create_Time.ReadOnly = true;
            // 
            // Update_Time
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Update_Time.DefaultCellStyle = dataGridViewCellStyle9;
            this.Update_Time.HeaderText = "更新时间";
            this.Update_Time.MinimumWidth = 8;
            this.Update_Time.Name = "Update_Time";
            this.Update_Time.ReadOnly = true;
            // 
            // ContextMenuStripFindResourceBook
            // 
            this.ContextMenuStripFindResourceBook.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripFindResourceBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReFind,
            this.ViewDetails,
            this.ViewChapters,
            this.Manage});
            this.ContextMenuStripFindResourceBook.Name = "ContextMenuStripFindUser";
            this.ContextMenuStripFindResourceBook.Size = new System.Drawing.Size(189, 124);
            // 
            // ReFind
            // 
            this.ReFind.Name = "ReFind";
            this.ReFind.Size = new System.Drawing.Size(188, 30);
            this.ReFind.Text = "重置查询范围";
            this.ReFind.Click += new System.EventHandler(this.ReFind_Click);
            // 
            // ViewDetails
            // 
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Size = new System.Drawing.Size(188, 30);
            this.ViewDetails.Text = "查看详情";
            this.ViewDetails.Click += new System.EventHandler(this.ViewDetails_Click);
            // 
            // ViewChapters
            // 
            this.ViewChapters.Name = "ViewChapters";
            this.ViewChapters.Size = new System.Drawing.Size(188, 30);
            this.ViewChapters.Text = "查看章节信息";
            this.ViewChapters.Click += new System.EventHandler(this.ViewChapters_Click);
            // 
            // Manage
            // 
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(188, 30);
            this.Manage.Text = "下架";
            this.Manage.Click += new System.EventHandler(this.Manage_Click);
            // 
            // FormResourceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1150, 690);
            this.Controls.Add(this.DataGridViewResourceBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResourceManagement";
            this.Text = "FormResourceManagement";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewResourceBook)).EndInit();
            this.ContextMenuStripFindResourceBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewResourceBook;
        public System.Windows.Forms.ContextMenuStrip ContextMenuStripFindResourceBook;
        public System.Windows.Forms.ToolStripMenuItem ReFind;
        public System.Windows.Forms.ToolStripMenuItem ViewDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Synopsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Create_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_Time;
        private System.Windows.Forms.ToolStripMenuItem ViewChapters;
        private System.Windows.Forms.ToolStripMenuItem Manage;
    }
}