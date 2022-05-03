namespace Shared_Novel_Reader.MyForm.ToolForm
{
    partial class FormUploadChange
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewList = new System.Windows.Forms.DataGridView();
            this.PanelBtn = new System.Windows.Forms.Panel();
            this.LabelAllYes = new System.Windows.Forms.Label();
            this.LabelAllNo = new System.Windows.Forms.Label();
            this.LabelYes = new System.Windows.Forms.Label();
            this.LabelNo = new System.Windows.Forms.Label();
            this.CheckBoxRow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChapterTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChapterNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OringeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewList)).BeginInit();
            this.PanelBtn.SuspendLayout();
            this.SuspendLayout();
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
            this.CheckBoxRow,
            this.ChapterTitle,
            this.PartNum,
            this.ChapterNum,
            this.BookID,
            this.OringeTitle,
            this.ContentVersion});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewList.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewList.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewList.MultiSelect = false;
            this.DataGridViewList.Name = "DataGridViewList";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewList.RowHeadersVisible = false;
            this.DataGridViewList.RowHeadersWidth = 62;
            this.DataGridViewList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewList.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewList.RowTemplate.Height = 30;
            this.DataGridViewList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewList.Size = new System.Drawing.Size(600, 820);
            this.DataGridViewList.TabIndex = 1;
            this.DataGridViewList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewList_CellContentClick);
            // 
            // PanelBtn
            // 
            this.PanelBtn.Controls.Add(this.LabelNo);
            this.PanelBtn.Controls.Add(this.LabelYes);
            this.PanelBtn.Controls.Add(this.LabelAllNo);
            this.PanelBtn.Controls.Add(this.LabelAllYes);
            this.PanelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBtn.Location = new System.Drawing.Point(0, 820);
            this.PanelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBtn.Name = "PanelBtn";
            this.PanelBtn.Size = new System.Drawing.Size(600, 30);
            this.PanelBtn.TabIndex = 2;
            // 
            // LabelAllYes
            // 
            this.LabelAllYes.AutoSize = true;
            this.LabelAllYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAllYes.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelAllYes.Location = new System.Drawing.Point(22, 8);
            this.LabelAllYes.Margin = new System.Windows.Forms.Padding(0);
            this.LabelAllYes.Name = "LabelAllYes";
            this.LabelAllYes.Size = new System.Drawing.Size(44, 18);
            this.LabelAllYes.TabIndex = 0;
            this.LabelAllYes.Text = "全选";
            this.LabelAllYes.Click += new System.EventHandler(this.LabelAllYes_Click);
            // 
            // LabelAllNo
            // 
            this.LabelAllNo.AutoSize = true;
            this.LabelAllNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAllNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelAllNo.Location = new System.Drawing.Point(75, 8);
            this.LabelAllNo.Margin = new System.Windows.Forms.Padding(0);
            this.LabelAllNo.Name = "LabelAllNo";
            this.LabelAllNo.Size = new System.Drawing.Size(62, 18);
            this.LabelAllNo.TabIndex = 1;
            this.LabelAllNo.Text = "全不选";
            this.LabelAllNo.Click += new System.EventHandler(this.LabelAllNo_Click);
            // 
            // LabelYes
            // 
            this.LabelYes.AutoSize = true;
            this.LabelYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LabelYes.Location = new System.Drawing.Point(455, 8);
            this.LabelYes.Margin = new System.Windows.Forms.Padding(0);
            this.LabelYes.Name = "LabelYes";
            this.LabelYes.Size = new System.Drawing.Size(44, 18);
            this.LabelYes.TabIndex = 2;
            this.LabelYes.Text = "确定";
            this.LabelYes.Click += new System.EventHandler(this.LabelYes_Click);
            // 
            // LabelNo
            // 
            this.LabelNo.AutoSize = true;
            this.LabelNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelNo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelNo.Location = new System.Drawing.Point(512, 8);
            this.LabelNo.Margin = new System.Windows.Forms.Padding(0);
            this.LabelNo.Name = "LabelNo";
            this.LabelNo.Size = new System.Drawing.Size(44, 18);
            this.LabelNo.TabIndex = 3;
            this.LabelNo.Text = "取消";
            this.LabelNo.Click += new System.EventHandler(this.LabelNo_Click);
            // 
            // CheckBoxRow
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "0";
            this.CheckBoxRow.DefaultCellStyle = dataGridViewCellStyle3;
            this.CheckBoxRow.FalseValue = "False";
            this.CheckBoxRow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckBoxRow.HeaderText = "";
            this.CheckBoxRow.IndeterminateValue = "False";
            this.CheckBoxRow.MinimumWidth = 8;
            this.CheckBoxRow.Name = "CheckBoxRow";
            this.CheckBoxRow.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckBoxRow.TrueValue = "True";
            this.CheckBoxRow.Width = 50;
            // 
            // ChapterTitle
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ChapterTitle.DefaultCellStyle = dataGridViewCellStyle4;
            this.ChapterTitle.HeaderText = "章节名";
            this.ChapterTitle.MinimumWidth = 8;
            this.ChapterTitle.Name = "ChapterTitle";
            this.ChapterTitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ChapterTitle.Visible = false;
            this.ChapterTitle.Width = 150;
            // 
            // PartNum
            // 
            this.PartNum.HeaderText = "分卷数";
            this.PartNum.MinimumWidth = 8;
            this.PartNum.Name = "PartNum";
            this.PartNum.ReadOnly = true;
            this.PartNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ChapterNum
            // 
            this.ChapterNum.HeaderText = "章节数";
            this.ChapterNum.MinimumWidth = 8;
            this.ChapterNum.Name = "ChapterNum";
            this.ChapterNum.ReadOnly = true;
            this.ChapterNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "图书ID";
            this.BookID.MinimumWidth = 8;
            this.BookID.Name = "BookID";
            this.BookID.Visible = false;
            this.BookID.Width = 150;
            // 
            // OringeTitle
            // 
            this.OringeTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OringeTitle.HeaderText = "章节标题";
            this.OringeTitle.MinimumWidth = 8;
            this.OringeTitle.Name = "OringeTitle";
            this.OringeTitle.ReadOnly = true;
            // 
            // ContentVersion
            // 
            this.ContentVersion.HeaderText = "章节内容版本";
            this.ContentVersion.MinimumWidth = 8;
            this.ContentVersion.Name = "ContentVersion";
            this.ContentVersion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ContentVersion.Visible = false;
            this.ContentVersion.Width = 150;
            // 
            // FormUploadChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 850);
            this.Controls.Add(this.DataGridViewList);
            this.Controls.Add(this.PanelBtn);
            this.Name = "FormUploadChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择要上传更正的章节";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewList)).EndInit();
            this.PanelBtn.ResumeLayout(false);
            this.PanelBtn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewList;
        private System.Windows.Forms.Panel PanelBtn;
        private System.Windows.Forms.Label LabelAllYes;
        private System.Windows.Forms.Label LabelAllNo;
        private System.Windows.Forms.Label LabelYes;
        private System.Windows.Forms.Label LabelNo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChapterNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OringeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContentVersion;
    }
}