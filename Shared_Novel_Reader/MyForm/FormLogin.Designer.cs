namespace Shared_Novel_Reader.MyForm
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PictureLogo = new System.Windows.Forms.PictureBox();
            this.LabelAccount = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextAccount = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TimerLogoMove = new System.Windows.Forms.Timer(this.components);
            this.BtnCancelLogin = new System.Windows.Forms.Button();
            this.LabelAccountExplain = new System.Windows.Forms.Label();
            this.LabelPasswordExplain = new System.Windows.Forms.Label();
            this.Label_Pwd_IMG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureLogo
            // 
            this.PictureLogo.Image = global::Shared_Novel_Reader.Properties.Resources.user;
            this.PictureLogo.Location = new System.Drawing.Point(70, 60);
            this.PictureLogo.Name = "PictureLogo";
            this.PictureLogo.Size = new System.Drawing.Size(150, 150);
            this.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLogo.TabIndex = 0;
            this.PictureLogo.TabStop = false;
            // 
            // LabelAccount
            // 
            this.LabelAccount.AutoSize = true;
            this.LabelAccount.Location = new System.Drawing.Point(252, 100);
            this.LabelAccount.Name = "LabelAccount";
            this.LabelAccount.Size = new System.Drawing.Size(62, 18);
            this.LabelAccount.TabIndex = 1;
            this.LabelAccount.Text = "账户：";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Location = new System.Drawing.Point(252, 153);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(62, 18);
            this.LabelPassword.TabIndex = 2;
            this.LabelPassword.Text = "密码：";
            // 
            // TextAccount
            // 
            this.TextAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextAccount.Location = new System.Drawing.Point(338, 95);
            this.TextAccount.MaxLength = 11;
            this.TextAccount.Name = "TextAccount";
            this.TextAccount.Size = new System.Drawing.Size(144, 28);
            this.TextAccount.TabIndex = 4;
            this.TextAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextAccount_KeyPress);
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(338, 148);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(144, 28);
            this.TextPassword.TabIndex = 5;
            this.TextPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPassword_KeyPress);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(100, 250);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 50);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "登入";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(400, 250);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(100, 50);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TimerLogoMove
            // 
            this.TimerLogoMove.Interval = 10;
            this.TimerLogoMove.Tick += new System.EventHandler(this.TimerLogoMove_Tick);
            // 
            // BtnCancelLogin
            // 
            this.BtnCancelLogin.BackColor = System.Drawing.SystemColors.Control;
            this.BtnCancelLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelLogin.FlatAppearance.BorderSize = 0;
            this.BtnCancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelLogin.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelLogin.Location = new System.Drawing.Point(240, 250);
            this.BtnCancelLogin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCancelLogin.Name = "BtnCancelLogin";
            this.BtnCancelLogin.Size = new System.Drawing.Size(100, 50);
            this.BtnCancelLogin.TabIndex = 8;
            this.BtnCancelLogin.Text = "取消";
            this.BtnCancelLogin.UseVisualStyleBackColor = false;
            this.BtnCancelLogin.Visible = false;
            this.BtnCancelLogin.Click += new System.EventHandler(this.BtnCancelLogin_Click);
            // 
            // LabelAccountExplain
            // 
            this.LabelAccountExplain.AutoSize = true;
            this.LabelAccountExplain.ForeColor = System.Drawing.Color.Red;
            this.LabelAccountExplain.Location = new System.Drawing.Point(335, 126);
            this.LabelAccountExplain.Name = "LabelAccountExplain";
            this.LabelAccountExplain.Size = new System.Drawing.Size(170, 18);
            this.LabelAccountExplain.TabIndex = 9;
            this.LabelAccountExplain.Text = "请输入数字(6-10位)";
            this.LabelAccountExplain.Visible = false;
            // 
            // LabelPasswordExplain
            // 
            this.LabelPasswordExplain.AutoSize = true;
            this.LabelPasswordExplain.ForeColor = System.Drawing.Color.Red;
            this.LabelPasswordExplain.Location = new System.Drawing.Point(335, 179);
            this.LabelPasswordExplain.Name = "LabelPasswordExplain";
            this.LabelPasswordExplain.Size = new System.Drawing.Size(152, 18);
            this.LabelPasswordExplain.TabIndex = 10;
            this.LabelPasswordExplain.Text = "请输入数字或字母";
            this.LabelPasswordExplain.Visible = false;
            // 
            // Label_Pwd_IMG
            // 
            this.Label_Pwd_IMG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Pwd_IMG.Image = ((System.Drawing.Image)(resources.GetObject("Label_Pwd_IMG.Image")));
            this.Label_Pwd_IMG.Location = new System.Drawing.Point(489, 152);
            this.Label_Pwd_IMG.Name = "Label_Pwd_IMG";
            this.Label_Pwd_IMG.Size = new System.Drawing.Size(28, 28);
            this.Label_Pwd_IMG.TabIndex = 11;
            this.Label_Pwd_IMG.Click += new System.EventHandler(this.Label_Pwd_IMG_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 344);
            this.Controls.Add(this.Label_Pwd_IMG);
            this.Controls.Add(this.LabelPasswordExplain);
            this.Controls.Add(this.LabelAccountExplain);
            this.Controls.Add(this.BtnCancelLogin);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextAccount);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelAccount);
            this.Controls.Add(this.PictureLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登入";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureLogo;
        private System.Windows.Forms.Label LabelAccount;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextAccount;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Timer TimerLogoMove;
        private System.Windows.Forms.Button BtnCancelLogin;
        private System.Windows.Forms.Label LabelAccountExplain;
        private System.Windows.Forms.Label LabelPasswordExplain;
        private System.Windows.Forms.Label Label_Pwd_IMG;
    }
}