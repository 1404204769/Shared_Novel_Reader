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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelBookName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelBookNameValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelPartNum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelPartNumValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChapterNum = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChapterNumValue = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChapterTitle = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelChapterTitleValue = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterContent)).BeginInit();
            this.toolStrip.SuspendLayout();
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
            this.DataGridViewChapterContent.Size = new System.Drawing.Size(928, 1115);
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
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelBookName,
            this.toolStripLabelBookNameValue,
            this.toolStripLabelPartNum,
            this.toolStripLabelPartNumValue,
            this.toolStripLabelChapterNum,
            this.toolStripLabelChapterNumValue,
            this.toolStripLabelChapterTitle,
            this.toolStripLabelChapterTitleValue});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(928, 29);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
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
            // FormChapterContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 1144);
            this.Controls.Add(this.DataGridViewChapterContent);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormChapterContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查看章节内容";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChapterContent)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewChapterContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPartNum;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChapterNum;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBookName;
        private System.Windows.Forms.ToolStripLabel toolStripLabelBookNameValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChapterNumValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPartNumValue;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChapterTitle;
        private System.Windows.Forms.ToolStripLabel toolStripLabelChapterTitleValue;
    }
}