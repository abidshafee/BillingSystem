namespace BillingSystem
{
    partial class Category
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ct_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ct_label1
            // 
            this.Ct_label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ct_label1.AutoSize = true;
            this.Ct_label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ct_label1.ForeColor = System.Drawing.Color.Black;
            this.Ct_label1.Location = new System.Drawing.Point(400, 12);
            this.Ct_label1.Name = "Ct_label1";
            this.Ct_label1.Size = new System.Drawing.Size(93, 19);
            this.Ct_label1.TabIndex = 0;
            this.Ct_label1.Text = "CATEGORY";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ct_label1);
            this.Name = "Category";
            this.Size = new System.Drawing.Size(963, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ct_label1;
    }
}
