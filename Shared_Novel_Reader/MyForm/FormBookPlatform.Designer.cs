namespace Shared_Novel_Reader.MyForm
{
    partial class FormBookPlatform
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
            this.LabelShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelShow
            // 
            this.LabelShow.AutoSize = true;
            this.LabelShow.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelShow.ForeColor = System.Drawing.Color.Black;
            this.LabelShow.Location = new System.Drawing.Point(348, 333);
            this.LabelShow.Name = "LabelShow";
            this.LabelShow.Size = new System.Drawing.Size(416, 56);
            this.LabelShow.TabIndex = 3;
            this.LabelShow.Text = "这是图书平台界面";
            // 
            // FormBookPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.LabelShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookPlatform";
            this.Text = "FormBookPlatform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelShow;
    }
}