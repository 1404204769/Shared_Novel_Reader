namespace Shared_Novel_Reader.MyForm.AdminForm.Resource
{
    partial class FormChapterContent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewChapterContent = new System.Windows.Forms.DataGridView();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelBookName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelBookNameValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelPartNum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelPartNumValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChapterNum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChapterNumValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChapterTitle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChapterTitleValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripBottom = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelRowNum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelRowNumValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChineseNum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChineseNumValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelVersion = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelVersionValue = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterContent)).BeginInit();
            this.toolStripTop.SuspendLayout();
            this.toolStripBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewChapterContent
            // 
            this.DataGridViewChapterContent.AllowUserToAddRows = false;
            this.DataGridViewChapterContent.AllowUserToDeleteRows = false;
            this.DataGridViewChapterContent.AllowUserToResizeColumns = false;
            this.DataGridViewChapterContent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewChapterContent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewChapterContent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewChapterContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChapterContent.ColumnHeadersVisible = false;
            this.DataGridViewChapterContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Content});
            this.DataGridViewChapterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewChapterContent.Location = new System.Drawing.Point(0, 29);
            this.DataGridViewChapterContent.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewChapterContent.Name = "DataGridViewChapterContent";
            this.DataGridViewChapterContent.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewChapterContent.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewChapterContent.RowHeadersVisible = false;
            this.DataGridViewChapterContent.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataGridViewChapterContent.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewChapterContent.RowTemplate.Height = 30;
            this.DataGridViewChapterContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewChapterContent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewChapterContent.Size = new System.Drawing.Size(928, 1086);
            this.DataGridViewChapterContent.TabIndex = 0;
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
            // toolStripTop
            // 
            this.toolStripTop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelBookName,
            this.toolStripLabelBookNameValue,
            this.toolStripLabelPartNum,
            this.toolStripLabelPartNumValue,
            this.toolStripLabelChapterNum,
            this.toolStripLabelChapterNumValue,
            this.toolStripLabelChapterTitle,
            this.toolStripLabelChapterTitleValue});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(928, 29);
            this.toolStripTop.TabIndex = 1;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // toolStripLabelBookName
            // 
            this.toolStripLabelBookName.Name = "toolStripLabelBookName";
            this.toolStripLabelBookName.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabelBookName.Text = "书名:";
            // 
            // toolStripLabelBookNameValue
            // 
            this.toolStripLabelBookNameValue.Name = "toolStripLabelBookNameValue";
            this.toolStripLabelBookNameValue.Size = new System.Drawing.Size(82, 24);
            this.toolStripLabelBookNameValue.Text = "图书名称";
            this.toolStripLabelBookNameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabelPartNum
            // 
            this.toolStripLabelPartNum.Name = "toolStripLabelPartNum";
            this.toolStripLabelPartNum.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabelPartNum.Text = "卷数:";
            // 
            // toolStripLabelPartNumValue
            // 
            this.toolStripLabelPartNumValue.Name = "toolStripLabelPartNumValue";
            this.toolStripLabelPartNumValue.Size = new System.Drawing.Size(46, 24);
            this.toolStripLabelPartNumValue.Text = "卷数";
            this.toolStripLabelPartNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabelChapterNum
            // 
            this.toolStripLabelChapterNum.Name = "toolStripLabelChapterNum";
            this.toolStripLabelChapterNum.Size = new System.Drawing.Size(68, 24);
            this.toolStripLabelChapterNum.Text = "章节数:";
            this.toolStripLabelChapterNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripLabelChapterNumValue
            // 
            this.toolStripLabelChapterNumValue.Name = "toolStripLabelChapterNumValue";
            this.toolStripLabelChapterNumValue.Size = new System.Drawing.Size(64, 24);
            this.toolStripLabelChapterNumValue.Text = "章节数";
            this.toolStripLabelChapterNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabelChapterTitle
            // 
            this.toolStripLabelChapterTitle.Name = "toolStripLabelChapterTitle";
            this.toolStripLabelChapterTitle.Size = new System.Drawing.Size(86, 24);
            this.toolStripLabelChapterTitle.Text = "章节标题:";
            this.toolStripLabelChapterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripLabelChapterTitleValue
            // 
            this.toolStripLabelChapterTitleValue.Name = "toolStripLabelChapterTitleValue";
            this.toolStripLabelChapterTitleValue.Size = new System.Drawing.Size(82, 24);
            this.toolStripLabelChapterTitleValue.Text = "章节标题";
            this.toolStripLabelChapterTitleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripBottom
            // 
            this.toolStripBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripBottom.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelRowNum,
            this.toolStripLabelRowNumValue,
            this.toolStripLabelChineseNum,
            this.toolStripLabelChineseNumValue,
            this.toolStripLabelVersionValue,
            this.toolStripLabelVersion});
            this.toolStripBottom.Location = new System.Drawing.Point(0, 1115);
            this.toolStripBottom.Name = "toolStripBottom";
            this.toolStripBottom.Size = new System.Drawing.Size(928, 29);
            this.toolStripBottom.TabIndex = 2;
            this.toolStripBottom.Text = "toolStrip1";
            // 
            // toolStripLabelRowNum
            // 
            this.toolStripLabelRowNum.Name = "toolStripLabelRowNum";
            this.toolStripLabelRowNum.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabelRowNum.Text = "行数:";
            this.toolStripLabelRowNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripLabelRowNumValue
            // 
            this.toolStripLabelRowNumValue.Name = "toolStripLabelRowNumValue";
            this.toolStripLabelRowNumValue.Size = new System.Drawing.Size(46, 24);
            this.toolStripLabelRowNumValue.Text = "行数";
            this.toolStripLabelRowNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabelChineseNum
            // 
            this.toolStripLabelChineseNum.Name = "toolStripLabelChineseNum";
            this.toolStripLabelChineseNum.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabelChineseNum.Text = "字数:";
            this.toolStripLabelChineseNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripLabelChineseNumValue
            // 
            this.toolStripLabelChineseNumValue.Name = "toolStripLabelChineseNumValue";
            this.toolStripLabelChineseNumValue.Size = new System.Drawing.Size(46, 24);
            this.toolStripLabelChineseNumValue.Text = "字数";
            this.toolStripLabelChineseNumValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabelVersion
            // 
            this.toolStripLabelVersion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelVersion.Name = "toolStripLabelVersion";
            this.toolStripLabelVersion.Size = new System.Drawing.Size(50, 24);
            this.toolStripLabelVersion.Text = "版本:";
            this.toolStripLabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripLabelVersionValue
            // 
            this.toolStripLabelVersionValue.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelVersionValue.Name = "toolStripLabelVersionValue";
            this.toolStripLabelVersionValue.Size = new System.Drawing.Size(46, 24);
            this.toolStripLabelVersionValue.Text = "版本";
            this.toolStripLabelVersionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormChapterContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 1144);
            this.Controls.Add(this.DataGridViewChapterContent);
            this.Controls.Add(this.toolStripTop);
            this.Controls.Add(this.toolStripBottom);
            this.Name = "FormChapterContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看章节内容";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterContent)).EndInit();
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.toolStripBottom.ResumeLayout(false);
            this.toolStripBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewChapterContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPartNum;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChapterNum;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBookName;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBookNameValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChapterNumValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPartNumValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChapterTitle;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChapterTitleValue;
        private System.Windows.Forms.ToolStrip toolStripBottom;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRowNum;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRowNumValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChineseNum;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChineseNumValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabelVersionValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabelVersion;
    }
}