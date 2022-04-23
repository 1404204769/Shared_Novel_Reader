namespace Shared_Novel_Reader.MyForm.AdminForm
{
    partial class FormFilterResourceManagement
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
            this.TextAuthor = new System.Windows.Forms.TextBox();
            this.TextBookName = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnFindSome = new System.Windows.Forms.Button();
            this.BtnFindAll = new System.Windows.Forms.Button();
            this.LabelPublisher = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelBookName = new System.Windows.Forms.Label();
            this.TextPublisher = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextAuthor
            // 
            this.TextAuthor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAuthor.Location = new System.Drawing.Point(231, 206);
            this.TextAuthor.Name = "TextAuthor";
            this.TextAuthor.Size = new System.Drawing.Size(290, 36);
            this.TextAuthor.TabIndex = 52;
            // 
            // TextBookName
            // 
            this.TextBookName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBookName.Location = new System.Drawing.Point(231, 73);
            this.TextBookName.Name = "TextBookName";
            this.TextBookName.Size = new System.Drawing.Size(290, 36);
            this.TextBookName.TabIndex = 51;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(600, 331);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 40);
            this.BtnCancel.TabIndex = 50;
            this.BtnCancel.Text = "取消查询";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnFindSome
            // 
            this.BtnFindSome.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindSome.Location = new System.Drawing.Point(600, 202);
            this.BtnFindSome.Name = "BtnFindSome";
            this.BtnFindSome.Size = new System.Drawing.Size(150, 40);
            this.BtnFindSome.TabIndex = 49;
            this.BtnFindSome.Text = "查询部分";
            this.BtnFindSome.UseVisualStyleBackColor = true;
            this.BtnFindSome.Click += new System.EventHandler(this.BtnFindSome_Click);
            // 
            // BtnFindAll
            // 
            this.BtnFindAll.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindAll.Location = new System.Drawing.Point(600, 69);
            this.BtnFindAll.Name = "BtnFindAll";
            this.BtnFindAll.Size = new System.Drawing.Size(150, 40);
            this.BtnFindAll.TabIndex = 48;
            this.BtnFindAll.Text = "查询所有";
            this.BtnFindAll.UseVisualStyleBackColor = true;
            this.BtnFindAll.Click += new System.EventHandler(this.BtnFindAll_Click);
            // 
            // LabelPublisher
            // 
            this.LabelPublisher.AutoSize = true;
            this.LabelPublisher.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPublisher.ForeColor = System.Drawing.Color.Black;
            this.LabelPublisher.Location = new System.Drawing.Point(82, 343);
            this.LabelPublisher.Name = "LabelPublisher";
            this.LabelPublisher.Size = new System.Drawing.Size(112, 28);
            this.LabelPublisher.TabIndex = 47;
            this.LabelPublisher.Text = "出版社：";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAuthor.ForeColor = System.Drawing.Color.Black;
            this.LabelAuthor.Location = new System.Drawing.Point(57, 214);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(137, 28);
            this.LabelAuthor.TabIndex = 46;
            this.LabelAuthor.Text = "作者名称：";
            // 
            // LabelBookName
            // 
            this.LabelBookName.AutoSize = true;
            this.LabelBookName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookName.ForeColor = System.Drawing.Color.Black;
            this.LabelBookName.Location = new System.Drawing.Point(57, 81);
            this.LabelBookName.Name = "LabelBookName";
            this.LabelBookName.Size = new System.Drawing.Size(137, 28);
            this.LabelBookName.TabIndex = 45;
            this.LabelBookName.Text = "图书名称：";
            // 
            // TextPublisher
            // 
            this.TextPublisher.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPublisher.Location = new System.Drawing.Point(231, 335);
            this.TextPublisher.Name = "TextPublisher";
            this.TextPublisher.Size = new System.Drawing.Size(290, 36);
            this.TextPublisher.TabIndex = 53;
            // 
            // FormFilterResourceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextPublisher);
            this.Controls.Add(this.TextAuthor);
            this.Controls.Add(this.TextBookName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnFindSome);
            this.Controls.Add(this.BtnFindAll);
            this.Controls.Add(this.LabelPublisher);
            this.Controls.Add(this.LabelAuthor);
            this.Controls.Add(this.LabelBookName);
            this.Name = "FormFilterResourceManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "图书资源查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox TextAuthor;
        public System.Windows.Forms.TextBox TextBookName;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnFindSome;
        private System.Windows.Forms.Button BtnFindAll;
        private System.Windows.Forms.Label LabelPublisher;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelBookName;
        public System.Windows.Forms.TextBox TextPublisher;
    }
}