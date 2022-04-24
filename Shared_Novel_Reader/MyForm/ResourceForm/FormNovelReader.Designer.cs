namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    partial class FormNovelReader
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.DataGridViewList = new System.Windows.Forms.DataGridView();
            this.ChapterTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChapterNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewContent = new System.Windows.Forms.DataGridView();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContent)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer.Panel1.Controls.Add(this.DataGridViewList);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer.Panel2.Controls.Add(this.DataGridViewContent);
            this.splitContainer.Size = new System.Drawing.Size(1228, 1044);
            this.splitContainer.SplitterDistance = 408;
            this.splitContainer.TabIndex = 0;
            // 
            // DataGridViewList
            // 
            this.DataGridViewList.AllowUserToAddRows = false;
            this.DataGridViewList.AllowUserToDeleteRows = false;
            this.DataGridViewList.AllowUserToResizeColumns = false;
            this.DataGridViewList.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChapterTitle,
            this.PartNum,
            this.ChapterNum});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewList.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewList.Name = "DataGridViewList";
            this.DataGridViewList.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewList.RowHeadersVisible = false;
            this.DataGridViewList.RowHeadersWidth = 62;
            this.DataGridViewList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewList.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridViewList.RowTemplate.Height = 30;
            this.DataGridViewList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewList.Size = new System.Drawing.Size(408, 1044);
            this.DataGridViewList.TabIndex = 0;
            this.DataGridViewList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewList_CellDoubleClick);
            // 
            // ChapterTitle
            // 
            this.ChapterTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChapterTitle.DefaultCellStyle = dataGridViewCellStyle10;
            this.ChapterTitle.HeaderText = "章节名";
            this.ChapterTitle.MinimumWidth = 8;
            this.ChapterTitle.Name = "ChapterTitle";
            this.ChapterTitle.ReadOnly = true;
            this.ChapterTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PartNum
            // 
            this.PartNum.HeaderText = "分卷数";
            this.PartNum.MinimumWidth = 8;
            this.PartNum.Name = "PartNum";
            this.PartNum.ReadOnly = true;
            this.PartNum.Visible = false;
            this.PartNum.Width = 150;
            // 
            // ChapterNum
            // 
            this.ChapterNum.HeaderText = "章节数";
            this.ChapterNum.MinimumWidth = 8;
            this.ChapterNum.Name = "ChapterNum";
            this.ChapterNum.ReadOnly = true;
            this.ChapterNum.Visible = false;
            this.ChapterNum.Width = 150;
            // 
            // DataGridViewContent
            // 
            this.DataGridViewContent.AllowUserToAddRows = false;
            this.DataGridViewContent.AllowUserToDeleteRows = false;
            this.DataGridViewContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Content});
            this.DataGridViewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewContent.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewContent.Name = "DataGridViewContent";
            this.DataGridViewContent.ReadOnly = true;
            this.DataGridViewContent.RowHeadersVisible = false;
            this.DataGridViewContent.RowHeadersWidth = 62;
            this.DataGridViewContent.RowTemplate.Height = 30;
            this.DataGridViewContent.Size = new System.Drawing.Size(816, 1044);
            this.DataGridViewContent.TabIndex = 0;
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Content.DefaultCellStyle = dataGridViewCellStyle14;
            this.Content.HeaderText = "内容";
            this.Content.MinimumWidth = 8;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // FormNovelReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 1044);
            this.Controls.Add(this.splitContainer);
            this.Name = "FormNovelReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小说阅读器";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView DataGridViewList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterNum;
        private System.Windows.Forms.DataGridView DataGridViewContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
    }
}