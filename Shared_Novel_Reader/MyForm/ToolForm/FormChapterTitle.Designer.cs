namespace Shared_Novel_Reader.MyForm.ToolForm
{
    partial class FormChapterTitle
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
            this.LabelVolNum = new System.Windows.Forms.Label();
            this.TextVolNumValue = new System.Windows.Forms.TextBox();
            this.BtnYes = new System.Windows.Forms.Button();
            this.LabelChapterNum = new System.Windows.Forms.Label();
            this.TextChapterNumValue = new System.Windows.Forms.TextBox();
            this.BtnNo = new System.Windows.Forms.Button();
            this.LabelChapterTitle = new System.Windows.Forms.Label();
            this.TextChapterTitleValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelVolNum
            // 
            this.LabelVolNum.AutoSize = true;
            this.LabelVolNum.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVolNum.Location = new System.Drawing.Point(35, 32);
            this.LabelVolNum.Margin = new System.Windows.Forms.Padding(0);
            this.LabelVolNum.Name = "LabelVolNum";
            this.LabelVolNum.Size = new System.Drawing.Size(111, 32);
            this.LabelVolNum.TabIndex = 9;
            this.LabelVolNum.Text = "分卷数:";
            // 
            // TextVolNumValue
            // 
            this.TextVolNumValue.Location = new System.Drawing.Point(158, 32);
            this.TextVolNumValue.Margin = new System.Windows.Forms.Padding(0);
            this.TextVolNumValue.MaxLength = 2;
            this.TextVolNumValue.Name = "TextVolNumValue";
            this.TextVolNumValue.Size = new System.Drawing.Size(50, 28);
            this.TextVolNumValue.TabIndex = 0;
            this.TextVolNumValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextVolNumValue_KeyPress);
            // 
            // BtnYes
            // 
            this.BtnYes.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYes.Location = new System.Drawing.Point(74, 168);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(100, 50);
            this.BtnYes.TabIndex = 3;
            this.BtnYes.Text = "确定";
            this.BtnYes.UseVisualStyleBackColor = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // LabelChapterNum
            // 
            this.LabelChapterNum.AutoSize = true;
            this.LabelChapterNum.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChapterNum.Location = new System.Drawing.Point(235, 32);
            this.LabelChapterNum.Margin = new System.Windows.Forms.Padding(0);
            this.LabelChapterNum.Name = "LabelChapterNum";
            this.LabelChapterNum.Size = new System.Drawing.Size(111, 32);
            this.LabelChapterNum.TabIndex = 10;
            this.LabelChapterNum.Text = "章节数:";
            // 
            // TextChapterNumValue
            // 
            this.TextChapterNumValue.Location = new System.Drawing.Point(355, 32);
            this.TextChapterNumValue.Margin = new System.Windows.Forms.Padding(0);
            this.TextChapterNumValue.Name = "TextChapterNumValue";
            this.TextChapterNumValue.Size = new System.Drawing.Size(50, 28);
            this.TextChapterNumValue.TabIndex = 1;
            this.TextChapterNumValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextChapterNumValue_KeyPress);
            // 
            // BtnNo
            // 
            this.BtnNo.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.Location = new System.Drawing.Point(295, 168);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(100, 50);
            this.BtnNo.TabIndex = 4;
            this.BtnNo.Text = "取消";
            this.BtnNo.UseVisualStyleBackColor = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // LabelChapterTitle
            // 
            this.LabelChapterTitle.AutoSize = true;
            this.LabelChapterTitle.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChapterTitle.Location = new System.Drawing.Point(35, 97);
            this.LabelChapterTitle.Margin = new System.Windows.Forms.Padding(0);
            this.LabelChapterTitle.Name = "LabelChapterTitle";
            this.LabelChapterTitle.Size = new System.Drawing.Size(111, 32);
            this.LabelChapterTitle.TabIndex = 11;
            this.LabelChapterTitle.Text = "章节名:";
            // 
            // TextChapterTitleValue
            // 
            this.TextChapterTitleValue.Location = new System.Drawing.Point(158, 97);
            this.TextChapterTitleValue.Name = "TextChapterTitleValue";
            this.TextChapterTitleValue.Size = new System.Drawing.Size(247, 28);
            this.TextChapterTitleValue.TabIndex = 2;
            // 
            // FormChapterTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.TextChapterTitleValue);
            this.Controls.Add(this.LabelChapterTitle);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.TextChapterNumValue);
            this.Controls.Add(this.LabelChapterNum);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.TextVolNumValue);
            this.Controls.Add(this.LabelVolNum);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChapterTitle";
            this.Text = "FormChapterTitle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelVolNum;
        private System.Windows.Forms.TextBox TextVolNumValue;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Label LabelChapterNum;
        private System.Windows.Forms.TextBox TextChapterNumValue;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Label LabelChapterTitle;
        private System.Windows.Forms.TextBox TextChapterTitleValue;
    }
}