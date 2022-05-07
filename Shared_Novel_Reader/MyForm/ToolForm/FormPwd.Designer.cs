namespace Shared_Novel_Reader.MyForm.ToolForm
{
    partial class FormPwd
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
            this.label = new System.Windows.Forms.Label();
            this.TextPwd = new System.Windows.Forms.TextBox();
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.LabelPasswordExplain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(156, 45);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(188, 32);
            this.label.TabIndex = 0;
            this.label.Text = "请输入新密码";
            // 
            // TextPwd
            // 
            this.TextPwd.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.TextPwd.Location = new System.Drawing.Point(100, 122);
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.PasswordChar = '*';
            this.TextPwd.Size = new System.Drawing.Size(300, 40);
            this.TextPwd.TabIndex = 1;
            this.TextPwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPwd_KeyPress);
            // 
            // BtnYes
            // 
            this.BtnYes.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnYes.Location = new System.Drawing.Point(100, 208);
            this.BtnYes.Margin = new System.Windows.Forms.Padding(0);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(100, 44);
            this.BtnYes.TabIndex = 2;
            this.BtnYes.Text = "确认";
            this.BtnYes.UseVisualStyleBackColor = true;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.Location = new System.Drawing.Point(300, 208);
            this.BtnNo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(100, 44);
            this.BtnNo.TabIndex = 3;
            this.BtnNo.Text = "取消";
            this.BtnNo.UseVisualStyleBackColor = true;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // LabelPasswordExplain
            // 
            this.LabelPasswordExplain.AutoSize = true;
            this.LabelPasswordExplain.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswordExplain.Location = new System.Drawing.Point(97, 165);
            this.LabelPasswordExplain.Name = "LabelPasswordExplain";
            this.LabelPasswordExplain.Size = new System.Drawing.Size(152, 18);
            this.LabelPasswordExplain.TabIndex = 25;
            this.LabelPasswordExplain.Text = "请输入数字或字母";
            this.LabelPasswordExplain.Visible = false;
            // 
            // FormPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.LabelPasswordExplain);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.TextPwd);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Label LabelPasswordExplain;
        public System.Windows.Forms.TextBox TextPwd;
    }
}