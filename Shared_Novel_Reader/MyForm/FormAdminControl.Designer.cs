namespace Shared_Novel_Reader.MyForm
{
    partial class FormAdminControl
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
            this.LabelShow = new System.Windows.Forms.Label();
            this.AdminTop = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnUserManagement = new System.Windows.Forms.Button();
            this.BtnResourceManagement = new System.Windows.Forms.Button();
            this.BtnUserApplication = new System.Windows.Forms.Button();
            this.BtnUserFeedback = new System.Windows.Forms.Button();
            this.AdminMainPanel = new System.Windows.Forms.Panel();
            this.AdminTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = true;
            this.LabelShow.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.ForeColor = System.Drawing.Color.Black;
            this.LabelShow.Location = new System.Drawing.Point(367, 357);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(367, 56);
            this.LabelShow.TabIndex = 3;
            this.LabelShow.Text = "这是管理员界面";
            // 
            // AdminTop
            // 
            this.AdminTop.BackColor = System.Drawing.Color.White;
            this.AdminTop.Controls.Add(this.BtnUserManagement);
            this.AdminTop.Controls.Add(this.BtnResourceManagement);
            this.AdminTop.Controls.Add(this.BtnUserApplication);
            this.AdminTop.Controls.Add(this.BtnUserFeedback);
            this.AdminTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminTop.Location = new System.Drawing.Point(0, 0);
            this.AdminTop.Name = "AdminTop";
            this.AdminTop.Size = new System.Drawing.Size(1150, 50);
            this.AdminTop.TabIndex = 4;
            // 
            // BtnUserManagement
            // 
            this.BtnUserManagement.FlatAppearance.BorderSize = 0;
            this.BtnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserManagement.Location = new System.Drawing.Point(3, 3);
            this.BtnUserManagement.Name = "BtnUserManagement";
            this.BtnUserManagement.Size = new System.Drawing.Size(100, 50);
            this.BtnUserManagement.TabIndex = 0;
            this.BtnUserManagement.Text = "用户管理";
            this.BtnUserManagement.UseVisualStyleBackColor = true;
            this.BtnUserManagement.Click += new System.EventHandler(this.BtnUserManagement_Click);
            // 
            // BtnResourceManagement
            // 
            this.BtnResourceManagement.FlatAppearance.BorderSize = 0;
            this.BtnResourceManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResourceManagement.Location = new System.Drawing.Point(109, 3);
            this.BtnResourceManagement.Name = "BtnResourceManagement";
            this.BtnResourceManagement.Size = new System.Drawing.Size(100, 50);
            this.BtnResourceManagement.TabIndex = 1;
            this.BtnResourceManagement.Text = "资源管理";
            this.BtnResourceManagement.UseVisualStyleBackColor = true;
            this.BtnResourceManagement.Click += new System.EventHandler(this.BtnResourceManagement_Click);
            // 
            // BtnUserApplication
            // 
            this.BtnUserApplication.FlatAppearance.BorderSize = 0;
            this.BtnUserApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserApplication.Location = new System.Drawing.Point(215, 3);
            this.BtnUserApplication.Name = "BtnUserApplication";
            this.BtnUserApplication.Size = new System.Drawing.Size(100, 50);
            this.BtnUserApplication.TabIndex = 2;
            this.BtnUserApplication.Text = "用户申请";
            this.BtnUserApplication.UseVisualStyleBackColor = true;
            this.BtnUserApplication.Click += new System.EventHandler(this.BtnUserApplication_Click);
            // 
            // BtnUserFeedback
            // 
            this.BtnUserFeedback.FlatAppearance.BorderSize = 0;
            this.BtnUserFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserFeedback.Location = new System.Drawing.Point(321, 3);
            this.BtnUserFeedback.Name = "BtnUserFeedback";
            this.BtnUserFeedback.Size = new System.Drawing.Size(100, 50);
            this.BtnUserFeedback.TabIndex = 3;
            this.BtnUserFeedback.Text = "用户反馈";
            this.BtnUserFeedback.UseVisualStyleBackColor = true;
            this.BtnUserFeedback.Click += new System.EventHandler(this.BtnUserFeedback_Click);
            // 
            // AdminMainPanel
            // 
            this.AdminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminMainPanel.ForeColor = System.Drawing.Color.Black;
            this.AdminMainPanel.Location = new System.Drawing.Point(0, 50);
            this.AdminMainPanel.Name = "AdminMainPanel";
            this.AdminMainPanel.Size = new System.Drawing.Size(1150, 690);
            this.AdminMainPanel.TabIndex = 5;
            // 
            // FormAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.AdminMainPanel);
            this.Controls.Add(this.AdminTop);
            this.Controls.Add(this.LabelShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdminControl";
            this.Text = "FormAdminControl";
            this.AdminTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelShow;
        private System.Windows.Forms.FlowLayoutPanel AdminTop;
        private System.Windows.Forms.Button BtnUserManagement;
        private System.Windows.Forms.Button BtnResourceManagement;
        private System.Windows.Forms.Button BtnUserApplication;
        private System.Windows.Forms.Button BtnUserFeedback;
        private System.Windows.Forms.Panel AdminMainPanel;
    }
}