namespace Shared_Novel_Reader.MyForm.ToolForm
{
    partial class PageControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelBack = new System.Windows.Forms.Label();
            this.LabelNext = new System.Windows.Forms.Label();
            this.LabelSum = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelBack
            // 
            this.LabelBack.Image = global::Shared_Novel_Reader.Properties.Resources.back;
            this.LabelBack.Location = new System.Drawing.Point(300, 0);
            this.LabelBack.Name = "LabelBack";
            this.LabelBack.Size = new System.Drawing.Size(50, 50);
            this.LabelBack.TabIndex = 0;
            // 
            // LabelNext
            // 
            this.LabelNext.Image = global::Shared_Novel_Reader.Properties.Resources.next;
            this.LabelNext.Location = new System.Drawing.Point(600, 0);
            this.LabelNext.Name = "LabelNext";
            this.LabelNext.Size = new System.Drawing.Size(50, 50);
            this.LabelNext.TabIndex = 1;
            // 
            // LabelSum
            // 
            this.LabelSum.AutoSize = true;
            this.LabelSum.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSum.Location = new System.Drawing.Point(489, 18);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(52, 21);
            this.LabelSum.TabIndex = 3;
            this.LabelSum.Text = "Sum";
            this.LabelSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(462, 18);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(21, 21);
            this.Label.TabIndex = 4;
            this.Label.Text = "/";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(381, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 29);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "123";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.LabelSum);
            this.Controls.Add(this.LabelNext);
            this.Controls.Add(this.LabelBack);
            this.Name = "PageControl";
            this.Size = new System.Drawing.Size(950, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBack;
        private System.Windows.Forms.Label LabelNext;
        private System.Windows.Forms.Label LabelSum;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox textBox1;
    }
}
