namespace Shared_Novel_Reader.MyForm
{
    partial class FormRegister
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
            this.LabelAccount = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSex = new System.Windows.Forms.Label();
            this.ComboBoxSex = new System.Windows.Forms.ComboBox();
            this.TextAccount = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextPasswordAgain = new System.Windows.Forms.TextBox();
            this.LabelPasswordAgain = new System.Windows.Forms.Label();
            this.LabelAccountExplain = new System.Windows.Forms.Label();
            this.LabelPasswordExplain = new System.Windows.Forms.Label();
            this.LabelPasswordAgainExplain = new System.Windows.Forms.Label();
            this.LabelErrorExpain = new System.Windows.Forms.Label();
            this.labelNameExplain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelAccount
            // 
            this.LabelAccount.AutoSize = true;
            this.LabelAccount.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccount.ForeColor = System.Drawing.Color.Black;
            this.LabelAccount.Location = new System.Drawing.Point(50, 60);
            this.LabelAccount.Name = "LabelAccount";
            this.LabelAccount.Size = new System.Drawing.Size(87, 28);
            this.LabelAccount.TabIndex = 4;
            this.LabelAccount.Text = "账号：";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.Black;
            this.LabelName.Location = new System.Drawing.Point(50, 110);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(87, 28);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "昵称：";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSex.ForeColor = System.Drawing.Color.Black;
            this.LabelSex.Location = new System.Drawing.Point(50, 160);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(87, 28);
            this.LabelSex.TabIndex = 7;
            this.LabelSex.Text = "性别：";
            // 
            // ComboBoxSex
            // 
            this.ComboBoxSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxSex.AutoCompleteCustomSource.AddRange(new string[] {
            "男",
            "女"});
            this.ComboBoxSex.DropDownHeight = 50;
            this.ComboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSex.DropDownWidth = 50;
            this.ComboBoxSex.FormattingEnabled = true;
            this.ComboBoxSex.IntegralHeight = false;
            this.ComboBoxSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.ComboBoxSex.Location = new System.Drawing.Point(175, 160);
            this.ComboBoxSex.Name = "ComboBoxSex";
            this.ComboBoxSex.Size = new System.Drawing.Size(70, 26);
            this.ComboBoxSex.TabIndex = 14;
            this.ComboBoxSex.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TextAccount
            // 
            this.TextAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextAccount.Location = new System.Drawing.Point(175, 60);
            this.TextAccount.MaxLength = 11;
            this.TextAccount.Name = "TextAccount";
            this.TextAccount.Size = new System.Drawing.Size(293, 28);
            this.TextAccount.TabIndex = 15;
            this.TextAccount.TextChanged += new System.EventHandler(this.TextAccount_TextChanged);
            this.TextAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextAccount_KeyPress);
            // 
            // TextName
            // 
            this.TextName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextName.Location = new System.Drawing.Point(175, 110);
            this.TextName.MaxLength = 11;
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(293, 28);
            this.TextName.TabIndex = 16;
            this.TextName.TextChanged += new System.EventHandler(this.TextName_TextChanged);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.Location = new System.Drawing.Point(100, 400);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(100, 50);
            this.BtnRegister.TabIndex = 17;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(300, 400);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 50);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.Black;
            this.LabelPassword.Location = new System.Drawing.Point(50, 210);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(87, 28);
            this.LabelPassword.TabIndex = 19;
            this.LabelPassword.Text = "密码：";
            // 
            // TextPassword
            // 
            this.TextPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextPassword.Location = new System.Drawing.Point(175, 210);
            this.TextPassword.MaxLength = 11;
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(293, 28);
            this.TextPassword.TabIndex = 20;
            this.TextPassword.TextChanged += new System.EventHandler(this.TextPassword_TextChanged);
            this.TextPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // TextPasswordAgain
            // 
            this.TextPasswordAgain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextPasswordAgain.Location = new System.Drawing.Point(175, 260);
            this.TextPasswordAgain.MaxLength = 11;
            this.TextPasswordAgain.Name = "TextPasswordAgain";
            this.TextPasswordAgain.PasswordChar = '*';
            this.TextPasswordAgain.Size = new System.Drawing.Size(293, 28);
            this.TextPasswordAgain.TabIndex = 22;
            this.TextPasswordAgain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPasswordAgain_KeyPress);
            // 
            // LabelPasswordAgain
            // 
            this.LabelPasswordAgain.AutoSize = true;
            this.LabelPasswordAgain.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPasswordAgain.ForeColor = System.Drawing.Color.Black;
            this.LabelPasswordAgain.Location = new System.Drawing.Point(0, 259);
            this.LabelPasswordAgain.Name = "LabelPasswordAgain";
            this.LabelPasswordAgain.Size = new System.Drawing.Size(137, 28);
            this.LabelPasswordAgain.TabIndex = 21;
            this.LabelPasswordAgain.Text = "确认密码：";
            // 
            // LabelAccountExplain
            // 
            this.LabelAccountExplain.AutoSize = true;
            this.LabelAccountExplain.ForeColor = System.Drawing.Color.Red;
            this.LabelAccountExplain.Location = new System.Drawing.Point(172, 91);
            this.LabelAccountExplain.Name = "LabelAccountExplain";
            this.LabelAccountExplain.Size = new System.Drawing.Size(179, 18);
            this.LabelAccountExplain.TabIndex = 23;
            this.LabelAccountExplain.Text = "请输入数字,最多十位";
            this.LabelAccountExplain.Visible = false;
            // 
            // LabelPasswordExplain
            // 
            this.LabelPasswordExplain.AutoSize = true;
            this.LabelPasswordExplain.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswordExplain.Location = new System.Drawing.Point(172, 241);
            this.LabelPasswordExplain.Name = "LabelPasswordExplain";
            this.LabelPasswordExplain.Size = new System.Drawing.Size(152, 18);
            this.LabelPasswordExplain.TabIndex = 24;
            this.LabelPasswordExplain.Text = "请输入数字或字母";
            this.LabelPasswordExplain.Visible = false;
            // 
            // LabelPasswordAgainExplain
            // 
            this.LabelPasswordAgainExplain.AutoSize = true;
            this.LabelPasswordAgainExplain.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswordAgainExplain.Location = new System.Drawing.Point(172, 291);
            this.LabelPasswordAgainExplain.Name = "LabelPasswordAgainExplain";
            this.LabelPasswordAgainExplain.Size = new System.Drawing.Size(170, 18);
            this.LabelPasswordAgainExplain.TabIndex = 25;
            this.LabelPasswordAgainExplain.Text = "两次密码输入不一致";
            this.LabelPasswordAgainExplain.Visible = false;
            // 
            // LabelErrorExpain
            // 
            this.LabelErrorExpain.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelErrorExpain.ForeColor = System.Drawing.Color.Red;
            this.LabelErrorExpain.Location = new System.Drawing.Point(10, 346);
            this.LabelErrorExpain.Name = "LabelErrorExpain";
            this.LabelErrorExpain.Size = new System.Drawing.Size(450, 37);
            this.LabelErrorExpain.TabIndex = 26;
            this.LabelErrorExpain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelErrorExpain.Visible = false;
            // 
            // labelNameExplain
            // 
            this.labelNameExplain.AutoSize = true;
            this.labelNameExplain.ForeColor = System.Drawing.Color.Red;
            this.labelNameExplain.Location = new System.Drawing.Point(172, 141);
            this.labelNameExplain.Name = "labelNameExplain";
            this.labelNameExplain.Size = new System.Drawing.Size(98, 18);
            this.labelNameExplain.TabIndex = 27;
            this.labelNameExplain.Text = "请输入昵称";
            this.labelNameExplain.Visible = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 544);
            this.Controls.Add(this.labelNameExplain);
            this.Controls.Add(this.LabelErrorExpain);
            this.Controls.Add(this.LabelPasswordAgainExplain);
            this.Controls.Add(this.LabelPasswordExplain);
            this.Controls.Add(this.LabelAccountExplain);
            this.Controls.Add(this.TextPasswordAgain);
            this.Controls.Add(this.LabelPasswordAgain);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.TextAccount);
            this.Controls.Add(this.ComboBoxSex);
            this.Controls.Add(this.LabelSex);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelAccount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegister";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAccount;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.ComboBox ComboBoxSex;
        private System.Windows.Forms.TextBox TextAccount;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.TextBox TextPasswordAgain;
        private System.Windows.Forms.Label LabelPasswordAgain;
        private System.Windows.Forms.Label LabelAccountExplain;
        private System.Windows.Forms.Label LabelPasswordExplain;
        private System.Windows.Forms.Label LabelPasswordAgainExplain;
        private System.Windows.Forms.Label LabelErrorExpain;
        private System.Windows.Forms.Label labelNameExplain;
    }
}