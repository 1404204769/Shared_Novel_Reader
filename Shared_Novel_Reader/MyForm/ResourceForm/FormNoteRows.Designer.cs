namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    partial class FormNoteRows
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.White;
            this.labelTitle.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(451, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "帖子标题";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelContent
            // 
            this.labelContent.BackColor = System.Drawing.Color.Gainsboro;
            this.labelContent.ForeColor = System.Drawing.Color.Black;
            this.labelContent.Location = new System.Drawing.Point(110, 62);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(1004, 79);
            this.labelContent.TabIndex = 1;
            this.labelContent.Text = "帖子内容";
            // 
            // labelLink
            // 
            this.labelLink.BackColor = System.Drawing.Color.Chocolate;
            this.labelLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLink.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLink.ForeColor = System.Drawing.Color.Transparent;
            this.labelLink.Location = new System.Drawing.Point(1014, 9);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(100, 30);
            this.labelLink.TabIndex = 2;
            this.labelLink.Text = "查看详情";
            this.labelLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLink.Click += new System.EventHandler(this.labelLink_Click);
            // 
            // FormNoteRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1140, 150);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNoteRows";
            this.Text = "FormNoteRows";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelLink;
    }
}