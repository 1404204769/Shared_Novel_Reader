namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    partial class FormNoteDetail
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
            this.Panel = new System.Windows.Forms.Panel();
            this.LabelJoin = new System.Windows.Forms.Label();
            this.labelViewBook = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.FlowLayoutPanelNoteComment = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelComment = new System.Windows.Forms.Panel();
            this.TextComment = new System.Windows.Forms.TextBox();
            this.ButtonReport = new System.Windows.Forms.Button();
            this.PictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.PictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.Panel.SuspendLayout();
            this.PanelComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Panel.Controls.Add(this.PictureBoxRefresh);
            this.Panel.Controls.Add(this.PictureBoxReturn);
            this.Panel.Controls.Add(this.LabelJoin);
            this.Panel.Controls.Add(this.labelViewBook);
            this.Panel.Controls.Add(this.labelContent);
            this.Panel.Controls.Add(this.labelTitle);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1150, 200);
            this.Panel.TabIndex = 0;
            // 
            // LabelJoin
            // 
            this.LabelJoin.AutoSize = true;
            this.LabelJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelJoin.ForeColor = System.Drawing.Color.DarkCyan;
            this.LabelJoin.Location = new System.Drawing.Point(1033, 34);
            this.LabelJoin.Name = "LabelJoin";
            this.LabelJoin.Size = new System.Drawing.Size(80, 18);
            this.LabelJoin.TabIndex = 6;
            this.LabelJoin.Text = "加入书架";
            this.LabelJoin.Click += new System.EventHandler(this.LabelJoin_Click);
            // 
            // labelViewBook
            // 
            this.labelViewBook.AutoSize = true;
            this.labelViewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelViewBook.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelViewBook.Location = new System.Drawing.Point(912, 34);
            this.labelViewBook.Name = "labelViewBook";
            this.labelViewBook.Size = new System.Drawing.Size(80, 18);
            this.labelViewBook.TabIndex = 5;
            this.labelViewBook.Text = "在线阅读";
            this.labelViewBook.Click += new System.EventHandler(this.labelViewBook_Click);
            // 
            // labelContent
            // 
            this.labelContent.BackColor = System.Drawing.Color.White;
            this.labelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelContent.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.ForeColor = System.Drawing.Color.Black;
            this.labelContent.Location = new System.Drawing.Point(22, 83);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(1101, 104);
            this.labelContent.TabIndex = 4;
            this.labelContent.Text = "帖子内容";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(73, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(451, 32);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "帖子标题";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FlowLayoutPanelNoteComment
            // 
            this.FlowLayoutPanelNoteComment.BackColor = System.Drawing.Color.RosyBrown;
            this.FlowLayoutPanelNoteComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanelNoteComment.Location = new System.Drawing.Point(0, 200);
            this.FlowLayoutPanelNoteComment.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanelNoteComment.Name = "FlowLayoutPanelNoteComment";
            this.FlowLayoutPanelNoteComment.Size = new System.Drawing.Size(1150, 488);
            this.FlowLayoutPanelNoteComment.TabIndex = 1;
            // 
            // PanelComment
            // 
            this.PanelComment.Controls.Add(this.TextComment);
            this.PanelComment.Controls.Add(this.ButtonReport);
            this.PanelComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelComment.Location = new System.Drawing.Point(0, 688);
            this.PanelComment.Name = "PanelComment";
            this.PanelComment.Size = new System.Drawing.Size(1150, 52);
            this.PanelComment.TabIndex = 2;
            // 
            // TextComment
            // 
            this.TextComment.BackColor = System.Drawing.SystemColors.Window;
            this.TextComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextComment.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment.Location = new System.Drawing.Point(0, 0);
            this.TextComment.Multiline = true;
            this.TextComment.Name = "TextComment";
            this.TextComment.Size = new System.Drawing.Size(1017, 52);
            this.TextComment.TabIndex = 0;
            // 
            // ButtonReport
            // 
            this.ButtonReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonReport.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReport.Location = new System.Drawing.Point(1017, 0);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(133, 52);
            this.ButtonReport.TabIndex = 1;
            this.ButtonReport.Text = "发表评论";
            this.ButtonReport.UseVisualStyleBackColor = true;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // PictureBoxRefresh
            // 
            this.PictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxRefresh.Image = global::Shared_Novel_Reader.Properties.Resources.refresh;
            this.PictureBoxRefresh.Location = new System.Drawing.Point(860, 34);
            this.PictureBoxRefresh.Name = "PictureBoxRefresh";
            this.PictureBoxRefresh.Size = new System.Drawing.Size(18, 18);
            this.PictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxRefresh.TabIndex = 8;
            this.PictureBoxRefresh.TabStop = false;
            this.PictureBoxRefresh.Click += new System.EventHandler(this.PictureBoxRefresh_Click);
            // 
            // PictureBoxReturn
            // 
            this.PictureBoxReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxReturn.Image = global::Shared_Novel_Reader.Properties.Resources.arrow_left_circle;
            this.PictureBoxReturn.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxReturn.Name = "PictureBoxReturn";
            this.PictureBoxReturn.Size = new System.Drawing.Size(44, 40);
            this.PictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxReturn.TabIndex = 7;
            this.PictureBoxReturn.TabStop = false;
            this.PictureBoxReturn.Click += new System.EventHandler(this.PictureBoxReturn_Click);
            // 
            // FormNoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.FlowLayoutPanelNoteComment);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.PanelComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNoteDetail";
            this.Text = "FormNoteDetail";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.PanelComment.ResumeLayout(false);
            this.PanelComment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelNoteComment;
        private System.Windows.Forms.Label labelViewBook;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label LabelJoin;
        private System.Windows.Forms.PictureBox PictureBoxReturn;
        private System.Windows.Forms.Panel PanelComment;
        private System.Windows.Forms.Button ButtonReport;
        private System.Windows.Forms.TextBox TextComment;
        private System.Windows.Forms.PictureBox PictureBoxRefresh;
    }
}