namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    partial class FormNoteComment
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
            this.LabelUserID = new System.Windows.Forms.Label();
            this.LabelContent = new System.Windows.Forms.Label();
            this.LabelAgreeNum = new System.Windows.Forms.Label();
            this.LabelCommentTime = new System.Windows.Forms.Label();
            this.LabelAgree = new System.Windows.Forms.Label();
            this.LabelReply = new System.Windows.Forms.Label();
            this.LabelReport = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelUserID
            // 
            this.LabelUserID.Location = new System.Drawing.Point(12, 9);
            this.LabelUserID.Name = "LabelUserID";
            this.LabelUserID.Size = new System.Drawing.Size(141, 24);
            this.LabelUserID.TabIndex = 0;
            this.LabelUserID.Text = "用户ID";
            // 
            // LabelContent
            // 
            this.LabelContent.Location = new System.Drawing.Point(44, 33);
            this.LabelContent.Name = "LabelContent";
            this.LabelContent.Size = new System.Drawing.Size(1000, 34);
            this.LabelContent.TabIndex = 1;
            this.LabelContent.Text = "评论内容";
            // 
            // LabelAgreeNum
            // 
            this.LabelAgreeNum.Location = new System.Drawing.Point(616, 67);
            this.LabelAgreeNum.Name = "LabelAgreeNum";
            this.LabelAgreeNum.Size = new System.Drawing.Size(100, 23);
            this.LabelAgreeNum.TabIndex = 2;
            this.LabelAgreeNum.Text = "点赞数";
            // 
            // LabelCommentTime
            // 
            this.LabelCommentTime.Location = new System.Drawing.Point(736, 67);
            this.LabelCommentTime.Name = "LabelCommentTime";
            this.LabelCommentTime.Size = new System.Drawing.Size(167, 23);
            this.LabelCommentTime.TabIndex = 3;
            this.LabelCommentTime.Text = "评论时间";
            // 
            // LabelAgree
            // 
            this.LabelAgree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAgree.ForeColor = System.Drawing.Color.Green;
            this.LabelAgree.Location = new System.Drawing.Point(909, 67);
            this.LabelAgree.Name = "LabelAgree";
            this.LabelAgree.Size = new System.Drawing.Size(97, 18);
            this.LabelAgree.TabIndex = 4;
            this.LabelAgree.Text = "点赞";
            this.LabelAgree.Click += new System.EventHandler(this.labelAgree_Click);
            // 
            // LabelReply
            // 
            this.LabelReply.AutoSize = true;
            this.LabelReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelReply.ForeColor = System.Drawing.Color.Green;
            this.LabelReply.Location = new System.Drawing.Point(1012, 67);
            this.LabelReply.Name = "LabelReply";
            this.LabelReply.Size = new System.Drawing.Size(44, 18);
            this.LabelReply.TabIndex = 5;
            this.LabelReply.Text = "回复";
            this.LabelReply.Click += new System.EventHandler(this.LabelReply_Click);
            // 
            // LabelReport
            // 
            this.LabelReport.AutoSize = true;
            this.LabelReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelReport.ForeColor = System.Drawing.Color.Green;
            this.LabelReport.Location = new System.Drawing.Point(1062, 67);
            this.LabelReport.Name = "LabelReport";
            this.LabelReport.Size = new System.Drawing.Size(44, 18);
            this.LabelReport.TabIndex = 6;
            this.LabelReport.Text = "举报";
            this.LabelReport.Click += new System.EventHandler(this.LabelReport_Click);
            // 
            // FormNoteComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1115, 100);
            this.Controls.Add(this.LabelReport);
            this.Controls.Add(this.LabelReply);
            this.Controls.Add(this.LabelAgree);
            this.Controls.Add(this.LabelCommentTime);
            this.Controls.Add(this.LabelAgreeNum);
            this.Controls.Add(this.LabelContent);
            this.Controls.Add(this.LabelUserID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNoteComment";
            this.Text = "FormNoteComment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUserID;
        private System.Windows.Forms.Label LabelContent;
        private System.Windows.Forms.Label LabelAgreeNum;
        private System.Windows.Forms.Label LabelCommentTime;
        private System.Windows.Forms.Label LabelReply;
        public System.Windows.Forms.Label LabelAgree;
        private System.Windows.Forms.Label LabelReport;
    }
}