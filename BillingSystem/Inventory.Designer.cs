namespace BillingSystem
{
    partial class Inventory
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
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryLabel.ForeColor = System.Drawing.Color.Black;
            this.InventoryLabel.Location = new System.Drawing.Point(400, 12);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(95, 19);
            this.InventoryLabel.TabIndex = 0;
            this.InventoryLabel.Text = "INVENTORY";
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InventoryLabel);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(963, 561);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InventoryLabel;
    }
}
