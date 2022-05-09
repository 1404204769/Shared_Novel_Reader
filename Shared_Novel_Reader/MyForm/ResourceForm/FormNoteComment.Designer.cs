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
            this.LabelAgree.BackColor = System.Drawing.Color.SeaGreen;
            this.LabelAgree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAgree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelAgree.ForeColor = System.Drawing.Color.LightYellow;
            this.LabelAgree.Location = new System.Drawing.Point(909, 67);
            this.LabelAgree.Name = "LabelAgree";
            this.LabelAgree.Size = new System.Drawing.Size(55, 30);
            this.LabelAgree.TabIndex = 4;
            this.LabelAgree.Text = "点赞";
            this.LabelAgree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelAgree.Click += new System.EventHandler(this.labelAgree_Click);
            // 
            // LabelReply
            // 
            this.LabelReply.BackColor = System.Drawing.Color.Olive;
            this.LabelReply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelReply.ForeColor = System.Drawing.Color.White;
            this.LabelReply.Location = new System.Drawing.Point(980, 67);
            this.LabelReply.Name = "LabelReply";
            this.LabelReply.Size = new System.Drawing.Size(55, 30);
            this.LabelReply.TabIndex = 5;
            this.LabelReply.Text = "回复";
            this.LabelReply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelReply.Click += new System.EventHandler(this.LabelReply_Click);
            // 
            // LabelReport
            // 
            this.LabelReport.BackColor = System.Drawing.Color.Firebrick;
            this.LabelReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelReport.ForeColor = System.Drawing.Color.White;
            this.LabelReport.Location = new System.Drawing.Point(1050, 67);
            this.LabelReport.Name = "LabelReport";
            this.LabelReport.Size = new System.Drawing.Size(55, 30);
            this.LabelReport.TabIndex = 6;
            this.LabelReport.Text = "举报";
            this.LabelReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelReport.Click += new System.EventHandler(this.LabelReport_Click);
            // 
            // FormNoteComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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