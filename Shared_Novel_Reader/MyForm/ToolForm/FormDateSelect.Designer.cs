namespace Shared_Novel_Reader.MyForm.ToolForm
{
    partial class FormDateSelect
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
            this.DateBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOver = new System.Windows.Forms.DateTimePicker();
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateBegin
            // 
            this.DateBegin.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateBegin.Location = new System.Drawing.Point(185, 67);
            this.DateBegin.Name = "DateBegin";
            this.DateBegin.Size = new System.Drawing.Size(275, 36);
            this.DateBegin.TabIndex = 2;
            this.DateBegin.ValueChanged += new System.EventHandler(this.DateBegin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "起始日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "截止日期";
            // 
            // DateOver
            // 
            this.DateOver.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOver.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOver.Location = new System.Drawing.Point(185, 142);
            this.DateOver.Name = "DateOver";
            this.DateOver.Size = new System.Drawing.Size(275, 36);
            this.DateOver.TabIndex = 4;
            this.DateOver.ValueChanged += new System.EventHandler(this.DateOver_ValueChanged);
            // 
            // BtnYes
            // 
            this.BtnYes.AutoSize = true;
            this.BtnYes.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnYes.Location = new System.Drawing.Point(100, 220);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(100, 40);
            this.BtnYes.TabIndex = 6;
            this.BtnYes.Text = "确认";
            this.BtnYes.UseVisualStyleBackColor = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.AutoSize = true;
            this.BtnNo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnNo.Location = new System.Drawing.Point(300, 220);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(100, 40);
            this.BtnNo.TabIndex = 7;
            this.BtnNo.Text = "取消";
            this.BtnNo.UseVisualStyleBackColor = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // FormDateSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateOver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDateSelect";
            this.Text = "FormDateSelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.DateTimePicker DateBegin;
        private System.Windows.Forms.DateTimePicker DateOver;
    }
}