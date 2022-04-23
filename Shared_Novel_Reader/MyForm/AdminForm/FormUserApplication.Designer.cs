namespace Shared_Novel_Reader.MyForm.AdminForm
{
    partial class FormUserApplication
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewUserApplication = new System.Windows.Forms.DataGridView();
            this.Upload_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsManage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Processor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextMenuStripFindUserApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReFind = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewDetails = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserApplication)).BeginInit();
            this.ContextMenuStripFindUserApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridViewUserApplication
            // 
            this.DataGridViewUserApplication.AllowUserToAddRows = false;
            this.DataGridViewUserApplication.AllowUserToDeleteRows = false;
            this.DataGridViewUserApplication.AllowUserToOrderColumns = true;
            this.DataGridViewUserApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUserApplication.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewUserApplication.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewUserApplication.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewUserApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUserApplication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Upload_ID,
            this.User_ID,
            this.Book_ID,
            this.Content,
            this.Memo,
            this.Status,
            this.IsManage,
            this.Processor,
            this.Create_Time,
            this.Update_Time});
            this.DataGridViewUserApplication.ContextMenuStrip = this.ContextMenuStripFindUserApplication;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUserApplication.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewUserApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewUserApplication.GridColor = System.Drawing.Color.Peru;
            this.DataGridViewUserApplication.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewUserApplication.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewUserApplication.Name = "DataGridViewUserApplication";
            this.DataGridViewUserApplication.ReadOnly = true;
            this.DataGridViewUserApplication.RowHeadersVisible = false;
            this.DataGridViewUserApplication.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewUserApplication.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewUserApplication.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataGridViewUserApplication.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUserApplication.RowTemplate.Height = 30;
            this.DataGridViewUserApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUserApplication.Size = new System.Drawing.Size(1150, 690);
            this.DataGridViewUserApplication.TabIndex = 2;
            // 
            // Upload_ID
            // 
            this.Upload_ID.HeaderText = "申请ID";
            this.Upload_ID.MinimumWidth = 8;
            this.Upload_ID.Name = "Upload_ID";
            this.Upload_ID.ReadOnly = true;
            // 
            // User_ID
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.User_ID.HeaderText = "申请者ID";
            this.User_ID.MinimumWidth = 8;
            this.User_ID.Name = "User_ID";
            this.User_ID.ReadOnly = true;
            // 
            // Book_ID
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Book_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.Book_ID.HeaderText = "关联图书ID";
            this.Book_ID.MinimumWidth = 8;
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.ReadOnly = true;
            // 
            // Content
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Content.DefaultCellStyle = dataGridViewCellStyle4;
            this.Content.HeaderText = "申请内容";
            this.Content.MinimumWidth = 8;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            // 
            // Memo
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Memo.DefaultCellStyle = dataGridViewCellStyle5;
            this.Memo.HeaderText = "申请详情";
            this.Memo.MinimumWidth = 8;
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            // 
            // Status
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.DefaultCellStyle = dataGridViewCellStyle6;
            this.Status.HeaderText = "申请状态";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // IsManage
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IsManage.DefaultCellStyle = dataGridViewCellStyle7;
            this.IsManage.HeaderText = "是否处理";
            this.IsManage.MinimumWidth = 8;
            this.IsManage.Name = "IsManage";
            this.IsManage.ReadOnly = true;
            // 
            // Processor
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Processor.DefaultCellStyle = dataGridViewCellStyle8;
            this.Processor.HeaderText = "处理者";
            this.Processor.MinimumWidth = 8;
            this.Processor.Name = "Processor";
            this.Processor.ReadOnly = true;
            // 
            // Create_Time
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Create_Time.DefaultCellStyle = dataGridViewCellStyle9;
            this.Create_Time.HeaderText = "申请时间";
            this.Create_Time.MinimumWidth = 8;
            this.Create_Time.Name = "Create_Time";
            this.Create_Time.ReadOnly = true;
            // 
            // Update_Time
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Update_Time.DefaultCellStyle = dataGridViewCellStyle10;
            this.Update_Time.HeaderText = "处理时间";
            this.Update_Time.MinimumWidth = 8;
            this.Update_Time.Name = "Update_Time";
            this.Update_Time.ReadOnly = true;
            // 
            // ContextMenuStripFindUserApplication
            // 
            this.ContextMenuStripFindUserApplication.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ContextMenuStripFindUserApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReFind,
            this.ViewDetails});
            this.ContextMenuStripFindUserApplication.Name = "ContextMenuStripFindUser";
            this.ContextMenuStripFindUserApplication.Size = new System.Drawing.Size(241, 97);
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
            this.ViewDetails.Click += new System.EventHandler(this.ViewDetail);
            // 
            // FormUserApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1150, 690);
            this.Controls.Add(this.DataGridViewUserApplication);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUserApplication";
            this.Text = "FormUserApplication";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserApplication)).EndInit();
            this.ContextMenuStripFindUserApplication.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewUserApplication;
        public System.Windows.Forms.ContextMenuStrip ContextMenuStripFindUserApplication;
        public System.Windows.Forms.ToolStripMenuItem ReFind;
        public System.Windows.Forms.ToolStripMenuItem ViewDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Upload_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsManage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Processor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Create_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_Time;
    }
}