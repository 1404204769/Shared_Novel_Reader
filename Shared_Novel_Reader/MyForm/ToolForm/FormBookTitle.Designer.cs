namespace Shared_Novel_Reader.MyForm.ToolForm
{
    partial class FormBookTitle
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
            this.LabelBookName = new System.Windows.Forms.Label();
            this.LabelBookAuthor = new System.Windows.Forms.Label();
            this.LabelBookPublisher = new System.Windows.Forms.Label();
            this.LabelBookSynopsis = new System.Windows.Forms.Label();
            this.TextBookNameValue = new System.Windows.Forms.TextBox();
            this.LabelEdit = new System.Windows.Forms.Label();
            this.TextBookAuthorValue = new System.Windows.Forms.TextBox();
            this.TextBookSynopsisValue = new System.Windows.Forms.TextBox();
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.ComboBoxBookPublisherValue = new System.Windows.Forms.ComboBox();
            this.TextBookPublisherValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelBookName
            // 
            this.LabelBookName.AutoSize = true;
            this.LabelBookName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookName.Location = new System.Drawing.Point(100, 50);
            this.LabelBookName.Name = "LabelBookName";
            this.LabelBookName.Size = new System.Drawing.Size(120, 28);
            this.LabelBookName.TabIndex = 0;
            this.LabelBookName.Text = "图书名称:";
            // 
            // LabelBookAuthor
            // 
            this.LabelBookAuthor.AutoSize = true;
            this.LabelBookAuthor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookAuthor.Location = new System.Drawing.Point(100, 125);
            this.LabelBookAuthor.Name = "LabelBookAuthor";
            this.LabelBookAuthor.Size = new System.Drawing.Size(120, 28);
            this.LabelBookAuthor.TabIndex = 1;
            this.LabelBookAuthor.Text = "图书作者:";
            // 
            // LabelBookPublisher
            // 
            this.LabelBookPublisher.AutoSize = true;
            this.LabelBookPublisher.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookPublisher.Location = new System.Drawing.Point(100, 200);
            this.LabelBookPublisher.Name = "LabelBookPublisher";
            this.LabelBookPublisher.Size = new System.Drawing.Size(145, 28);
            this.LabelBookPublisher.TabIndex = 2;
            this.LabelBookPublisher.Text = "图书出版商:";
            // 
            // LabelBookSynopsis
            // 
            this.LabelBookSynopsis.AutoSize = true;
            this.LabelBookSynopsis.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBookSynopsis.Location = new System.Drawing.Point(100, 275);
            this.LabelBookSynopsis.Name = "LabelBookSynopsis";
            this.LabelBookSynopsis.Size = new System.Drawing.Size(120, 28);
            this.LabelBookSynopsis.TabIndex = 3;
            this.LabelBookSynopsis.Text = "图书简介:";
            // 
            // TextBookNameValue
            // 
            this.TextBookNameValue.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBookNameValue.Location = new System.Drawing.Point(300, 50);
            this.TextBookNameValue.Name = "TextBookNameValue";
            this.TextBookNameValue.ReadOnly = true;
            this.TextBookNameValue.Size = new System.Drawing.Size(336, 36);
            this.TextBookNameValue.TabIndex = 4;
            this.TextBookNameValue.TextChanged += new System.EventHandler(this.TextBookNameValue_TextChanged);
            // 
            // LabelEdit
            // 
            this.LabelEdit.AutoSize = true;
            this.LabelEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelEdit.Location = new System.Drawing.Point(661, 23);
            this.LabelEdit.Name = "LabelEdit";
            this.LabelEdit.Size = new System.Drawing.Size(44, 18);
            this.LabelEdit.TabIndex = 5;
            this.LabelEdit.Text = "编辑";
            this.LabelEdit.Click += new System.EventHandler(this.LabelEdit_Click);
            // 
            // TextBookAuthorValue
            // 
            this.TextBookAuthorValue.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBookAuthorValue.Location = new System.Drawing.Point(300, 125);
            this.TextBookAuthorValue.Name = "TextBookAuthorValue";
            this.TextBookAuthorValue.ReadOnly = true;
            this.TextBookAuthorValue.Size = new System.Drawing.Size(336, 36);
            this.TextBookAuthorValue.TabIndex = 6;
            this.TextBookAuthorValue.TextChanged += new System.EventHandler(this.TextBookAuthorValue_TextChanged);
            // 
            // TextBookSynopsisValue
            // 
            this.TextBookSynopsisValue.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBookSynopsisValue.Location = new System.Drawing.Point(300, 275);
            this.TextBookSynopsisValue.Multiline = true;
            this.TextBookSynopsisValue.Name = "TextBookSynopsisValue";
            this.TextBookSynopsisValue.ReadOnly = true;
            this.TextBookSynopsisValue.Size = new System.Drawing.Size(336, 94);
            this.TextBookSynopsisValue.TabIndex = 8;
            this.TextBookSynopsisValue.TextChanged += new System.EventHandler(this.TextBookSynopsisValue_TextChanged);
            // 
            // BtnYes
            // 
            this.BtnYes.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYes.Location = new System.Drawing.Point(150, 375);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(100, 50);
            this.BtnYes.TabIndex = 9;
            this.BtnYes.Text = "确认";
            this.BtnYes.UseVisualStyleBackColor = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.Location = new System.Drawing.Point(500, 375);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(100, 50);
            this.BtnNo.TabIndex = 10;
            this.BtnNo.Text = "取消";
            this.BtnNo.UseVisualStyleBackColor = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // ComboBoxBookPublisherValue
            // 
            this.ComboBoxBookPublisherValue.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxBookPublisherValue.FormattingEnabled = true;
            this.ComboBoxBookPublisherValue.Items.AddRange(new object[] {
            "未知",
            "起点中文网",
            "创世中文网",
            "纵横中文网",
            "云起书院",
            "潇湘书院",
            "晋江文学城",
            "17K小说网",
            "小说阅读网",
            "红袖添香",
            "刺猬猫"});
            this.ComboBoxBookPublisherValue.Location = new System.Drawing.Point(300, 200);
            this.ComboBoxBookPublisherValue.Name = "ComboBoxBookPublisherValue";
            this.ComboBoxBookPublisherValue.Size = new System.Drawing.Size(336, 36);
            this.ComboBoxBookPublisherValue.TabIndex = 11;
            this.ComboBoxBookPublisherValue.Visible = false;
            this.ComboBoxBookPublisherValue.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBookPublisherValue_SelectedIndexChanged);
            // 
            // TextBookPublisherValue
            // 
            this.TextBookPublisherValue.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBookPublisherValue.Location = new System.Drawing.Point(300, 200);
            this.TextBookPublisherValue.Name = "TextBookPublisherValue";
            this.TextBookPublisherValue.ReadOnly = true;
            this.TextBookPublisherValue.Size = new System.Drawing.Size(336, 36);
            this.TextBookPublisherValue.TabIndex = 12;
            this.TextBookPublisherValue.TextChanged += new System.EventHandler(this.TextBookPublisherValue_TextChanged);
            // 
            // FormBookTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.TextBookPublisherValue);
            this.Controls.Add(this.ComboBoxBookPublisherValue);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.TextBookSynopsisValue);
            this.Controls.Add(this.TextBookAuthorValue);
            this.Controls.Add(this.LabelEdit);
            this.Controls.Add(this.TextBookNameValue);
            this.Controls.Add(this.LabelBookSynopsis);
            this.Controls.Add(this.LabelBookPublisher);
            this.Controls.Add(this.LabelBookAuthor);
            this.Controls.Add(this.LabelBookName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBookTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBookTitle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBookName;
        private System.Windows.Forms.Label LabelBookAuthor;
        private System.Windows.Forms.Label LabelBookPublisher;
        private System.Windows.Forms.Label LabelBookSynopsis;
        private System.Windows.Forms.TextBox TextBookNameValue;
        private System.Windows.Forms.Label LabelEdit;
        private System.Windows.Forms.TextBox TextBookAuthorValue;
        private System.Windows.Forms.TextBox TextBookSynopsisValue;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.ComboBox ComboBoxBookPublisherValue;
        private System.Windows.Forms.TextBox TextBookPublisherValue;
    }
}