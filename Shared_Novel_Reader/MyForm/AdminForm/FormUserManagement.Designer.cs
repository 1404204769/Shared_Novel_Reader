namespace Shared_Novel_Reader.MyForm.AdminForm
{
    partial class FormUserManagement
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
            this.DataGridViewUser = new System.Windows.Forms.DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Integral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripFindUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReFind = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.Ban = new System.Windows.Forms.ToolStripMenuItem();
            this.Unseal = new System.Windows.Forms.ToolStripMenuItem();
            this.InitPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeIntegral = new System.Windows.Forms.ToolStripMenuItem();
            this.Reward = new System.Windows.Forms.ToolStripMenuItem();
            this.Punishment = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).BeginInit();
            this.ContextMenuStripFindUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewUser
            // 
            this.DataGridViewUser.AllowUserToAddRows = false;
            this.DataGridViewUser.AllowUserToDeleteRows = false;
            this.DataGridViewUser.AllowUserToOrderColumns = true;
            this.DataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_ID,
            this.User_Name,
            this.Sex,
            this.Level,
            this.Power,
            this.Integral,
            this.Total_Integral,
            this.Status});
            this.DataGridViewUser.ContextMenuStrip = this.ContextMenuStripFindUser;
            this.DataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewUser.GridColor = System.Drawing.Color.Peru;
            this.DataGridViewUser.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewUser.Name = "DataGridViewUser";
            this.DataGridViewUser.ReadOnly = true;
            this.DataGridViewUser.RowHeadersVisible = false;
            this.DataGridViewUser.RowHeadersWidth = 62;
            this.DataGridViewUser.RowTemplate.Height = 30;
            this.DataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUser.Size = new System.Drawing.Size(1150, 690);
            this.DataGridViewUser.TabIndex = 0;
            // 
            // User_ID
            // 
            this.User_ID.HeaderText = "账号";
            this.User_ID.MinimumWidth = 8;
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            // 
            // User_Name
            // 
            this.User_Name.HeaderText = "姓名";
            this.User_Name.MinimumWidth = 8;
            this.User_Name.Name = "User_Name";
            this.User_Name.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "性别";
            this.Sex.MinimumWidth = 8;
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.HeaderText = "等级";
            this.Level.MinimumWidth = 8;
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // Power
            // 
            this.Power.HeaderText = "权限";
            this.Power.MinimumWidth = 8;
            this.Power.Name = "Power";
            this.Power.ReadOnly = true;
            // 
            // Integral
            // 
            this.Integral.HeaderText = "积分";
            this.Integral.MinimumWidth = 8;
            this.Integral.Name = "Integral";
            this.Integral.ReadOnly = true;
            // 
            // Total_Integral
            // 
            this.Total_Integral.HeaderText = "总积分";
            this.Total_Integral.MinimumWidth = 8;
            this.Total_Integral.Name = "Total_Integral";
            this.Total_Integral.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "状态";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ContextMenuStripFindUser
            // 
            this.ContextMenuStripFindUser.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripFindUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ban,
            this.Unseal,
            this.ChangeIntegral,
            this.ViewDetails,
            this.InitPwd,
            this.ReFind});
            this.ContextMenuStripFindUser.Name = "ContextMenuStripFindUser";
            this.ContextMenuStripFindUser.Size = new System.Drawing.Size(241, 217);
            // 
            // ReFind
            // 
            this.ReFind.Name = "ReFind";
            this.ReFind.Size = new System.Drawing.Size(240, 30);
            this.ReFind.Text = "重置查询范围";
            this.ReFind.Click += new System.EventHandler(this.ReFind_Click);
            // 
            // ViewDetails
            // 
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Size = new System.Drawing.Size(240, 30);
            this.ViewDetails.Text = "查看详情";
            this.ViewDetails.Click += new System.EventHandler(this.ViewDetails_Click);
            // 
            // Ban
            // 
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(240, 30);
            this.Ban.Text = "封号";
            this.Ban.Click += new System.EventHandler(this.Ban_Click);
            // 
            // Unseal
            // 
            this.Unseal.Name = "Unseal";
            this.Unseal.Size = new System.Drawing.Size(240, 30);
            this.Unseal.Text = "解封";
            this.Unseal.Click += new System.EventHandler(this.Unseal_Click);
            // 
            // InitPwd
            // 
            this.InitPwd.Name = "InitPwd";
            this.InitPwd.Size = new System.Drawing.Size(240, 30);
            this.InitPwd.Text = "初始化密码";
            this.InitPwd.Click += new System.EventHandler(this.InitPwd_Click);
            // 
            // ChangeIntegral
            // 
            this.ChangeIntegral.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reward,
            this.Punishment});
            this.ChangeIntegral.Name = "ChangeIntegral";
            this.ChangeIntegral.Size = new System.Drawing.Size(240, 30);
            this.ChangeIntegral.Text = "更改积分";
            // 
            // Reward
            // 
            this.Reward.Name = "Reward";
            this.Reward.Size = new System.Drawing.Size(270, 34);
            this.Reward.Text = "奖励积分";
            this.Reward.Click += new System.EventHandler(this.Reward_Click);
            // 
            // Punishment
            // 
            this.Punishment.Name = "Punishment";
            this.Punishment.Size = new System.Drawing.Size(270, 34);
            this.Punishment.Text = "扣除积分";
            this.Punishment.Click += new System.EventHandler(this.Punishment_Click);
            // 
            // FormUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1150, 690);
            this.Controls.Add(this.DataGridViewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserManagement";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).EndInit();
            this.ContextMenuStripFindUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewUser;
        public System.Windows.Forms.ContextMenuStrip ContextMenuStripFindUser;
        public System.Windows.Forms.ToolStripMenuItem ReFind;
        private System.Windows.Forms.ToolStripMenuItem ViewDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Integral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripMenuItem Ban;
        private System.Windows.Forms.ToolStripMenuItem Unseal;
        private System.Windows.Forms.ToolStripMenuItem InitPwd;
        private System.Windows.Forms.ToolStripMenuItem ChangeIntegral;
        private System.Windows.Forms.ToolStripMenuItem Reward;
        private System.Windows.Forms.ToolStripMenuItem Punishment;
    }
}