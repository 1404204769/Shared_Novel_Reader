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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.DataGridViewList = new System.Windows.Forms.DataGridView();
            this.ChapterTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChapterNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OringeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InsertChapter = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteChapter = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseChapter = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateChapter = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewContent = new System.Windows.Forms.DataGridView();
            this.ContextMenuStripContent = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateChapterContent = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveUpRow = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveDownRow = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertUpRow = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertDownRow = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.EditRow = new System.Windows.Forms.ToolStripMenuItem();
            this.ChapContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewList)).BeginInit();
            this.ContextMenuStripList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContent)).BeginInit();
            this.ContextMenuStripContent.SuspendLayout();
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
            this.splitContainer.SplitterDistance = 328;
            this.splitContainer.TabIndex = 0;
            // 
            // DataGridViewList
            // 
            this.DataGridViewList.AllowUserToAddRows = false;
            this.DataGridViewList.AllowUserToDeleteRows = false;
            this.DataGridViewList.AllowUserToResizeColumns = false;
            this.DataGridViewList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewList.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChapterTitle,
            this.PartNum,
            this.ChapterNum,
            this.BookID,
            this.OringeTitle,
            this.ContentVersion});
            this.DataGridViewList.ContextMenuStrip = this.ContextMenuStripList;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewList.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewList.MultiSelect = false;
            this.DataGridViewList.Name = "DataGridViewList";
            this.DataGridViewList.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewList.RowHeadersVisible = false;
            this.DataGridViewList.RowHeadersWidth = 62;
            this.DataGridViewList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataGridViewList.RowTemplate.Height = 30;
            this.DataGridViewList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewList.Size = new System.Drawing.Size(328, 1044);
            this.DataGridViewList.TabIndex = 0;
            this.DataGridViewList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewList_CellClick);
            this.DataGridViewList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewList_CellMouseDown);
            this.DataGridViewList.SelectionChanged += new System.EventHandler(this.DataGridViewList_SelectionChanged);
            // 
            // ChapterTitle
            // 
            this.ChapterTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChapterTitle.DefaultCellStyle = dataGridViewCellStyle3;
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
            // BookID
            // 
            this.BookID.HeaderText = "图书ID";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Visible = false;
            this.BookID.Width = 150;
            // 
            // OringeTitle
            // 
            this.OringeTitle.HeaderText = "章节原始名";
            this.OringeTitle.MinimumWidth = 8;
            this.OringeTitle.Name = "OringeTitle";
            this.OringeTitle.ReadOnly = true;
            this.OringeTitle.Visible = false;
            this.OringeTitle.Width = 150;
            // 
            // ContentVersion
            // 
            this.ContentVersion.HeaderText = "章节内容版本";
            this.ContentVersion.MinimumWidth = 8;
            this.ContentVersion.Name = "ContentVersion";
            this.ContentVersion.ReadOnly = true;
            this.ContentVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ContentVersion.Visible = false;
            this.ContentVersion.Width = 150;
            // 
            // ContextMenuStripList
            // 
            this.ContextMenuStripList.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InsertChapter,
            this.DeleteChapter,
            this.ChooseChapter,
            this.UpdateChapter});
            this.ContextMenuStripList.Name = "ContextMenuStripList";
            this.ContextMenuStripList.Size = new System.Drawing.Size(189, 124);
            // 
            // InsertChapter
            // 
            this.InsertChapter.Name = "InsertChapter";
            this.InsertChapter.Size = new System.Drawing.Size(188, 30);
            this.InsertChapter.Text = "新增章节";
            this.InsertChapter.Click += new System.EventHandler(this.InsertChapter_Click);
            // 
            // DeleteChapter
            // 
            this.DeleteChapter.Name = "DeleteChapter";
            this.DeleteChapter.Size = new System.Drawing.Size(188, 30);
            this.DeleteChapter.Text = "删除此章节";
            this.DeleteChapter.Click += new System.EventHandler(this.DeleteChapter_Click);
            // 
            // ChooseChapter
            // 
            this.ChooseChapter.Name = "ChooseChapter";
            this.ChooseChapter.Size = new System.Drawing.Size(188, 30);
            this.ChooseChapter.Text = "选择此版本";
            this.ChooseChapter.Click += new System.EventHandler(this.ChooseChapter_Click);
            // 
            // UpdateChapter
            // 
            this.UpdateChapter.Name = "UpdateChapter";
            this.UpdateChapter.Size = new System.Drawing.Size(188, 30);
            this.UpdateChapter.Text = "更改章节标题";
            this.UpdateChapter.Click += new System.EventHandler(this.UpdateChapter_Click);
            // 
            // DataGridViewContent
            // 
            this.DataGridViewContent.AllowUserToAddRows = false;
            this.DataGridViewContent.AllowUserToDeleteRows = false;
            this.DataGridViewContent.AllowUserToResizeColumns = false;
            this.DataGridViewContent.AllowUserToResizeRows = false;
            this.DataGridViewContent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DataGridViewContent.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewContent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGridViewContent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewContent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChapContent});
            this.DataGridViewContent.ContextMenuStrip = this.ContextMenuStripContent;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewContent.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewContent.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewContent.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewContent.MultiSelect = false;
            this.DataGridViewContent.Name = "DataGridViewContent";
            this.DataGridViewContent.ReadOnly = true;
            this.DataGridViewContent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewContent.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewContent.RowHeadersVisible = false;
            this.DataGridViewContent.RowHeadersWidth = 62;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewContent.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewContent.RowTemplate.Height = 30;
            this.DataGridViewContent.Size = new System.Drawing.Size(896, 1044);
            this.DataGridViewContent.TabIndex = 0;
            this.DataGridViewContent.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridViewContent_CellMouseDown);
            this.DataGridViewContent.SelectionChanged += new System.EventHandler(this.DataGridViewContent_SelectionChanged);
            // 
            // ContextMenuStripContent
            // 
            this.ContextMenuStripContent.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripContent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateChapterContent,
            this.MoveUpRow,
            this.MoveDownRow,
            this.InsertUpRow,
            this.InsertDownRow,
            this.DeleteRow,
            this.EditRow});
            this.ContextMenuStripContent.Name = "ContextMenuStripContent";
            this.ContextMenuStripContent.Size = new System.Drawing.Size(207, 214);
            // 
            // UpdateChapterContent
            // 
            this.UpdateChapterContent.Name = "UpdateChapterContent";
            this.UpdateChapterContent.Size = new System.Drawing.Size(206, 30);
            this.UpdateChapterContent.Text = "更改章节内容";
            this.UpdateChapterContent.Click += new System.EventHandler(this.UpdateChapterContent_Click);
            // 
            // MoveUpRow
            // 
            this.MoveUpRow.Name = "MoveUpRow";
            this.MoveUpRow.Size = new System.Drawing.Size(206, 30);
            this.MoveUpRow.Text = "上移此行";
            this.MoveUpRow.Visible = false;
            this.MoveUpRow.Click += new System.EventHandler(this.MoveUpRow_Click);
            // 
            // MoveDownRow
            // 
            this.MoveDownRow.Name = "MoveDownRow";
            this.MoveDownRow.Size = new System.Drawing.Size(206, 30);
            this.MoveDownRow.Text = "下移此行";
            this.MoveDownRow.Visible = false;
            this.MoveDownRow.Click += new System.EventHandler(this.MoveDownRow_Click);
            // 
            // InsertUpRow
            // 
            this.InsertUpRow.Name = "InsertUpRow";
            this.InsertUpRow.Size = new System.Drawing.Size(206, 30);
            this.InsertUpRow.Text = "在上方插入一行";
            this.InsertUpRow.Visible = false;
            this.InsertUpRow.Click += new System.EventHandler(this.InsertUpRow_Click);
            // 
            // InsertDownRow
            // 
            this.InsertDownRow.Name = "InsertDownRow";
            this.InsertDownRow.Size = new System.Drawing.Size(206, 30);
            this.InsertDownRow.Text = "在下方新增一行";
            this.InsertDownRow.Visible = false;
            this.InsertDownRow.Click += new System.EventHandler(this.InsertDownRow_Click);
            // 
            // DeleteRow
            // 
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(206, 30);
            this.DeleteRow.Text = "删除此行";
            this.DeleteRow.Visible = false;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // EditRow
            // 
            this.EditRow.ForeColor = System.Drawing.Color.Black;
            this.EditRow.Name = "EditRow";
            this.EditRow.Size = new System.Drawing.Size(206, 30);
            this.EditRow.Text = "编辑此行";
            this.EditRow.Visible = false;
            this.EditRow.Click += new System.EventHandler(this.EditRow_Click);
            // 
            // ChapContent
            // 
            this.ChapContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.ChapContent.DefaultCellStyle = dataGridViewCellStyle8;
            this.ChapContent.HeaderText = "内容";
            this.ChapContent.MinimumWidth = 8;
            this.ChapContent.Name = "ChapContent";
            this.ChapContent.ReadOnly = true;
            this.ChapContent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ChapContent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormNovelReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 1044);
            this.Controls.Add(this.splitContainer);
            this.DoubleBuffered = true;
            this.Name = "FormNovelReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小说阅读器";
            this.Load += new System.EventHandler(this.FormNovelReader_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewList)).EndInit();
            this.ContextMenuStripList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewContent)).EndInit();
            this.ContextMenuStripContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView DataGridViewList;
        private System.Windows.Forms.DataGridView DataGridViewContent;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripList;
        private System.Windows.Forms.ToolStripMenuItem UpdateChapter;
        private System.Windows.Forms.ToolStripMenuItem DeleteChapter;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStripContent;
        private System.Windows.Forms.ToolStripMenuItem UpdateChapterContent;
        private System.Windows.Forms.ToolStripMenuItem MoveUpRow;
        private System.Windows.Forms.ToolStripMenuItem MoveDownRow;
        private System.Windows.Forms.ToolStripMenuItem InsertUpRow;
        private System.Windows.Forms.ToolStripMenuItem InsertDownRow;
        private System.Windows.Forms.ToolStripMenuItem DeleteRow;
        private System.Windows.Forms.ToolStripMenuItem EditRow;
        private System.Windows.Forms.ToolStripMenuItem InsertChapter;
        private System.Windows.Forms.ToolStripMenuItem ChooseChapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OringeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapContent;
    }
}