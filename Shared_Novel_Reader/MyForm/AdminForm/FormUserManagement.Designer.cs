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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Integral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripFindUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReFind = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDetails = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ID,
            this.UserName,
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
            // ID
            // 
            this.ID.HeaderText = "账号";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "姓名";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
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
            this.ReFind,
            this.ViewDetails});
            this.ContextMenuStripFindUser.Name = "ContextMenuStripFindUser";
            this.ContextMenuStripFindUser.Size = new System.Drawing.Size(241, 97);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Integral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        public System.Windows.Forms.ContextMenuStrip ContextMenuStripFindUser;
        public System.Windows.Forms.ToolStripMenuItem ReFind;
        private System.Windows.Forms.ToolStripMenuItem ViewDetails;
    }
}