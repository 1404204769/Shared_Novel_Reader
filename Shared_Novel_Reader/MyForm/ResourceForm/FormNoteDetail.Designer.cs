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
            this.labelViewBook = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.FlowLayoutPanelNoteComment = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelJoin = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
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
            // labelViewBook
            // 
            this.labelViewBook.AutoSize = true;
            this.labelViewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelViewBook.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelViewBook.Location = new System.Drawing.Point(912, 48);
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
            this.labelContent.ForeColor = System.Drawing.Color.Black;
            this.labelContent.Location = new System.Drawing.Point(122, 87);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(1004, 79);
            this.labelContent.TabIndex = 4;
            this.labelContent.Text = "帖子内容";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(24, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(451, 32);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "帖子标题";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FlowLayoutPanelNoteComment
            // 
            this.FlowLayoutPanelNoteComment.BackColor = System.Drawing.Color.White;
            this.FlowLayoutPanelNoteComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanelNoteComment.Location = new System.Drawing.Point(0, 200);
            this.FlowLayoutPanelNoteComment.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanelNoteComment.Name = "FlowLayoutPanelNoteComment";
            this.FlowLayoutPanelNoteComment.Size = new System.Drawing.Size(1150, 540);
            this.FlowLayoutPanelNoteComment.TabIndex = 1;
            // 
            // LabelJoin
            // 
            this.LabelJoin.AutoSize = true;
            this.LabelJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelJoin.ForeColor = System.Drawing.Color.DarkCyan;
            this.LabelJoin.Location = new System.Drawing.Point(1033, 48);
            this.LabelJoin.Name = "LabelJoin";
            this.LabelJoin.Size = new System.Drawing.Size(80, 18);
            this.LabelJoin.TabIndex = 6;
            this.LabelJoin.Text = "加入书架";
            this.LabelJoin.Click += new System.EventHandler(this.LabelJoin_Click);
            // 
            // FormNoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.FlowLayoutPanelNoteComment);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNoteDetail";
            this.Text = "FormNoteDetail";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelNoteComment;
        private System.Windows.Forms.Label labelViewBook;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label LabelJoin;
    }
}