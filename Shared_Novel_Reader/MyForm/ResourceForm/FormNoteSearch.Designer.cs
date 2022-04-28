﻿namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    partial class FormNoteSearch
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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelKey = new System.Windows.Forms.Label();
            this.ComboBoxNoteType = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.FlowLayoutPanelNote = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelTop.Controls.Add(this.LabelKey);
            this.PanelTop.Controls.Add(this.ComboBoxNoteType);
            this.PanelTop.Controls.Add(this.BtnSearch);
            this.PanelTop.Controls.Add(this.TextSearch);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1150, 100);
            this.PanelTop.TabIndex = 0;
            // 
            // LabelKey
            // 
            this.LabelKey.AutoSize = true;
            this.LabelKey.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelKey.Location = new System.Drawing.Point(11, 39);
            this.LabelKey.Name = "LabelKey";
            this.LabelKey.Size = new System.Drawing.Size(95, 28);
            this.LabelKey.TabIndex = 16;
            this.LabelKey.Text = "关键字:";
            // 
            // ComboBoxNoteType
            // 
            this.ComboBoxNoteType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxNoteType.AutoCompleteCustomSource.AddRange(new string[] {
            "所有",
            "资源贴",
            "求助帖"});
            this.ComboBoxNoteType.DropDownHeight = 50;
            this.ComboBoxNoteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxNoteType.DropDownWidth = 50;
            this.ComboBoxNoteType.FormattingEnabled = true;
            this.ComboBoxNoteType.IntegralHeight = false;
            this.ComboBoxNoteType.Items.AddRange(new object[] {
            "所有",
            "资源贴",
            "求助帖"});
            this.ComboBoxNoteType.Location = new System.Drawing.Point(708, 39);
            this.ComboBoxNoteType.Name = "ComboBoxNoteType";
            this.ComboBoxNoteType.Size = new System.Drawing.Size(137, 26);
            this.ComboBoxNoteType.TabIndex = 15;
            this.ComboBoxNoteType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNoteType_SelectedIndexChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(922, 29);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(156, 45);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "搜索";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(112, 39);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(548, 28);
            this.TextSearch.TabIndex = 0;
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            // 
            // FlowLayoutPanelNote
            // 
            this.FlowLayoutPanelNote.AutoScroll = true;
            this.FlowLayoutPanelNote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FlowLayoutPanelNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanelNote.Location = new System.Drawing.Point(0, 100);
            this.FlowLayoutPanelNote.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanelNote.Name = "FlowLayoutPanelNote";
            this.FlowLayoutPanelNote.Size = new System.Drawing.Size(1150, 640);
            this.FlowLayoutPanelNote.TabIndex = 2;
            // 
            // FormNoteSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.FlowLayoutPanelNote);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNoteSearch";
            this.Text = "FormNoteSearch";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.ComboBox ComboBoxNoteType;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelNote;
        private System.Windows.Forms.Label LabelKey;
    }
}