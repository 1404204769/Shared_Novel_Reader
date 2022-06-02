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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewLocal = new System.Windows.Forms.DataGridView();
            this.ContextMenuStripLocal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateRes = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRes = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadNew = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadChange = new System.Windows.Forms.ToolStripMenuItem();
            this.AddLocalRes = new System.Windows.Forms.ToolStripMenuItem();
            this.EditBookData = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLocalBook = new System.Windows.Forms.TabPage();
            this.tabPageInternetBook = new System.Windows.Forms.TabPage();
            this.DataGridViewInternet = new System.Windows.Forms.DataGridView();
            this.ContextMenuStripInternet = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DownloadResourse = new System.Windows.Forms.ToolStripMenuItem();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KeyNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChapterNum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipStr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChapterNum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipStr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveInternetBookShelf = new System.Windows.Forms.ToolStripMenuItem();
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
            this.DataGridViewLocal.BackgroundColor = System.Drawing.Color.Silver;
            this.DataGridViewLocal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewLocal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLocal.ColumnHeadersVisible = false;
            this.DataGridViewLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Content,
            this.KeyNum,
            this.PartNum1,
            this.ChapterNum1,
            this.TipStr1});
            this.DataGridViewLocal.ContextMenuStrip = this.ContextMenuStripLocal;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewLocal.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewLocal.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewLocal.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewLocal.MultiSelect = false;
            this.DataGridViewLocal.Name = "DataGridViewLocal";
            this.DataGridViewLocal.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewLocal.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewLocal.RowHeadersVisible = false;
            this.DataGridViewLocal.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewLocal.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewLocal.RowTemplate.Height = 30;
            this.DataGridViewLocal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLocal.Size = new System.Drawing.Size(1136, 702);
            this.DataGridViewLocal.TabIndex = 1;
            this.DataGridViewLocal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLocal_CellDoubleClick);
            this.DataGridViewLocal.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewLocal_CellMouseDown);
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
            this.ContextMenuStripLocal.Size = new System.Drawing.Size(233, 184);
            // 
            // CreateRes
            // 
            this.CreateRes.Name = "CreateRes";
            this.CreateRes.Size = new System.Drawing.Size(232, 30);
            this.CreateRes.Text = "新建资源";
            this.CreateRes.Click += new System.EventHandler(this.CreateRes_Click);
            // 
            // DeleteRes
            // 
            this.DeleteRes.Name = "DeleteRes";
            this.DeleteRes.Size = new System.Drawing.Size(232, 30);
            this.DeleteRes.Text = "删除资源";
            this.DeleteRes.Click += new System.EventHandler(this.DeleteRes_Click);
            // 
            // UploadNew
            // 
            this.UploadNew.Name = "UploadNew";
            this.UploadNew.Size = new System.Drawing.Size(232, 30);
            this.UploadNew.Text = "上传新资源";
            this.UploadNew.Visible = false;
            this.UploadNew.Click += new System.EventHandler(this.UploadNew_Click);
            // 
            // UploadChange
            // 
            this.UploadChange.Name = "UploadChange";
            this.UploadChange.Size = new System.Drawing.Size(232, 30);
            this.UploadChange.Text = "上传更改章节";
            this.UploadChange.Visible = false;
            this.UploadChange.Click += new System.EventHandler(this.UploadChange_Click);
            // 
            // AddLocalRes
            // 
            this.AddLocalRes.Name = "AddLocalRes";
            this.AddLocalRes.Size = new System.Drawing.Size(232, 30);
            this.AddLocalRes.Text = "添加本地图书";
            this.AddLocalRes.Click += new System.EventHandler(this.AddLocalRes_Click);
            // 
            // EditBookData
            // 
            this.EditBookData.Name = "EditBookData";
            this.EditBookData.Size = new System.Drawing.Size(232, 30);
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
            this.DataGridViewInternet.BackgroundColor = System.Drawing.Color.Silver;
            this.DataGridViewInternet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewInternet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewInternet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInternet.ColumnHeadersVisible = false;
            this.DataGridViewInternet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.PartNum2,
            this.ChapterNum2,
            this.TipStr2});
            this.DataGridViewInternet.ContextMenuStrip = this.ContextMenuStripInternet;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewInternet.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewInternet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewInternet.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewInternet.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewInternet.MultiSelect = false;
            this.DataGridViewInternet.Name = "DataGridViewInternet";
            this.DataGridViewInternet.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewInternet.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewInternet.RowHeadersVisible = false;
            this.DataGridViewInternet.RowHeadersWidth = 62;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewInternet.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewInternet.RowTemplate.Height = 30;
            this.DataGridViewInternet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewInternet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewInternet.Size = new System.Drawing.Size(1136, 702);
            this.DataGridViewInternet.TabIndex = 2;
            this.DataGridViewInternet.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewInternet_CellDoubleClick);
            // 
            // ContextMenuStripInternet
            // 
            this.ContextMenuStripInternet.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripInternet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DownloadResourse,
            this.RemoveInternetBookShelf});
            this.ContextMenuStripInternet.Name = "ContextMenuStripInternet";
            this.ContextMenuStripInternet.Size = new System.Drawing.Size(241, 97);
            // 
            // DownloadResourse
            // 
            this.DownloadResourse.Name = "DownloadResourse";
            this.DownloadResourse.Size = new System.Drawing.Size(240, 30);
            this.DownloadResourse.Text = "下载此书";
            this.DownloadResourse.Click += new System.EventHandler(this.DownloadResourse_Click);
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Content.DefaultCellStyle = dataGridViewCellStyle2;
            this.Content.FillWeight = 50F;
            this.Content.HeaderText = "书名";
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
            // PartNum1
            // 
            this.PartNum1.HeaderText = "分卷数";
            this.PartNum1.MinimumWidth = 8;
            this.PartNum1.Name = "PartNum1";
            this.PartNum1.ReadOnly = true;
            this.PartNum1.Visible = false;
            this.PartNum1.Width = 8;
            // 
            // ChapterNum1
            // 
            this.ChapterNum1.HeaderText = "章节数";
            this.ChapterNum1.MinimumWidth = 8;
            this.ChapterNum1.Name = "ChapterNum1";
            this.ChapterNum1.ReadOnly = true;
            this.ChapterNum1.Visible = false;
            this.ChapterNum1.Width = 8;
            // 
            // TipStr1
            // 
            this.TipStr1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.TipStr1.DefaultCellStyle = dataGridViewCellStyle3;
            this.TipStr1.FillWeight = 50F;
            this.TipStr1.HeaderText = "状态";
            this.TipStr1.MinimumWidth = 8;
            this.TipStr1.Name = "TipStr1";
            this.TipStr1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "书名";
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
            this.dataGridViewTextBoxColumn2.Width = 98;
            // 
            // PartNum2
            // 
            this.PartNum2.HeaderText = "分卷数";
            this.PartNum2.MinimumWidth = 8;
            this.PartNum2.Name = "PartNum2";
            this.PartNum2.ReadOnly = true;
            this.PartNum2.Visible = false;
            this.PartNum2.Width = 98;
            // 
            // ChapterNum2
            // 
            this.ChapterNum2.HeaderText = "章节数";
            this.ChapterNum2.MinimumWidth = 8;
            this.ChapterNum2.Name = "ChapterNum2";
            this.ChapterNum2.ReadOnly = true;
            this.ChapterNum2.Visible = false;
            this.ChapterNum2.Width = 98;
            // 
            // TipStr2
            // 
            this.TipStr2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipStr2.FillWeight = 50F;
            this.TipStr2.HeaderText = "状态";
            this.TipStr2.MinimumWidth = 8;
            this.TipStr2.Name = "TipStr2";
            this.TipStr2.ReadOnly = true;
            // 
            // RemoveInternetBookShelf
            // 
            this.RemoveInternetBookShelf.Name = "RemoveInternetBookShelf";
            this.RemoveInternetBookShelf.Size = new System.Drawing.Size(240, 30);
            this.RemoveInternetBookShelf.Text = "移出书架";
            this.RemoveInternetBookShelf.Click += new System.EventHandler(this.RemoveInternetBookShelf_Click);
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
        private System.Windows.Forms.TabPage tabPageLocalBook;
        private System.Windows.Forms.TabPage tabPageInternetBook;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripLocal;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripInternet;
        private System.Windows.Forms.ToolStripMenuItem AddLocalRes;
        private System.Windows.Forms.ToolStripMenuItem UploadNew;
        private System.Windows.Forms.ToolStripMenuItem UploadChange;
        private System.Windows.Forms.ToolStripMenuItem EditBookData;
        private System.Windows.Forms.ToolStripMenuItem DownloadResourse;
        private System.Windows.Forms.ToolStripMenuItem CreateRes;
        private System.Windows.Forms.ToolStripMenuItem DeleteRes;
        public System.Windows.Forms.DataGridView DataGridViewLocal;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterNum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipStr1;
        public System.Windows.Forms.DataGridView DataGridViewInternet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterNum2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipStr2;
        private System.Windows.Forms.ToolStripMenuItem RemoveInternetBookShelf;
    }
}