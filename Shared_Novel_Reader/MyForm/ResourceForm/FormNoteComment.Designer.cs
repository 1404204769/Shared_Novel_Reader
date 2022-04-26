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
            this.labelAgree = new System.Windows.Forms.Label();
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
            this.LabelContent.Size = new System.Drawing.Size(1085, 34);
            this.LabelContent.TabIndex = 1;
            this.LabelContent.Text = "评论内容";
            // 
            // LabelAgreeNum
            // 
            this.LabelAgreeNum.Location = new System.Drawing.Point(666, 67);
            this.LabelAgreeNum.Name = "LabelAgreeNum";
            this.LabelAgreeNum.Size = new System.Drawing.Size(100, 23);
            this.LabelAgreeNum.TabIndex = 2;
            this.LabelAgreeNum.Text = "点赞数";
            // 
            // LabelCommentTime
            // 
            this.LabelCommentTime.Location = new System.Drawing.Point(825, 67);
            this.LabelCommentTime.Name = "LabelCommentTime";
            this.LabelCommentTime.Size = new System.Drawing.Size(167, 23);
            this.LabelCommentTime.TabIndex = 3;
            this.LabelCommentTime.Text = "评论时间";
            // 
            // labelAgree
            // 
            this.labelAgree.AutoSize = true;
            this.labelAgree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAgree.ForeColor = System.Drawing.Color.Green;
            this.labelAgree.Location = new System.Drawing.Point(1018, 67);
            this.labelAgree.Name = "labelAgree";
            this.labelAgree.Size = new System.Drawing.Size(44, 18);
            this.labelAgree.TabIndex = 4;
            this.labelAgree.Text = "点赞";
            // 
            // FormNoteComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 100);
            this.Controls.Add(this.labelAgree);
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
        private System.Windows.Forms.Label labelAgree;
    }
}