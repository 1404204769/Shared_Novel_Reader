namespace Shared_Novel_Reader.MyForm.ToolForm
{
    partial class FormProcessbar
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.LabelFZ = new System.Windows.Forms.Label();
            this.LabelFM = new System.Windows.Forms.Label();
            this.LabelX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 56);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(454, 76);
            this.ProgressBar.TabIndex = 0;
            // 
            // LabelFZ
            // 
            this.LabelFZ.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFZ.Location = new System.Drawing.Point(12, 9);
            this.LabelFZ.Name = "LabelFZ";
            this.LabelFZ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelFZ.Size = new System.Drawing.Size(200, 44);
            this.LabelFZ.TabIndex = 1;
            this.LabelFZ.Text = "分子";
            // 
            // LabelFM
            // 
            this.LabelFM.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFM.Location = new System.Drawing.Point(264, 9);
            this.LabelFM.Name = "LabelFM";
            this.LabelFM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelFM.Size = new System.Drawing.Size(202, 44);
            this.LabelFM.TabIndex = 2;
            this.LabelFM.Text = "分母";
            // 
            // LabelX
            // 
            this.LabelX.AutoSize = true;
            this.LabelX.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelX.Location = new System.Drawing.Point(218, 9);
            this.LabelX.Name = "LabelX";
            this.LabelX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelX.Size = new System.Drawing.Size(40, 42);
            this.LabelX.TabIndex = 3;
            this.LabelX.Text = "/";
            // 
            // FormProcessbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 144);
            this.Controls.Add(this.LabelX);
            this.Controls.Add(this.LabelFM);
            this.Controls.Add(this.LabelFZ);
            this.Controls.Add(this.ProgressBar);
            this.MaximizeBox = false;
            this.Name = "FormProcessbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProcessbar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelX;
        public System.Windows.Forms.ProgressBar ProgressBar;
        public System.Windows.Forms.Label LabelFZ;
        public System.Windows.Forms.Label LabelFM;
    }
}