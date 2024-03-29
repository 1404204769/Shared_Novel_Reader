﻿namespace Shared_Novel_Reader.MyForm.AdminForm
{
    partial class FormUserFeedback
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewUserFeedback = new System.Windows.Forms.DataGridView();
            this.Idea_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsManage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripFindUserFeedback = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.执行审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Allow = new System.Windows.Forms.ToolStripMenuItem();
            this.Refuse = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.ReFind = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserFeedback)).BeginInit();
            this.ContextMenuStripFindUserFeedback.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewUserFeedback
            // 
            this.DataGridViewUserFeedback.AllowUserToAddRows = false;
            this.DataGridViewUserFeedback.AllowUserToDeleteRows = false;
            this.DataGridViewUserFeedback.AllowUserToOrderColumns = true;
            this.DataGridViewUserFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUserFeedback.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewUserFeedback.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewUserFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUserFeedback.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idea_ID,
            this.User_ID,
            this.Type,
            this.Memo,
            this.Status,
            this.IsManage,
            this.Processor,
            this.Create_Time,
            this.Update_Time});
            this.DataGridViewUserFeedback.ContextMenuStrip = this.ContextMenuStripFindUserFeedback;
            this.DataGridViewUserFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewUserFeedback.GridColor = System.Drawing.Color.Peru;
            this.DataGridViewUserFeedback.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewUserFeedback.Name = "DataGridViewUserFeedback";
            this.DataGridViewUserFeedback.ReadOnly = true;
            this.DataGridViewUserFeedback.RowHeadersVisible = false;
            this.DataGridViewUserFeedback.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewUserFeedback.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewUserFeedback.RowTemplate.Height = 30;
            this.DataGridViewUserFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUserFeedback.Size = new System.Drawing.Size(1150, 690);
            this.DataGridViewUserFeedback.TabIndex = 1;
            // 
            // Idea_ID
            // 
            this.Idea_ID.HeaderText = "反馈ID";
            this.Idea_ID.MinimumWidth = 8;
            this.Idea_ID.Name = "Idea_ID";
            this.Idea_ID.ReadOnly = true;
            // 
            // User_ID
            // 
            this.User_ID.HeaderText = "反馈者ID";
            this.User_ID.MinimumWidth = 8;
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "反馈类型";
            this.Type.MinimumWidth = 8;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Memo
            // 
            this.Memo.HeaderText = "反馈详情";
            this.Memo.MinimumWidth = 8;
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            this.Memo.Visible = false;
            // 
            // Status
            // 
            this.Status.HeaderText = "反馈状态";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // IsManage
            // 
            this.IsManage.HeaderText = "是否处理";
            this.IsManage.MinimumWidth = 8;
            this.IsManage.Name = "IsManage";
            this.IsManage.ReadOnly = true;
            // 
            // Processor
            // 
            this.Processor.HeaderText = "处理者";
            this.Processor.MinimumWidth = 8;
            this.Processor.Name = "Processor";
            this.Processor.ReadOnly = true;
            // 
            // Create_Time
            // 
            this.Create_Time.HeaderText = "反馈时间";
            this.Create_Time.MinimumWidth = 8;
            this.Create_Time.Name = "Create_Time";
            this.Create_Time.ReadOnly = true;
            // 
            // Update_Time
            // 
            this.Update_Time.HeaderText = "处理时间";
            this.Update_Time.MinimumWidth = 8;
            this.Update_Time.Name = "Update_Time";
            this.Update_Time.ReadOnly = true;
            // 
            // ContextMenuStripFindUserFeedback
            // 
            this.ContextMenuStripFindUserFeedback.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripFindUserFeedback.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.执行审核ToolStripMenuItem,
            this.ViewDetails,
            this.ReFind});
            this.ContextMenuStripFindUserFeedback.Name = "ContextMenuStripFindUser";
            this.ContextMenuStripFindUserFeedback.Size = new System.Drawing.Size(189, 94);
            // 
            // 执行审核ToolStripMenuItem
            // 
            this.执行审核ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Allow,
            this.Refuse});
            this.执行审核ToolStripMenuItem.Name = "执行审核ToolStripMenuItem";
            this.执行审核ToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.执行审核ToolStripMenuItem.Text = "执行审核";
            // 
            // Allow
            // 
            this.Allow.Name = "Allow";
            this.Allow.Size = new System.Drawing.Size(182, 34);
            this.Allow.Text = "已完成";
            this.Allow.Click += new System.EventHandler(this.Allow_Click);
            // 
            // Refuse
            // 
            this.Refuse.Name = "Refuse";
            this.Refuse.Size = new System.Drawing.Size(182, 34);
            this.Refuse.Text = "拒绝执行";
            this.Refuse.Click += new System.EventHandler(this.Refuse_Click);
            // 
            // ViewDetails
            // 
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.Size = new System.Drawing.Size(188, 30);
            this.ViewDetails.Text = "查看详情";
            this.ViewDetails.Click += new System.EventHandler(this.ViewDetails_Click);
            // 
            // ReFind
            // 
            this.ReFind.Name = "ReFind";
            this.ReFind.Size = new System.Drawing.Size(188, 30);
            this.ReFind.Text = "重置查询范围";
            this.ReFind.Click += new System.EventHandler(this.ReFind_Click);
            // 
            // FormUserFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1150, 690);
            this.Controls.Add(this.DataGridViewUserFeedback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserFeedback";
            this.Text = "FormUserFeedback";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserFeedback)).EndInit();
            this.ContextMenuStripFindUserFeedback.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewUserFeedback;
        public System.Windows.Forms.ContextMenuStrip ContextMenuStripFindUserFeedback;
        public System.Windows.Forms.ToolStripMenuItem ReFind;
        public System.Windows.Forms.ToolStripMenuItem ViewDetails;
        private System.Windows.Forms.ToolStripMenuItem 执行审核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Allow;
        private System.Windows.Forms.ToolStripMenuItem Refuse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idea_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsManage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Create_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_Time;
    }
}