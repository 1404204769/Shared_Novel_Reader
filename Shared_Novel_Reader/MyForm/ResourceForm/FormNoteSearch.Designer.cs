namespace Shared_Novel_Reader.MyForm.ResourceForm
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
            this.components = new System.ComponentModel.Container();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.LabelKey = new System.Windows.Forms.Label();
            this.ComboBoxNoteType = new System.Windows.Forms.ComboBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.FlowLayoutPanelNote = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.View_New_Help_Top = new System.Windows.Forms.ToolStripMenuItem();
            this.View_New_Res_Top = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelTop.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Gray;
            this.PanelTop.Controls.Add(this.BtnCreate);
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
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnCreate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCreate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCreate.Location = new System.Drawing.Point(976, 27);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(120, 50);
            this.BtnCreate.TabIndex = 17;
            this.BtnCreate.Text = "发布";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // LabelKey
            // 
            this.LabelKey.AutoSize = true;
            this.LabelKey.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelKey.Location = new System.Drawing.Point(14, 38);
            this.LabelKey.Margin = new System.Windows.Forms.Padding(0);
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
            this.ComboBoxNoteType.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.ComboBoxNoteType.FormattingEnabled = true;
            this.ComboBoxNoteType.IntegralHeight = false;
            this.ComboBoxNoteType.Items.AddRange(new object[] {
            "所有",
            "资源贴",
            "求助帖"});
            this.ComboBoxNoteType.Location = new System.Drawing.Point(628, 35);
            this.ComboBoxNoteType.Name = "ComboBoxNoteType";
            this.ComboBoxNoteType.Size = new System.Drawing.Size(137, 36);
            this.ComboBoxNoteType.TabIndex = 15;
            this.ComboBoxNoteType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNoteType_SelectedIndexChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BtnSearch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSearch.Location = new System.Drawing.Point(827, 27);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(120, 50);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "搜索";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TextSearch
            // 
            this.TextSearch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.TextSearch.Location = new System.Drawing.Point(112, 35);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(496, 36);
            this.TextSearch.TabIndex = 0;
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            // 
            // FlowLayoutPanelNote
            // 
            this.FlowLayoutPanelNote.AutoScroll = true;
            this.FlowLayoutPanelNote.BackColor = System.Drawing.Color.Gainsboro;
            this.FlowLayoutPanelNote.ContextMenuStrip = this.contextMenuStrip;
            this.FlowLayoutPanelNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowLayoutPanelNote.Location = new System.Drawing.Point(0, 100);
            this.FlowLayoutPanelNote.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanelNote.Name = "FlowLayoutPanelNote";
            this.FlowLayoutPanelNote.Size = new System.Drawing.Size(1150, 640);
            this.FlowLayoutPanelNote.TabIndex = 2;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.View_New_Help_Top,
            this.View_New_Res_Top,
            this.Refresh});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(207, 94);
            // 
            // View_New_Help_Top
            // 
            this.View_New_Help_Top.Name = "View_New_Help_Top";
            this.View_New_Help_Top.Size = new System.Drawing.Size(240, 30);
            this.View_New_Help_Top.Text = "查看最新求助帖";
            this.View_New_Help_Top.Click += new System.EventHandler(this.View_New_Help_Top_Click);
            // 
            // View_New_Res_Top
            // 
            this.View_New_Res_Top.Name = "View_New_Res_Top";
            this.View_New_Res_Top.Size = new System.Drawing.Size(240, 30);
            this.View_New_Res_Top.Text = "查看最新资源贴";
            this.View_New_Res_Top.Click += new System.EventHandler(this.View_New_Res_Top_Click);
            // 
            // Refresh
            // 
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(240, 30);
            this.Refresh.Text = "刷新";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
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
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.ComboBox ComboBoxNoteType;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelNote;
        private System.Windows.Forms.Label LabelKey;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem View_New_Help_Top;
        private System.Windows.Forms.ToolStripMenuItem View_New_Res_Top;
        private System.Windows.Forms.ToolStripMenuItem Refresh;
    }
}