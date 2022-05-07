namespace Shared_Novel_Reader.MyForm
{
    partial class FormBookShelf
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewLocal = new System.Windows.Forms.DataGridView();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripLocal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddLocalRes = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadNew = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadChange = new System.Windows.Forms.ToolStripMenuItem();
            this.EditBookData = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLocalBook = new System.Windows.Forms.TabPage();
            this.tabPageInternetBook = new System.Windows.Forms.TabPage();
            this.DataGridViewInternet = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripInternet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DownloadResourse = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateRes = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocal)).BeginInit();
            this.ContextMenuStripLocal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageLocalBook.SuspendLayout();
            this.tabPageInternetBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInternet)).BeginInit();
            this.ContextMenuStripInternet.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewLocal
            // 
            this.DataGridViewLocal.AllowUserToAddRows = false;
            this.DataGridViewLocal.AllowUserToDeleteRows = false;
            this.DataGridViewLocal.AllowUserToResizeColumns = false;
            this.DataGridViewLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewLocal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewLocal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLocal.ColumnHeadersVisible = false;
            this.DataGridViewLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Content,
            this.KeyNum});
            this.DataGridViewLocal.ContextMenuStrip = this.ContextMenuStripLocal;
            this.DataGridViewLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewLocal.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewLocal.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewLocal.MultiSelect = false;
            this.DataGridViewLocal.Name = "DataGridViewLocal";
            this.DataGridViewLocal.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewLocal.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewLocal.RowHeadersVisible = false;
            this.DataGridViewLocal.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataGridViewLocal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewLocal.RowTemplate.Height = 30;
            this.DataGridViewLocal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLocal.Size = new System.Drawing.Size(1136, 702);
            this.DataGridViewLocal.TabIndex = 1;
            this.DataGridViewLocal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLocal_CellDoubleClick);
            this.DataGridViewLocal.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewLocal_CellMouseDown);
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Content.DefaultCellStyle = dataGridViewCellStyle1;
            this.Content.HeaderText = "内容";
            this.Content.MinimumWidth = 8;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // KeyNum
            // 
            this.KeyNum.HeaderText = "关键字";
            this.KeyNum.MinimumWidth = 8;
            this.KeyNum.Name = "KeyNum";
            this.KeyNum.ReadOnly = true;
            this.KeyNum.Visible = false;
            this.KeyNum.Width = 8;
            // 
            // ContextMenuStripLocal
            // 
            this.ContextMenuStripLocal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripLocal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateRes,
            this.DeleteRes,
            this.UploadNew,
            this.UploadChange,
            this.AddLocalRes,
            this.EditBookData});
            this.ContextMenuStripLocal.Name = "ContextMenuStripLocal";
            this.ContextMenuStripLocal.Size = new System.Drawing.Size(241, 217);
            // 
            // AddLocalRes
            // 
            this.AddLocalRes.Name = "AddLocalRes";
            this.AddLocalRes.Size = new System.Drawing.Size(240, 30);
            this.AddLocalRes.Text = "添加本地图书";
            this.AddLocalRes.Click += new System.EventHandler(this.AddLocalRes_Click);
            // 
            // UploadNew
            // 
            this.UploadNew.Name = "UploadNew";
            this.UploadNew.Size = new System.Drawing.Size(240, 30);
            this.UploadNew.Text = "上传新资源";
            this.UploadNew.Visible = false;
            this.UploadNew.Click += new System.EventHandler(this.UploadNew_Click);
            // 
            // UploadChange
            // 
            this.UploadChange.Name = "UploadChange";
            this.UploadChange.Size = new System.Drawing.Size(240, 30);
            this.UploadChange.Text = "上传更改章节";
            this.UploadChange.Visible = false;
            this.UploadChange.Click += new System.EventHandler(this.UploadChange_Click);
            // 
            // EditBookData
            // 
            this.EditBookData.Name = "EditBookData";
            this.EditBookData.Size = new System.Drawing.Size(240, 30);
            this.EditBookData.Text = "查看/修改图书信息";
            this.EditBookData.Visible = false;
            this.EditBookData.Click += new System.EventHandler(this.EditBookData_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLocalBook);
            this.tabControl1.Controls.Add(this.tabPageInternetBook);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1150, 740);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageLocalBook
            // 
            this.tabPageLocalBook.Controls.Add(this.DataGridViewLocal);
            this.tabPageLocalBook.Location = new System.Drawing.Point(4, 28);
            this.tabPageLocalBook.Name = "tabPageLocalBook";
            this.tabPageLocalBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLocalBook.Size = new System.Drawing.Size(1142, 708);
            this.tabPageLocalBook.TabIndex = 0;
            this.tabPageLocalBook.Text = "本地书架";
            this.tabPageLocalBook.UseVisualStyleBackColor = true;
            // 
            // tabPageInternetBook
            // 
            this.tabPageInternetBook.Controls.Add(this.DataGridViewInternet);
            this.tabPageInternetBook.Location = new System.Drawing.Point(4, 28);
            this.tabPageInternetBook.Name = "tabPageInternetBook";
            this.tabPageInternetBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInternetBook.Size = new System.Drawing.Size(1142, 708);
            this.tabPageInternetBook.TabIndex = 1;
            this.tabPageInternetBook.Text = "在线书架";
            this.tabPageInternetBook.UseVisualStyleBackColor = true;
            // 
            // DataGridViewInternet
            // 
            this.DataGridViewInternet.AllowUserToAddRows = false;
            this.DataGridViewInternet.AllowUserToDeleteRows = false;
            this.DataGridViewInternet.AllowUserToResizeColumns = false;
            this.DataGridViewInternet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewInternet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewInternet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewInternet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInternet.ColumnHeadersVisible = false;
            this.DataGridViewInternet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.DataGridViewInternet.ContextMenuStrip = this.ContextMenuStripInternet;
            this.DataGridViewInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewInternet.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewInternet.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewInternet.MultiSelect = false;
            this.DataGridViewInternet.Name = "DataGridViewInternet";
            this.DataGridViewInternet.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewInternet.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewInternet.RowHeadersVisible = false;
            this.DataGridViewInternet.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataGridViewInternet.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewInternet.RowTemplate.Height = 30;
            this.DataGridViewInternet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewInternet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInternet.Size = new System.Drawing.Size(1136, 702);
            this.DataGridViewInternet.TabIndex = 2;
            this.DataGridViewInternet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewInternet_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn1.HeaderText = "内容";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "关键字";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 8;
            // 
            // ContextMenuStripInternet
            // 
            this.ContextMenuStripInternet.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripInternet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadResourse});
            this.ContextMenuStripInternet.Name = "ContextMenuStripInternet";
            this.ContextMenuStripInternet.Size = new System.Drawing.Size(153, 34);
            // 
            // DownloadResourse
            // 
            this.DownloadResourse.Name = "DownloadResourse";
            this.DownloadResourse.Size = new System.Drawing.Size(152, 30);
            this.DownloadResourse.Text = "下载此书";
            this.DownloadResourse.Click += new System.EventHandler(this.DownloadResourse_Click);
            // 
            // CreateRes
            // 
            this.CreateRes.Name = "CreateRes";
            this.CreateRes.Size = new System.Drawing.Size(240, 30);
            this.CreateRes.Text = "新建资源";
            this.CreateRes.Click += new System.EventHandler(this.CreateRes_Click);
            // 
            // DeleteRes
            // 
            this.DeleteRes.Name = "DeleteRes";
            this.DeleteRes.Size = new System.Drawing.Size(240, 30);
            this.DeleteRes.Text = "删除资源";
            this.DeleteRes.Click += new System.EventHandler(this.DeleteRes_Click);
            // 
            // FormBookShelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookShelf";
            this.Text = "FormBookShelf";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBookShelf_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocal)).EndInit();
            this.ContextMenuStripLocal.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageLocalBook.ResumeLayout(false);
            this.tabPageInternetBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInternet)).EndInit();
            this.ContextMenuStripInternet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyNum;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLocalBook;
        private System.Windows.Forms.TabPage tabPageInternetBook;
        private System.Windows.Forms.DataGridView DataGridViewInternet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripLocal;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripInternet;
        private System.Windows.Forms.ToolStripMenuItem AddLocalRes;
        private System.Windows.Forms.ToolStripMenuItem UploadNew;
        private System.Windows.Forms.ToolStripMenuItem UploadChange;
        private System.Windows.Forms.ToolStripMenuItem EditBookData;
        private System.Windows.Forms.ToolStripMenuItem DownloadResourse;
        private System.Windows.Forms.ToolStripMenuItem CreateRes;
        private System.Windows.Forms.ToolStripMenuItem DeleteRes;
    }
}