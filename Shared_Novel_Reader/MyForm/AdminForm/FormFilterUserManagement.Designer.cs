namespace Shared_Novel_Reader.MyForm.AdminForm
{
    partial class FormFilterUserManagement
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
            this.LabelUserID = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelSex = new System.Windows.Forms.Label();
            this.BtnFindAll = new System.Windows.Forms.Button();
            this.BtnFindSome = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.TextUserID = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.ComboBoxSex = new System.Windows.Forms.ComboBox();
            this.LabelAccountExplain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelUserID
            // 
            this.LabelUserID.AutoSize = true;
            this.LabelUserID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserID.ForeColor = System.Drawing.Color.Black;
            this.LabelUserID.Location = new System.Drawing.Point(90, 74);
            this.LabelUserID.Name = "LabelUserID";
            this.LabelUserID.Size = new System.Drawing.Size(87, 28);
            this.LabelUserID.TabIndex = 4;
            this.LabelUserID.Text = "账号：";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.Black;
            this.LabelName.Location = new System.Drawing.Point(90, 207);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(87, 28);
            this.LabelName.TabIndex = 5;
            this.LabelName.Text = "昵称：";
            // 
            // LabelSex
            // 
            this.LabelSex.AutoSize = true;
            this.LabelSex.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSex.ForeColor = System.Drawing.Color.Black;
            this.LabelSex.Location = new System.Drawing.Point(90, 334);
            this.LabelSex.Name = "LabelSex";
            this.LabelSex.Size = new System.Drawing.Size(87, 28);
            this.LabelSex.TabIndex = 7;
            this.LabelSex.Text = "性别：";
            // 
            // BtnFindAll
            // 
            this.BtnFindAll.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindAll.Location = new System.Drawing.Point(609, 62);
            this.BtnFindAll.Name = "BtnFindAll";
            this.BtnFindAll.Size = new System.Drawing.Size(150, 40);
            this.BtnFindAll.TabIndex = 16;
            this.BtnFindAll.Text = "查询所有";
            this.BtnFindAll.UseVisualStyleBackColor = true;
            this.BtnFindAll.Click += new System.EventHandler(this.BtnFindAll_Click);
            // 
            // BtnFindSome
            // 
            this.BtnFindSome.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFindSome.Location = new System.Drawing.Point(609, 195);
            this.BtnFindSome.Name = "BtnFindSome";
            this.BtnFindSome.Size = new System.Drawing.Size(150, 40);
            this.BtnFindSome.TabIndex = 17;
            this.BtnFindSome.Text = "查询部分";
            this.BtnFindSome.UseVisualStyleBackColor = true;
            this.BtnFindSome.Click += new System.EventHandler(this.BtnFindSome_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(609, 322);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(150, 40);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "取消查询";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // TextUserID
            // 
            this.TextUserID.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUserID.Location = new System.Drawing.Point(240, 66);
            this.TextUserID.Name = "TextUserID";
            this.TextUserID.Size = new System.Drawing.Size(290, 36);
            this.TextUserID.TabIndex = 19;
            this.TextUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextUserID_KeyPress);
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName.Location = new System.Drawing.Point(240, 199);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(290, 36);
            this.TextName.TabIndex = 20;
            // 
            // ComboBoxSex
            // 
            this.ComboBoxSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxSex.AutoCompleteCustomSource.AddRange(new string[] {
            "无",
            "男",
            "女"});
            this.ComboBoxSex.DropDownHeight = 50;
            this.ComboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSex.DropDownWidth = 50;
            this.ComboBoxSex.FormattingEnabled = true;
            this.ComboBoxSex.IntegralHeight = false;
            this.ComboBoxSex.Items.AddRange(new object[] {
            "无",
            "男",
            "女"});
            this.ComboBoxSex.Location = new System.Drawing.Point(240, 336);
            this.ComboBoxSex.Name = "ComboBoxSex";
            this.ComboBoxSex.Size = new System.Drawing.Size(70, 26);
            this.ComboBoxSex.TabIndex = 22;
            // 
            // LabelAccountExplain
            // 
            this.LabelAccountExplain.AutoSize = true;
            this.LabelAccountExplain.ForeColor = System.Drawing.Color.Red;
            this.LabelAccountExplain.Location = new System.Drawing.Point(237, 117);
            this.LabelAccountExplain.Name = "LabelAccountExplain";
            this.LabelAccountExplain.Size = new System.Drawing.Size(179, 18);
            this.LabelAccountExplain.TabIndex = 24;
            this.LabelAccountExplain.Text = "请输入数字,最多十位";
            this.LabelAccountExplain.Visible = false;
            // 
            // FormFilterUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelAccountExplain);
            this.Controls.Add(this.ComboBoxSex);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.TextUserID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnFindSome);
            this.Controls.Add(this.BtnFindAll);
            this.Controls.Add(this.LabelSex);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelUserID);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFilterUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户列表查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUserID;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelSex;
        private System.Windows.Forms.Button BtnFindAll;
        private System.Windows.Forms.Button BtnFindSome;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LabelAccountExplain;
        public System.Windows.Forms.TextBox TextName;
        public System.Windows.Forms.TextBox TextUserID;
        public System.Windows.Forms.ComboBox ComboBoxSex;
    }
}