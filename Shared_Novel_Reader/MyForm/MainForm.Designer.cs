﻿namespace Shared_Novel_Reader.MyForm
{
    partial class MainForm
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
            System.Windows.Forms.PictureBox PictureLogo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SizePanel = new System.Windows.Forms.Panel();
            this.BtnRootControl = new System.Windows.Forms.Button();
            this.BtnAdminControl = new System.Windows.Forms.Button();
            this.BtnBookPlatform = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.BtnPanel = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.LabelWelcome = new System.Windows.Forms.Label();
            this.BtnPersonalData = new System.Windows.Forms.Button();
            this.BtnBookShelf = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.LabelTip = new System.Windows.Forms.Label();
            this.TipPanel = new System.Windows.Forms.Panel();
            this.LabelTipString = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelAppTitle = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TimerTopPanelTime = new System.Windows.Forms.Timer(this.components);
            this.TimerTip = new System.Windows.Forms.Timer(this.components);
            PictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(PictureLogo)).BeginInit();
            this.SizePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.BtnPanel.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.TipPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureLogo
            // 
            PictureLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            PictureLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureLogo.BackgroundImage")));
            PictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            PictureLogo.Dock = System.Windows.Forms.DockStyle.Top;
            PictureLogo.Location = new System.Drawing.Point(0, 0);
            PictureLogo.Margin = new System.Windows.Forms.Padding(0);
            PictureLogo.Name = "PictureLogo";
            PictureLogo.Size = new System.Drawing.Size(250, 150);
            PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            PictureLogo.TabIndex = 0;
            PictureLogo.TabStop = false;
            // 
            // SizePanel
            // 
            this.SizePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SizePanel.Controls.Add(this.BtnRootControl);
            this.SizePanel.Controls.Add(this.BtnAdminControl);
            this.SizePanel.Controls.Add(this.BtnBookPlatform);
            this.SizePanel.Controls.Add(this.LogoPanel);
            this.SizePanel.Controls.Add(this.BtnPersonalData);
            this.SizePanel.Controls.Add(this.BtnBookShelf);
            this.SizePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SizePanel.Location = new System.Drawing.Point(0, 60);
            this.SizePanel.Name = "SizePanel";
            this.SizePanel.Size = new System.Drawing.Size(250, 740);
            this.SizePanel.TabIndex = 0;
            // 
            // BtnRootControl
            // 
            this.BtnRootControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRootControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRootControl.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnRootControl.FlatAppearance.BorderSize = 0;
            this.BtnRootControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRootControl.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRootControl.ForeColor = System.Drawing.Color.Black;
            this.BtnRootControl.Image = global::Shared_Novel_Reader.Properties.Resources.root;
            this.BtnRootControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRootControl.Location = new System.Drawing.Point(0, 545);
            this.BtnRootControl.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRootControl.Name = "BtnRootControl";
            this.BtnRootControl.Size = new System.Drawing.Size(250, 60);
            this.BtnRootControl.TabIndex = 7;
            this.BtnRootControl.Text = "超级管理员";
            this.BtnRootControl.UseVisualStyleBackColor = true;
            this.BtnRootControl.Visible = false;
            this.BtnRootControl.Click += new System.EventHandler(this.BtnRootControl_Click);
            // 
            // BtnAdminControl
            // 
            this.BtnAdminControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnAdminControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdminControl.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnAdminControl.FlatAppearance.BorderSize = 0;
            this.BtnAdminControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdminControl.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAdminControl.ForeColor = System.Drawing.Color.Black;
            this.BtnAdminControl.Image = global::Shared_Novel_Reader.Properties.Resources.admin;
            this.BtnAdminControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdminControl.Location = new System.Drawing.Point(0, 476);
            this.BtnAdminControl.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdminControl.Name = "BtnAdminControl";
            this.BtnAdminControl.Size = new System.Drawing.Size(250, 60);
            this.BtnAdminControl.TabIndex = 6;
            this.BtnAdminControl.Text = "管理员";
            this.BtnAdminControl.UseVisualStyleBackColor = true;
            this.BtnAdminControl.Visible = false;
            this.BtnAdminControl.Click += new System.EventHandler(this.BtnAdminControl_Click);
            // 
            // BtnBookPlatform
            // 
            this.BtnBookPlatform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBookPlatform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBookPlatform.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnBookPlatform.FlatAppearance.BorderSize = 0;
            this.BtnBookPlatform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBookPlatform.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBookPlatform.ForeColor = System.Drawing.Color.Black;
            this.BtnBookPlatform.Image = global::Shared_Novel_Reader.Properties.Resources.BookPlatform;
            this.BtnBookPlatform.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBookPlatform.Location = new System.Drawing.Point(0, 406);
            this.BtnBookPlatform.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBookPlatform.Name = "BtnBookPlatform";
            this.BtnBookPlatform.Size = new System.Drawing.Size(250, 60);
            this.BtnBookPlatform.TabIndex = 5;
            this.BtnBookPlatform.Text = "图书平台";
            this.BtnBookPlatform.UseVisualStyleBackColor = true;
            this.BtnBookPlatform.Visible = false;
            this.BtnBookPlatform.Click += new System.EventHandler(this.BtnBookPlatform_Click);
            // 
            // LogoPanel
            // 
            this.LogoPanel.Controls.Add(this.BtnPanel);
            this.LogoPanel.Controls.Add(this.TitlePanel);
            this.LogoPanel.Controls.Add(PictureLogo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(250, 250);
            this.LogoPanel.TabIndex = 4;
            // 
            // BtnPanel
            // 
            this.BtnPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPanel.Controls.Add(this.BtnLogout);
            this.BtnPanel.Controls.Add(this.BtnRegister);
            this.BtnPanel.Controls.Add(this.BtnLogin);
            this.BtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPanel.Location = new System.Drawing.Point(0, 200);
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.Size = new System.Drawing.Size(250, 50);
            this.BtnPanel.TabIndex = 5;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.Maroon;
            this.BtnLogout.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnLogout.Location = new System.Drawing.Point(21, -1);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(206, 50);
            this.BtnLogout.TabIndex = 2;
            this.BtnLogout.Text = "注销";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Visible = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRegister.Location = new System.Drawing.Point(125, 0);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(125, 50);
            this.BtnRegister.TabIndex = 1;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Green;
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnLogin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Location = new System.Drawing.Point(0, 0);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(125, 50);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "登入";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.Controls.Add(this.LabelWelcome);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 150);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(250, 50);
            this.TitlePanel.TabIndex = 1;
            // 
            // LabelWelcome
            // 
            this.LabelWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelWelcome.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWelcome.Location = new System.Drawing.Point(0, 0);
            this.LabelWelcome.Name = "LabelWelcome";
            this.LabelWelcome.Size = new System.Drawing.Size(250, 50);
            this.LabelWelcome.TabIndex = 0;
            this.LabelWelcome.Text = "游客,请登入~";
            this.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPersonalData
            // 
            this.BtnPersonalData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPersonalData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPersonalData.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnPersonalData.FlatAppearance.BorderSize = 0;
            this.BtnPersonalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonalData.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPersonalData.ForeColor = System.Drawing.Color.Black;
            this.BtnPersonalData.Image = global::Shared_Novel_Reader.Properties.Resources.personal_Data;
            this.BtnPersonalData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonalData.Location = new System.Drawing.Point(0, 335);
            this.BtnPersonalData.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPersonalData.Name = "BtnPersonalData";
            this.BtnPersonalData.Size = new System.Drawing.Size(250, 60);
            this.BtnPersonalData.TabIndex = 2;
            this.BtnPersonalData.Text = "个人信息";
            this.BtnPersonalData.UseVisualStyleBackColor = true;
            this.BtnPersonalData.Visible = false;
            this.BtnPersonalData.Click += new System.EventHandler(this.BtnPersonalData_Click);
            // 
            // BtnBookShelf
            // 
            this.BtnBookShelf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnBookShelf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBookShelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBookShelf.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnBookShelf.FlatAppearance.BorderSize = 0;
            this.BtnBookShelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBookShelf.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBookShelf.ForeColor = System.Drawing.Color.Black;
            this.BtnBookShelf.Image = global::Shared_Novel_Reader.Properties.Resources.chart_bar;
            this.BtnBookShelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBookShelf.Location = new System.Drawing.Point(0, 275);
            this.BtnBookShelf.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBookShelf.Name = "BtnBookShelf";
            this.BtnBookShelf.Size = new System.Drawing.Size(250, 60);
            this.BtnBookShelf.TabIndex = 0;
            this.BtnBookShelf.Text = "书架";
            this.BtnBookShelf.UseVisualStyleBackColor = false;
            this.BtnBookShelf.Visible = false;
            this.BtnBookShelf.Click += new System.EventHandler(this.BtnBookShelf_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopPanel.Controls.Add(this.BtnMin);
            this.TopPanel.Controls.Add(this.BtnMax);
            this.TopPanel.Controls.Add(this.LabelTip);
            this.TopPanel.Controls.Add(this.TipPanel);
            this.TopPanel.Controls.Add(this.LabelTime);
            this.TopPanel.Controls.Add(this.LabelAppTitle);
            this.TopPanel.Controls.Add(this.BtnClose);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1400, 60);
            this.TopPanel.TabIndex = 1;
            // 
            // BtnMin
            // 
            this.BtnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMin.ForeColor = System.Drawing.Color.White;
            this.BtnMin.Image = global::Shared_Novel_Reader.Properties.Resources.Mini_mode;
            this.BtnMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMin.Location = new System.Drawing.Point(1220, 0);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(60, 60);
            this.BtnMin.TabIndex = 9;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMax.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnMax.ForeColor = System.Drawing.Color.White;
            this.BtnMax.Image = global::Shared_Novel_Reader.Properties.Resources.Max_mode;
            this.BtnMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMax.Location = new System.Drawing.Point(1280, 0);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(60, 60);
            this.BtnMax.TabIndex = 8;
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // LabelTip
            // 
            this.LabelTip.AutoSize = true;
            this.LabelTip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTip.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTip.ForeColor = System.Drawing.Color.DarkCyan;
            this.LabelTip.Location = new System.Drawing.Point(478, 19);
            this.LabelTip.Name = "LabelTip";
            this.LabelTip.Size = new System.Drawing.Size(86, 21);
            this.LabelTip.TabIndex = 0;
            this.LabelTip.Text = "免责声明";
            this.LabelTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTip.Click += new System.EventHandler(this.LabelTip_Click);
            // 
            // TipPanel
            // 
            this.TipPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TipPanel.Controls.Add(this.LabelTipString);
            this.TipPanel.Location = new System.Drawing.Point(570, 0);
            this.TipPanel.Name = "TipPanel";
            this.TipPanel.Size = new System.Drawing.Size(435, 60);
            this.TipPanel.TabIndex = 0;
            // 
            // LabelTipString
            // 
            this.LabelTipString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTipString.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTipString.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold);
            this.LabelTipString.Location = new System.Drawing.Point(3, 0);
            this.LabelTipString.Name = "LabelTipString";
            this.LabelTipString.Size = new System.Drawing.Size(435, 60);
            this.LabelTipString.TabIndex = 6;
            this.LabelTipString.Text = "   ";
            this.LabelTipString.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTipString.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.LabelTipString.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.LabelTipString.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // LabelTime
            // 
            this.LabelTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelTime.Location = new System.Drawing.Point(1011, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(201, 60);
            this.LabelTime.TabIndex = 7;
            this.LabelTime.Text = "Time";
            this.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.LabelTime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.LabelTime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // LabelAppTitle
            // 
            this.LabelAppTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelAppTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelAppTitle.Font = new System.Drawing.Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppTitle.Image = global::Shared_Novel_Reader.Properties.Resources.Book;
            this.LabelAppTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelAppTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelAppTitle.Name = "LabelAppTitle";
            this.LabelAppTitle.Size = new System.Drawing.Size(472, 60);
            this.LabelAppTitle.TabIndex = 5;
            this.LabelAppTitle.Text = "   小说资源共享平台";
            this.LabelAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabelAppTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.LabelAppTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.LabelAppTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Image = global::Shared_Novel_Reader.Properties.Resources.Shut_down;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(1340, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(60, 60);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.Color.Silver;
            this.MainPanel.Location = new System.Drawing.Point(250, 60);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1150, 740);
            this.MainPanel.TabIndex = 2;
            // 
            // TimerTopPanelTime
            // 
            this.TimerTopPanelTime.Interval = 1000;
            this.TimerTopPanelTime.Tick += new System.EventHandler(this.TimerTopPanelTime_Tick);
            // 
            // TimerTip
            // 
            this.TimerTip.Enabled = true;
            this.TimerTip.Tick += new System.EventHandler(this.TimerTip_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SizePanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(PictureLogo)).EndInit();
            this.SizePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.BtnPanel.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.TipPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SizePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnBookShelf;
        private System.Windows.Forms.Button BtnPersonalData;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel BtnPanel;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LabelAppTitle;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelTipString;
        private System.Windows.Forms.Timer TimerTopPanelTime;
        private System.Windows.Forms.Button BtnAdminControl;
        private System.Windows.Forms.Button BtnBookPlatform;
        private System.Windows.Forms.Button BtnRootControl;
        private System.Windows.Forms.Label LabelWelcome;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Panel TipPanel;
        private System.Windows.Forms.Timer TimerTip;
        private System.Windows.Forms.Label LabelTip;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMax;
    }
}