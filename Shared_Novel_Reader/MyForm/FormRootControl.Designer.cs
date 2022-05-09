﻿namespace Shared_Novel_Reader.MyForm
{
    partial class FormRootControl
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageAdmin = new System.Windows.Forms.TabPage();
            this.DataGridViewUser = new System.Windows.Forms.DataGridView();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Integral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Integral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ReFind = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminControl = new System.Windows.Forms.ToolStripMenuItem();
            this.TabPageSystem = new System.Windows.Forms.TabPage();
            this.BtnWARNClose = new System.Windows.Forms.Button();
            this.BtnINFOClose = new System.Windows.Forms.Button();
            this.BtnDEBUGClose = new System.Windows.Forms.Button();
            this.BtnWARNOpen = new System.Windows.Forms.Button();
            this.BtnINFOOpen = new System.Windows.Forms.Button();
            this.BtnDEBUGOpen = new System.Windows.Forms.Button();
            this.BtnTRACEOpen = new System.Windows.Forms.Button();
            this.BtnTRACEClose = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelWARNValue = new System.Windows.Forms.Label();
            this.LabelWARN = new System.Windows.Forms.Label();
            this.LabelINFOValue = new System.Windows.Forms.Label();
            this.LabelINFO = new System.Windows.Forms.Label();
            this.LabelDEBUGValue = new System.Windows.Forms.Label();
            this.LabelDEBUG = new System.Windows.Forms.Label();
            this.LabelTRACEValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelTRACE = new System.Windows.Forms.Label();
            this.TabPageReport = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.TabPageAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).BeginInit();
            this.ContextMenuStripUser.SuspendLayout();
            this.TabPageSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageAdmin);
            this.TabControl.Controls.Add(this.TabPageSystem);
            this.TabControl.Controls.Add(this.TabPageReport);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1150, 740);
            this.TabControl.TabIndex = 3;
            // 
            // TabPageAdmin
            // 
            this.TabPageAdmin.Controls.Add(this.DataGridViewUser);
            this.TabPageAdmin.Location = new System.Drawing.Point(4, 28);
            this.TabPageAdmin.Name = "TabPageAdmin";
            this.TabPageAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageAdmin.Size = new System.Drawing.Size(1142, 708);
            this.TabPageAdmin.TabIndex = 0;
            this.TabPageAdmin.Text = "管理员控制";
            this.TabPageAdmin.UseVisualStyleBackColor = true;
            this.TabPageAdmin.Click += new System.EventHandler(this.TabPageAdmin_Click);
            // 
            // DataGridViewUser
            // 
            this.DataGridViewUser.AllowUserToAddRows = false;
            this.DataGridViewUser.AllowUserToDeleteRows = false;
            this.DataGridViewUser.AllowUserToOrderColumns = true;
            this.DataGridViewUser.AllowUserToResizeColumns = false;
            this.DataGridViewUser.AllowUserToResizeRows = false;
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
            this.DataGridViewUser.ContextMenuStrip = this.ContextMenuStripUser;
            this.DataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewUser.GridColor = System.Drawing.Color.Peru;
            this.DataGridViewUser.Location = new System.Drawing.Point(3, 3);
            this.DataGridViewUser.Name = "DataGridViewUser";
            this.DataGridViewUser.ReadOnly = true;
            this.DataGridViewUser.RowHeadersVisible = false;
            this.DataGridViewUser.RowHeadersWidth = 62;
            this.DataGridViewUser.RowTemplate.Height = 30;
            this.DataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUser.Size = new System.Drawing.Size(1136, 702);
            this.DataGridViewUser.TabIndex = 1;
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
            // ContextMenuStripUser
            // 
            this.ContextMenuStripUser.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewDetails,
            this.ReFind,
            this.AdminControl});
            this.ContextMenuStripUser.Name = "ContextMenuStripFindUser";
            this.ContextMenuStripUser.Size = new System.Drawing.Size(269, 94);
            // 
            // ViewDetails
            // 
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Size = new System.Drawing.Size(268, 30);
            this.ViewDetails.Text = "查看详情";
            this.ViewDetails.Click += new System.EventHandler(this.ViewDetails_Click);
            // 
            // ReFind
            // 
            this.ReFind.Name = "ReFind";
            this.ReFind.Size = new System.Drawing.Size(268, 30);
            this.ReFind.Text = "重置查询范围";
            this.ReFind.Click += new System.EventHandler(this.ReFind_Click);
            // 
            // AdminControl
            // 
            this.AdminControl.Name = "AdminControl";
            this.AdminControl.Size = new System.Drawing.Size(268, 30);
            this.AdminControl.Text = "设为管理员/取消管理员";
            this.AdminControl.Click += new System.EventHandler(this.AdminControl_Click);
            // 
            // TabPageSystem
            // 
            this.TabPageSystem.Controls.Add(this.BtnWARNClose);
            this.TabPageSystem.Controls.Add(this.BtnINFOClose);
            this.TabPageSystem.Controls.Add(this.BtnDEBUGClose);
            this.TabPageSystem.Controls.Add(this.BtnWARNOpen);
            this.TabPageSystem.Controls.Add(this.BtnINFOOpen);
            this.TabPageSystem.Controls.Add(this.BtnDEBUGOpen);
            this.TabPageSystem.Controls.Add(this.BtnTRACEOpen);
            this.TabPageSystem.Controls.Add(this.BtnTRACEClose);
            this.TabPageSystem.Controls.Add(this.BtnClose);
            this.TabPageSystem.Controls.Add(this.BtnRestart);
            this.TabPageSystem.Controls.Add(this.label3);
            this.TabPageSystem.Controls.Add(this.LabelWARNValue);
            this.TabPageSystem.Controls.Add(this.LabelWARN);
            this.TabPageSystem.Controls.Add(this.LabelINFOValue);
            this.TabPageSystem.Controls.Add(this.LabelINFO);
            this.TabPageSystem.Controls.Add(this.LabelDEBUGValue);
            this.TabPageSystem.Controls.Add(this.LabelDEBUG);
            this.TabPageSystem.Controls.Add(this.LabelTRACEValue);
            this.TabPageSystem.Controls.Add(this.label2);
            this.TabPageSystem.Controls.Add(this.label1);
            this.TabPageSystem.Controls.Add(this.LabelTRACE);
            this.TabPageSystem.Location = new System.Drawing.Point(4, 28);
            this.TabPageSystem.Name = "TabPageSystem";
            this.TabPageSystem.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSystem.Size = new System.Drawing.Size(1142, 708);
            this.TabPageSystem.TabIndex = 1;
            this.TabPageSystem.Text = "系统控制";
            this.TabPageSystem.UseVisualStyleBackColor = true;
            // 
            // BtnWARNClose
            // 
            this.BtnWARNClose.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnWARNClose.ForeColor = System.Drawing.Color.Black;
            this.BtnWARNClose.Location = new System.Drawing.Point(536, 276);
            this.BtnWARNClose.Name = "BtnWARNClose";
            this.BtnWARNClose.Size = new System.Drawing.Size(126, 44);
            this.BtnWARNClose.TabIndex = 20;
            this.BtnWARNClose.Text = "关闭";
            this.BtnWARNClose.UseVisualStyleBackColor = true;
            this.BtnWARNClose.Visible = false;
            this.BtnWARNClose.Click += new System.EventHandler(this.BtnWARNClose_Click);
            // 
            // BtnINFOClose
            // 
            this.BtnINFOClose.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnINFOClose.ForeColor = System.Drawing.Color.Black;
            this.BtnINFOClose.Location = new System.Drawing.Point(536, 219);
            this.BtnINFOClose.Name = "BtnINFOClose";
            this.BtnINFOClose.Size = new System.Drawing.Size(126, 44);
            this.BtnINFOClose.TabIndex = 19;
            this.BtnINFOClose.Text = "关闭";
            this.BtnINFOClose.UseVisualStyleBackColor = true;
            this.BtnINFOClose.Visible = false;
            this.BtnINFOClose.Click += new System.EventHandler(this.BtnINFOClose_Click);
            // 
            // BtnDEBUGClose
            // 
            this.BtnDEBUGClose.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnDEBUGClose.ForeColor = System.Drawing.Color.Black;
            this.BtnDEBUGClose.Location = new System.Drawing.Point(536, 159);
            this.BtnDEBUGClose.Name = "BtnDEBUGClose";
            this.BtnDEBUGClose.Size = new System.Drawing.Size(126, 44);
            this.BtnDEBUGClose.TabIndex = 18;
            this.BtnDEBUGClose.Text = "关闭";
            this.BtnDEBUGClose.UseVisualStyleBackColor = true;
            this.BtnDEBUGClose.Visible = false;
            this.BtnDEBUGClose.Click += new System.EventHandler(this.BtnDEBUGClose_Click);
            // 
            // BtnWARNOpen
            // 
            this.BtnWARNOpen.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnWARNOpen.ForeColor = System.Drawing.Color.Black;
            this.BtnWARNOpen.Location = new System.Drawing.Point(536, 276);
            this.BtnWARNOpen.Name = "BtnWARNOpen";
            this.BtnWARNOpen.Size = new System.Drawing.Size(126, 44);
            this.BtnWARNOpen.TabIndex = 17;
            this.BtnWARNOpen.Text = "打开";
            this.BtnWARNOpen.UseVisualStyleBackColor = true;
            this.BtnWARNOpen.Visible = false;
            this.BtnWARNOpen.Click += new System.EventHandler(this.BtnWARNOpen_Click);
            // 
            // BtnINFOOpen
            // 
            this.BtnINFOOpen.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnINFOOpen.ForeColor = System.Drawing.Color.Black;
            this.BtnINFOOpen.Location = new System.Drawing.Point(536, 219);
            this.BtnINFOOpen.Name = "BtnINFOOpen";
            this.BtnINFOOpen.Size = new System.Drawing.Size(126, 44);
            this.BtnINFOOpen.TabIndex = 16;
            this.BtnINFOOpen.Text = "打开";
            this.BtnINFOOpen.UseVisualStyleBackColor = true;
            this.BtnINFOOpen.Visible = false;
            this.BtnINFOOpen.Click += new System.EventHandler(this.BtnINFOOpen_Click);
            // 
            // BtnDEBUGOpen
            // 
            this.BtnDEBUGOpen.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnDEBUGOpen.ForeColor = System.Drawing.Color.Black;
            this.BtnDEBUGOpen.Location = new System.Drawing.Point(536, 159);
            this.BtnDEBUGOpen.Name = "BtnDEBUGOpen";
            this.BtnDEBUGOpen.Size = new System.Drawing.Size(126, 44);
            this.BtnDEBUGOpen.TabIndex = 15;
            this.BtnDEBUGOpen.Text = "打开";
            this.BtnDEBUGOpen.UseVisualStyleBackColor = true;
            this.BtnDEBUGOpen.Visible = false;
            this.BtnDEBUGOpen.Click += new System.EventHandler(this.BtnDEBUGOpen_Click);
            // 
            // BtnTRACEOpen
            // 
            this.BtnTRACEOpen.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnTRACEOpen.ForeColor = System.Drawing.Color.Black;
            this.BtnTRACEOpen.Location = new System.Drawing.Point(536, 96);
            this.BtnTRACEOpen.Name = "BtnTRACEOpen";
            this.BtnTRACEOpen.Size = new System.Drawing.Size(126, 44);
            this.BtnTRACEOpen.TabIndex = 14;
            this.BtnTRACEOpen.Text = "打开";
            this.BtnTRACEOpen.UseVisualStyleBackColor = true;
            this.BtnTRACEOpen.Visible = false;
            this.BtnTRACEOpen.Click += new System.EventHandler(this.BtnTRACEOpen_Click);
            // 
            // BtnTRACEClose
            // 
            this.BtnTRACEClose.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnTRACEClose.ForeColor = System.Drawing.Color.Black;
            this.BtnTRACEClose.Location = new System.Drawing.Point(536, 96);
            this.BtnTRACEClose.Name = "BtnTRACEClose";
            this.BtnTRACEClose.Size = new System.Drawing.Size(126, 44);
            this.BtnTRACEClose.TabIndex = 13;
            this.BtnTRACEClose.Text = "关闭";
            this.BtnTRACEClose.UseVisualStyleBackColor = true;
            this.BtnTRACEClose.Visible = false;
            this.BtnTRACEClose.Click += new System.EventHandler(this.BtnTRACEClose_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Brown;
            this.BtnClose.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Location = new System.Drawing.Point(247, 429);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(126, 44);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "关闭";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnRestart
            // 
            this.BtnRestart.BackColor = System.Drawing.Color.LightGray;
            this.BtnRestart.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.BtnRestart.ForeColor = System.Drawing.Color.Black;
            this.BtnRestart.Location = new System.Drawing.Point(399, 429);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(126, 44);
            this.BtnRestart.TabIndex = 11;
            this.BtnRestart.Text = "重启";
            this.BtnRestart.UseVisualStyleBackColor = false;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "系统控制：";
            // 
            // LabelWARNValue
            // 
            this.LabelWARNValue.AutoSize = true;
            this.LabelWARNValue.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWARNValue.ForeColor = System.Drawing.Color.Black;
            this.LabelWARNValue.Location = new System.Drawing.Point(393, 282);
            this.LabelWARNValue.Name = "LabelWARNValue";
            this.LabelWARNValue.Size = new System.Drawing.Size(101, 32);
            this.LabelWARNValue.TabIndex = 9;
            this.LabelWARNValue.Text = "已开启";
            // 
            // LabelWARN
            // 
            this.LabelWARN.AutoSize = true;
            this.LabelWARN.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWARN.ForeColor = System.Drawing.Color.Black;
            this.LabelWARN.Location = new System.Drawing.Point(241, 282);
            this.LabelWARN.Name = "LabelWARN";
            this.LabelWARN.Size = new System.Drawing.Size(132, 32);
            this.LabelWARN.TabIndex = 8;
            this.LabelWARN.Text = "WARN：";
            // 
            // LabelINFOValue
            // 
            this.LabelINFOValue.AutoSize = true;
            this.LabelINFOValue.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelINFOValue.ForeColor = System.Drawing.Color.Black;
            this.LabelINFOValue.Location = new System.Drawing.Point(393, 219);
            this.LabelINFOValue.Name = "LabelINFOValue";
            this.LabelINFOValue.Size = new System.Drawing.Size(101, 32);
            this.LabelINFOValue.TabIndex = 7;
            this.LabelINFOValue.Text = "已开启";
            // 
            // LabelINFO
            // 
            this.LabelINFO.AutoSize = true;
            this.LabelINFO.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelINFO.ForeColor = System.Drawing.Color.Black;
            this.LabelINFO.Location = new System.Drawing.Point(241, 219);
            this.LabelINFO.Name = "LabelINFO";
            this.LabelINFO.Size = new System.Drawing.Size(116, 32);
            this.LabelINFO.TabIndex = 6;
            this.LabelINFO.Text = "INFO：";
            // 
            // LabelDEBUGValue
            // 
            this.LabelDEBUGValue.AutoSize = true;
            this.LabelDEBUGValue.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDEBUGValue.ForeColor = System.Drawing.Color.Black;
            this.LabelDEBUGValue.Location = new System.Drawing.Point(393, 165);
            this.LabelDEBUGValue.Name = "LabelDEBUGValue";
            this.LabelDEBUGValue.Size = new System.Drawing.Size(101, 32);
            this.LabelDEBUGValue.TabIndex = 5;
            this.LabelDEBUGValue.Text = "已开启";
            // 
            // LabelDEBUG
            // 
            this.LabelDEBUG.AutoSize = true;
            this.LabelDEBUG.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDEBUG.ForeColor = System.Drawing.Color.Black;
            this.LabelDEBUG.Location = new System.Drawing.Point(241, 165);
            this.LabelDEBUG.Name = "LabelDEBUG";
            this.LabelDEBUG.Size = new System.Drawing.Size(148, 32);
            this.LabelDEBUG.TabIndex = 4;
            this.LabelDEBUG.Text = "DEBUG：";
            // 
            // LabelTRACEValue
            // 
            this.LabelTRACEValue.AutoSize = true;
            this.LabelTRACEValue.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTRACEValue.ForeColor = System.Drawing.Color.Black;
            this.LabelTRACEValue.Location = new System.Drawing.Point(393, 102);
            this.LabelTRACEValue.Name = "LabelTRACEValue";
            this.LabelTRACEValue.Size = new System.Drawing.Size(101, 32);
            this.LabelTRACEValue.TabIndex = 3;
            this.LabelTRACEValue.Text = "已开启";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRACE < DEBUG < INFO < WARN ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "系统日志等级：";
            // 
            // LabelTRACE
            // 
            this.LabelTRACE.AutoSize = true;
            this.LabelTRACE.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTRACE.ForeColor = System.Drawing.Color.Black;
            this.LabelTRACE.Location = new System.Drawing.Point(241, 102);
            this.LabelTRACE.Name = "LabelTRACE";
            this.LabelTRACE.Size = new System.Drawing.Size(146, 32);
            this.LabelTRACE.TabIndex = 0;
            this.LabelTRACE.Text = "TRACE：";
            // 
            // TabPageReport
            // 
            this.TabPageReport.Location = new System.Drawing.Point(4, 28);
            this.TabPageReport.Name = "TabPageReport";
            this.TabPageReport.Size = new System.Drawing.Size(1142, 708);
            this.TabPageReport.TabIndex = 2;
            this.TabPageReport.Text = "财务报表";
            this.TabPageReport.UseVisualStyleBackColor = true;
            // 
            // FormRootControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRootControl";
            this.Text = "FormRootControl";
            this.TabControl.ResumeLayout(false);
            this.TabPageAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUser)).EndInit();
            this.ContextMenuStripUser.ResumeLayout(false);
            this.TabPageSystem.ResumeLayout(false);
            this.TabPageSystem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPageAdmin;
        private System.Windows.Forms.TabPage TabPageSystem;
        private System.Windows.Forms.TabPage TabPageReport;
        public System.Windows.Forms.ContextMenuStrip ContextMenuStripUser;
        public System.Windows.Forms.ToolStripMenuItem ReFind;
        private System.Windows.Forms.ToolStripMenuItem ViewDetails;
        private System.Windows.Forms.DataGridView DataGridViewUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power;
        private System.Windows.Forms.DataGridViewTextBoxColumn Integral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Integral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripMenuItem AdminControl;
        private System.Windows.Forms.Label LabelTRACE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelTRACEValue;
        private System.Windows.Forms.Label LabelDEBUG;
        private System.Windows.Forms.Label LabelDEBUGValue;
        private System.Windows.Forms.Label LabelWARNValue;
        private System.Windows.Forms.Label LabelWARN;
        private System.Windows.Forms.Label LabelINFOValue;
        private System.Windows.Forms.Label LabelINFO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnTRACEClose;
        private System.Windows.Forms.Button BtnTRACEOpen;
        private System.Windows.Forms.Button BtnDEBUGOpen;
        private System.Windows.Forms.Button BtnINFOOpen;
        private System.Windows.Forms.Button BtnWARNOpen;
        private System.Windows.Forms.Button BtnDEBUGClose;
        private System.Windows.Forms.Button BtnINFOClose;
        private System.Windows.Forms.Button BtnWARNClose;
    }
}