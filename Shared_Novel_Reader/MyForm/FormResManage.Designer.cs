namespace Shared_Novel_Reader.MyForm
{
    partial class FormResManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridViewLocal = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewLocal
            // 
            this.DataGridViewLocal.AllowUserToAddRows = false;
            this.DataGridViewLocal.AllowUserToDeleteRows = false;
            this.DataGridViewLocal.AllowUserToResizeColumns = false;
            this.DataGridViewLocal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridViewLocal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridViewLocal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGridViewLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLocal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.LinkNum});
            this.DataGridViewLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewLocal.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewLocal.Margin = new System.Windows.Forms.Padding(0);
            this.DataGridViewLocal.Name = "DataGridViewLocal";
            this.DataGridViewLocal.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridViewLocal.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewLocal.RowHeadersVisible = false;
            this.DataGridViewLocal.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DataGridViewLocal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewLocal.RowTemplate.Height = 30;
            this.DataGridViewLocal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewLocal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewLocal.Size = new System.Drawing.Size(1150, 740);
            this.DataGridViewLocal.TabIndex = 2;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookName.DefaultCellStyle = dataGridViewCellStyle1;
            this.BookName.HeaderText = "书名";
            this.BookName.MinimumWidth = 8;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BookName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LinkNum
            // 
            this.LinkNum.HeaderText = "保存文件名";
            this.LinkNum.MinimumWidth = 8;
            this.LinkNum.Name = "LinkNum";
            this.LinkNum.ReadOnly = true;
            this.LinkNum.Visible = false;
            this.LinkNum.Width = 8;
            // 
            // FormResManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.DataGridViewLocal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormResManage";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkNum;
    }
}