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
            this.PanelNote = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // PanelNote
            // 
            this.PanelNote.BackColor = System.Drawing.Color.White;
            this.PanelNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNote.Location = new System.Drawing.Point(0, 0);
            this.PanelNote.Name = "PanelNote";
            this.PanelNote.Size = new System.Drawing.Size(1150, 740);
            this.PanelNote.TabIndex = 0;
            // 
            // FormBookPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1150, 740);
            this.Controls.Add(this.PanelNote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBookPlatform";
            this.Text = "FormBookPlatform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelNote;
    }
}