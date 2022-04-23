namespace Shared_Novel_Reader.MyForm.AdminForm
{
    partial class FormFilterUserApplication
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
            this.LabelProviderIDExplain = new System.Windows.Forms.Label();
            this.ComboBoxFinish = new System.Windows.Forms.ComboBox();
            this.TextProcessor = new System.Windows.Forms.TextBox();
            this.TextProviderID = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnFindSome = new System.Windows.Forms.Button();
            this.BtnFindAll = new System.Windows.Forms.Button();
            this.LabelFinish = new System.Windows.Forms.Label();
            this.LabelProcessor = new System.Windows.Forms.Label();
            this.LabelProviderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelProviderIDExplain
            // 
            this.LabelProviderIDExplain.AutoSize = true;
            this.LabelProviderIDExplain.ForeColor = System.Drawing.Color.Red;
            this.LabelProviderIDExplain.Location = new System.Drawing.Point(215, 129);
            this.LabelProviderIDExplain.Name = "LabelProviderIDExplain";
            this.LabelProviderIDExplain.Size = new System.Drawing.Size(179, 18);
            this.LabelProviderIDExplain.TabIndex = 44;
            this.LabelProviderIDExplain.Text = "请输入数字,最多十位";
            this.LabelProviderIDExplain.Visible = false;
            // 
            // ComboBoxFinish
            // 
            this.ComboBoxFinish.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxFinish.AutoCompleteCustomSource.AddRange(new string[] {
            "无",
            "男",
            "女"});
            this.ComboBoxFinish.DropDownHeight = 50;
            this.ComboBoxFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFinish.DropDownWidth = 50;
            this.ComboBoxFinish.FormattingEnabled = true;
            this.ComboBoxFinish.IntegralHeight = false;
            this.ComboBoxFinish.Items.AddRange(new object[] {
            "无",
            "已处理",
            "未处理"});
            this.ComboBoxFinish.Location = new System.Drawing.Point(218, 348);
            this.ComboBoxFinish.Name = "ComboBoxFinish";
            this.ComboBoxFinish.Size = new System.Drawing.Size(70, 26);
            this.ComboBoxFinish.TabIndex = 43;
            // 
            // TextProcessor
            // 
            this.TextProcessor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProcessor.Location = new System.Drawing.Point(218, 211);
            this.TextProcessor.Name = "TextProcessor";
            this.TextProcessor.Size = new System.Drawing.Size(290, 36);
            this.TextProcessor.TabIndex = 42;
            // 
            // TextProviderID
            // 
            this.TextProviderID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextProviderID.Location = new System.Drawing.Point(218, 78);
            this.TextProviderID.Name = "TextProviderID";
            this.TextProviderID.Size = new System.Drawing.Size(290, 36);
            this.TextProviderID.TabIndex = 41;
            this.TextProviderID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextProviderID_KeyPress);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(587, 334);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 40);
            this.BtnCancel.TabIndex = 40;
            this.BtnCancel.Text = "取消查询";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnFindSome
            // 
            this.BtnFindSome.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindSome.Location = new System.Drawing.Point(587, 207);
            this.BtnFindSome.Name = "BtnFindSome";
            this.BtnFindSome.Size = new System.Drawing.Size(150, 40);
            this.BtnFindSome.TabIndex = 39;
            this.BtnFindSome.Text = "查询部分";
            this.BtnFindSome.UseVisualStyleBackColor = true;
            this.BtnFindSome.Click += new System.EventHandler(this.BtnFindSome_Click);
            // 
            // BtnFindAll
            // 
            this.BtnFindAll.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindAll.Location = new System.Drawing.Point(587, 74);
            this.BtnFindAll.Name = "BtnFindAll";
            this.BtnFindAll.Size = new System.Drawing.Size(150, 40);
            this.BtnFindAll.TabIndex = 38;
            this.BtnFindAll.Text = "查询所有";
            this.BtnFindAll.UseVisualStyleBackColor = true;
            this.BtnFindAll.Click += new System.EventHandler(this.BtnFindAll_Click);
            // 
            // LabelFinish
            // 
            this.LabelFinish.AutoSize = true;
            this.LabelFinish.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFinish.ForeColor = System.Drawing.Color.Black;
            this.LabelFinish.Location = new System.Drawing.Point(23, 346);
            this.LabelFinish.Name = "LabelFinish";
            this.LabelFinish.Size = new System.Drawing.Size(162, 28);
            this.LabelFinish.TabIndex = 37;
            this.LabelFinish.Text = "是否处理过：";
            // 
            // LabelProcessor
            // 
            this.LabelProcessor.AutoSize = true;
            this.LabelProcessor.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProcessor.ForeColor = System.Drawing.Color.Black;
            this.LabelProcessor.Location = new System.Drawing.Point(44, 219);
            this.LabelProcessor.Name = "LabelProcessor";
            this.LabelProcessor.Size = new System.Drawing.Size(112, 28);
            this.LabelProcessor.TabIndex = 36;
            this.LabelProcessor.Text = "处理者：";
            // 
            // LabelProviderID
            // 
            this.LabelProviderID.AutoSize = true;
            this.LabelProviderID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProviderID.ForeColor = System.Drawing.Color.Black;
            this.LabelProviderID.Location = new System.Drawing.Point(44, 86);
            this.LabelProviderID.Name = "LabelProviderID";
            this.LabelProviderID.Size = new System.Drawing.Size(141, 28);
            this.LabelProviderID.TabIndex = 35;
            this.LabelProviderID.Text = "反馈者ID：";
            // 
            // FormFilterUserApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelProviderIDExplain);
            this.Controls.Add(this.ComboBoxFinish);
            this.Controls.Add(this.TextProcessor);
            this.Controls.Add(this.TextProviderID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnFindSome);
            this.Controls.Add(this.BtnFindAll);
            this.Controls.Add(this.LabelFinish);
            this.Controls.Add(this.LabelProcessor);
            this.Controls.Add(this.LabelProviderID);
            this.Name = "FormFilterUserApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "用户申请查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelProviderIDExplain;
        public System.Windows.Forms.ComboBox ComboBoxFinish;
        public System.Windows.Forms.TextBox TextProcessor;
        public System.Windows.Forms.TextBox TextProviderID;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnFindSome;
        private System.Windows.Forms.Button BtnFindAll;
        private System.Windows.Forms.Label LabelFinish;
        private System.Windows.Forms.Label LabelProcessor;
        private System.Windows.Forms.Label LabelProviderID;
    }
}