namespace Shared_Novel_Reader.MyForm.ResourceForm
{
    partial class FormNoteDetail
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
            this.Panel = new System.Windows.Forms.Panel();
            this.PictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.PictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.LabelJoin = new System.Windows.Forms.Label();
            this.labelViewBook = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.PanelComment = new System.Windows.Forms.Panel();
            this.TextComment = new System.Windows.Forms.TextBox();
            this.ButtonReport = new System.Windows.Forms.Button();
            this.LabelCancelReply = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFloorValue = new System.Windows.Forms.Label();
            this.FlowLayoutPanelNoteComment = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutPanelReply = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxReturn)).BeginInit();
            this.PanelComment.SuspendLayout();
            this.FlowLayoutPanelReply.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.DimGray;
            this.Panel.Controls.Add(this.PictureBoxRefresh);
            this.Panel.Controls.Add(this.PictureBoxReturn);
            this.Panel.Controls.Add(this.LabelJoin);
            this.Panel.Controls.Add(this.labelViewBook);
            this.Panel.Controls.Add(this.labelContent);
            this.Panel.Controls.Add(this.labelTitle);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Margin = new System.Windows.Forms.Padding(0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(1150, 200);
            this.Panel.TabIndex = 0;
            // 
            // PictureBoxRefresh
            // 
            this.PictureBoxRefresh.BackColor = System.Drawing.Color.White;
            this.PictureBoxRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxRefresh.Image = global::Shared_Novel_Reader.Properties.Resources.refresh;
            this.PictureBoxRefresh.Location = new System.Drawing.Point(1105, 28);
            this.PictureBoxRefresh.Name = "PictureBoxRefresh";
            this.PictureBoxRefresh.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxRefresh.TabIndex = 8;
            this.PictureBoxRefresh.TabStop = false;
            this.PictureBoxRefresh.Click += new System.EventHandler(this.PictureBoxRefresh_Click);
            // 
            // PictureBoxReturn
            // 
            this.PictureBoxReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxReturn.Image = global::Shared_Novel_Reader.Properties.Resources.arrow_left_circle;
            this.PictureBoxReturn.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxReturn.Name = "PictureBoxReturn";
            this.PictureBoxReturn.Size = new System.Drawing.Size(44, 40);
            this.PictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxReturn.TabIndex = 7;
            this.PictureBoxReturn.TabStop = false;
            this.PictureBoxReturn.Click += new System.EventHandler(this.PictureBoxReturn_Click);
            // 
            // LabelJoin
            // 
            this.LabelJoin.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.LabelJoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelJoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelJoin.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabelJoin.ForeColor = System.Drawing.Color.Black;
            this.LabelJoin.Location = new System.Drawing.Point(984, 28);
            this.LabelJoin.Name = "LabelJoin";
            this.LabelJoin.Size = new System.Drawing.Size(100, 30);
            this.LabelJoin.TabIndex = 6;
            this.LabelJoin.Text = "加入书架";
            this.LabelJoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelJoin.Click += new System.EventHandler(this.LabelJoin_Click);
            // 
            // labelViewBook
            // 
            this.labelViewBook.BackColor = System.Drawing.Color.PeachPuff;
            this.labelViewBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelViewBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelViewBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelViewBook.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelViewBook.ForeColor = System.Drawing.Color.Black;
            this.labelViewBook.Location = new System.Drawing.Point(864, 28);
            this.labelViewBook.Name = "labelViewBook";
            this.labelViewBook.Size = new System.Drawing.Size(100, 30);
            this.labelViewBook.TabIndex = 5;
            this.labelViewBook.Text = "在线阅读";
            this.labelViewBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelViewBook.Click += new System.EventHandler(this.labelViewBook_Click);
            // 
            // labelContent
            // 
            this.labelContent.BackColor = System.Drawing.Color.White;
            this.labelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelContent.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.ForeColor = System.Drawing.Color.Black;
            this.labelContent.Location = new System.Drawing.Point(22, 83);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(1101, 104);
            this.labelContent.TabIndex = 4;
            this.labelContent.Text = "帖子内容";
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Bookman Old Style", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(73, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(451, 32);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "帖子标题";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelComment
            // 
            this.PanelComment.Controls.Add(this.TextComment);
            this.PanelComment.Controls.Add(this.ButtonReport);
            this.PanelComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelComment.Location = new System.Drawing.Point(0, 688);
            this.PanelComment.Name = "PanelComment";
            this.PanelComment.Size = new System.Drawing.Size(1150, 52);
            this.PanelComment.TabIndex = 2;
            // 
            // TextComment
            // 
            this.TextComment.BackColor = System.Drawing.SystemColors.Window;
            this.TextComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextComment.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextComment.Location = new System.Drawing.Point(0, 0);
            this.TextComment.Multiline = true;
            this.TextComment.Name = "TextComment";
            this.TextComment.Size = new System.Drawing.Size(1017, 52);
            this.TextComment.TabIndex = 0;
            // 
            // ButtonReport
            // 
            this.ButtonReport.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonReport.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReport.Location = new System.Drawing.Point(1017, 0);
            this.ButtonReport.Name = "ButtonReport";
            this.ButtonReport.Size = new System.Drawing.Size(133, 52);
            this.ButtonReport.TabIndex = 1;
            this.ButtonReport.Text = "发表评论";
            this.ButtonReport.UseVisualStyleBackColor = false;
            this.ButtonReport.Click += new System.EventHandler(this.ButtonReport_Click);
            // 
            // LabelCancelReply
            // 
            this.LabelCancelReply.AutoSize = true;
            this.LabelCancelReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelCancelReply.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.LabelCancelReply.Location = new System.Drawing.Point(229, 0);
            this.LabelCancelReply.Margin = new System.Windows.Forms.Padding(0);
            this.LabelCancelReply.Name = "LabelCancelReply";
            this.LabelCancelReply.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelCancelReply.Size = new System.Drawing.Size(86, 21);
            this.LabelCancelReply.TabIndex = 0;
            this.LabelCancelReply.Text = "取消回复";
            this.LabelCancelReply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelCancelReply.Click += new System.EventHandler(this.LabelCancelReply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "正在回复";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelFloorValue
            // 
            this.LabelFloorValue.AutoSize = true;
            this.LabelFloorValue.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.LabelFloorValue.Location = new System.Drawing.Point(86, 0);
            this.LabelFloorValue.Margin = new System.Windows.Forms.Padding(0);
            this.LabelFloorValue.Name = "LabelFloorValue";
            this.LabelFloorValue.Size = new System.Drawing.Size(24, 21);
            this.LabelFloorValue.TabIndex = 2;
            this.LabelFloorValue.Text = "X";
            this.LabelFloorValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlowLayoutPanelNoteComment
            // 
            this.FlowLayoutPanelNoteComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanelNoteComment.AutoScroll = true;
            this.FlowLayoutPanelNoteComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanelNoteComment.BackColor = System.Drawing.Color.Gainsboro;
            this.FlowLayoutPanelNoteComment.Location = new System.Drawing.Point(0, 200);
            this.FlowLayoutPanelNoteComment.Margin = new System.Windows.Forms.Padding(0);
            this.FlowLayoutPanelNoteComment.Name = "FlowLayoutPanelNoteComment";
            this.FlowLayoutPanelNoteComment.Size = new System.Drawing.Size(1150, 488);
            this.FlowLayoutPanelNoteComment.TabIndex = 1;
            // 
            // FlowLayoutPanelReply
            // 
            this.FlowLayoutPanelReply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlowLayoutPanelReply.Controls.Add(this.label1);
            this.FlowLayoutPanelReply.Controls.Add(this.LabelFloorValue);
            this.FlowLayoutPanelReply.Controls.Add(this.label3);
            this.FlowLayoutPanelReply.Controls.Add(this.LabelCancelReply);
            this.FlowLayoutPanelReply.Location = new System.Drawing.Point(2, 659);
            this.FlowLayoutPanelReply.Name = "FlowLayoutPanelReply";
            this.FlowLayoutPanelReply.Size = new System.Drawing.Size(1146, 30);
            this.FlowLayoutPanelReply.TabIndex = 4;
            this.FlowLayoutPanelReply.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(110, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "楼               ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormNoteDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.FlowLayoutPanelReply);
            this.Controls.Add(this.FlowLayoutPanelNoteComment);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.PanelComment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNoteDetail";
            this.Text = "FormNoteDetail";
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxReturn)).EndInit();
            this.PanelComment.ResumeLayout(false);
            this.PanelComment.PerformLayout();
            this.FlowLayoutPanelReply.ResumeLayout(false);
            this.FlowLayoutPanelReply.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label labelViewBook;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label LabelJoin;
        private System.Windows.Forms.PictureBox PictureBoxReturn;
        private System.Windows.Forms.Panel PanelComment;
        private System.Windows.Forms.Button ButtonReport;
        private System.Windows.Forms.TextBox TextComment;
        private System.Windows.Forms.PictureBox PictureBoxRefresh;
        private System.Windows.Forms.Label LabelCancelReply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelNoteComment;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.FlowLayoutPanel FlowLayoutPanelReply;
        public System.Windows.Forms.Label LabelFloorValue;
    }
}