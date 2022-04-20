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
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.BtnPanel = new System.Windows.Forms.Panel();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.BtnPersonalData = new System.Windows.Forms.Button();
            this.BtnResManage = new System.Windows.Forms.Button();
            this.BtnBookShelf = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelAppTitle = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LabelToolString = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TimerTopPanelTime = new System.Windows.Forms.Timer(this.components);
            PictureLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(PictureLogo)).BeginInit();
            this.SizePanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.BtnPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureLogo
            // 
            PictureLogo.BackColor = System.Drawing.Color.DimGray;
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
            this.SizePanel.BackColor = System.Drawing.Color.DimGray;
            this.SizePanel.Controls.Add(this.LogoPanel);
            this.SizePanel.Controls.Add(this.BtnPersonalData);
            this.SizePanel.Controls.Add(this.BtnResManage);
            this.SizePanel.Controls.Add(this.BtnBookShelf);
            this.SizePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SizePanel.Location = new System.Drawing.Point(0, 60);
            this.SizePanel.Name = "SizePanel";
            this.SizePanel.Size = new System.Drawing.Size(250, 740);
            this.SizePanel.TabIndex = 0;
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
            this.BtnPanel.BackColor = System.Drawing.Color.DimGray;
            this.BtnPanel.Controls.Add(this.BtnRegister);
            this.BtnPanel.Controls.Add(this.BtnLogin);
            this.BtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPanel.Location = new System.Drawing.Point(0, 200);
            this.BtnPanel.Name = "BtnPanel";
            this.BtnPanel.Size = new System.Drawing.Size(250, 50);
            this.BtnPanel.TabIndex = 5;
            // 
            // BtnRegister
            // 
            this.BtnRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Location = new System.Drawing.Point(125, 0);
            this.BtnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(125, 50);
            this.BtnRegister.TabIndex = 1;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(0, 0);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(125, 50);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "登入";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // TitlePanel
            // 
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 150);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(250, 50);
            this.TitlePanel.TabIndex = 1;
            // 
            // BtnPersonalData
            // 
            this.BtnPersonalData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPersonalData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPersonalData.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnPersonalData.FlatAppearance.BorderSize = 0;
            this.BtnPersonalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPersonalData.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnPersonalData.ForeColor = System.Drawing.Color.White;
            this.BtnPersonalData.Image = global::Shared_Novel_Reader.Properties.Resources.personal_Data;
            this.BtnPersonalData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPersonalData.Location = new System.Drawing.Point(0, 418);
            this.BtnPersonalData.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPersonalData.Name = "BtnPersonalData";
            this.BtnPersonalData.Size = new System.Drawing.Size(250, 60);
            this.BtnPersonalData.TabIndex = 2;
            this.BtnPersonalData.Text = "个人信息";
            this.BtnPersonalData.UseVisualStyleBackColor = true;
            this.BtnPersonalData.Click += new System.EventHandler(this.BtnPersonalData_Click);
            // 
            // BtnResManage
            // 
            this.BtnResManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnResManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnResManage.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnResManage.FlatAppearance.BorderSize = 0;
            this.BtnResManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResManage.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnResManage.ForeColor = System.Drawing.Color.White;
            this.BtnResManage.Image = global::Shared_Novel_Reader.Properties.Resources.Resources_Outlined;
            this.BtnResManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnResManage.Location = new System.Drawing.Point(0, 348);
            this.BtnResManage.Margin = new System.Windows.Forms.Padding(0);
            this.BtnResManage.Name = "BtnResManage";
            this.BtnResManage.Size = new System.Drawing.Size(250, 60);
            this.BtnResManage.TabIndex = 1;
            this.BtnResManage.Text = "资源管理";
            this.BtnResManage.UseVisualStyleBackColor = true;
            this.BtnResManage.Click += new System.EventHandler(this.BtnResManage_Click);
            // 
            // BtnBookShelf
            // 
            this.BtnBookShelf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBookShelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBookShelf.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BtnBookShelf.FlatAppearance.BorderSize = 0;
            this.BtnBookShelf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBookShelf.Font = new System.Drawing.Font("华文新魏", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnBookShelf.ForeColor = System.Drawing.Color.White;
            this.BtnBookShelf.Image = global::Shared_Novel_Reader.Properties.Resources.chart_bar;
            this.BtnBookShelf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBookShelf.Location = new System.Drawing.Point(0, 275);
            this.BtnBookShelf.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBookShelf.Name = "BtnBookShelf";
            this.BtnBookShelf.Size = new System.Drawing.Size(250, 60);
            this.BtnBookShelf.TabIndex = 0;
            this.BtnBookShelf.Text = "书架";
            this.BtnBookShelf.UseVisualStyleBackColor = true;
            this.BtnBookShelf.Click += new System.EventHandler(this.BtnBookShelf_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Gray;
            this.TopPanel.Controls.Add(this.LabelTime);
            this.TopPanel.Controls.Add(this.LabelAppTitle);
            this.TopPanel.Controls.Add(this.BtnClose);
            this.TopPanel.Controls.Add(this.LabelToolString);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1400, 60);
            this.TopPanel.TabIndex = 1;
            // 
            // LabelTime
            // 
            this.LabelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelTime.Location = new System.Drawing.Point(1139, 0);
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
            this.LabelAppTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelAppTitle.Font = new System.Drawing.Font("Bookman Old Style", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppTitle.Image = global::Shared_Novel_Reader.Properties.Resources.Book;
            this.LabelAppTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelAppTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelAppTitle.Name = "LabelAppTitle";
            this.LabelAppTitle.Size = new System.Drawing.Size(472, 60);
            this.LabelAppTitle.TabIndex = 5;
            this.LabelAppTitle.Text = "   小说共享平台阅读器";
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
            this.BtnClose.Image = global::Shared_Novel_Reader.Properties.Resources.close_bold;
            this.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClose.Location = new System.Drawing.Point(1340, 0);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(60, 60);
            this.BtnClose.TabIndex = 4;
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LabelToolString
            // 
            this.LabelToolString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelToolString.BackColor = System.Drawing.Color.White;
            this.LabelToolString.Location = new System.Drawing.Point(478, 0);
            this.LabelToolString.Name = "LabelToolString";
            this.LabelToolString.Size = new System.Drawing.Size(655, 60);
            this.LabelToolString.TabIndex = 6;
            this.LabelToolString.Text = "   ";
            this.LabelToolString.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.LabelToolString.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.LabelToolString.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Silver;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(PictureLogo)).EndInit();
            this.SizePanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.BtnPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SizePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BtnBookShelf;
        private System.Windows.Forms.Button BtnPersonalData;
        private System.Windows.Forms.Button BtnResManage;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Panel BtnPanel;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LabelAppTitle;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label LabelToolString;
        private System.Windows.Forms.Timer TimerTopPanelTime;
    }
}