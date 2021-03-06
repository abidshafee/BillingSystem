﻿namespace BillingSystem
{
    partial class billingSystemMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billingSystemMain));
            this.logoPanel = new System.Windows.Forms.Panel();
            this.humMenuLeftBtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userBtn = new System.Windows.Forms.Button();
            this.inventoryBtn = new System.Windows.Forms.Button();
            this.categoryBtn = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.transactionBtn = new System.Windows.Forms.Button();
            this.expandPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SPan_timer = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.mainUserControl1 = new BillingSystem.MainUserControl();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.expandPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.logoPanel.Controls.Add(this.humMenuLeftBtn);
            this.logoPanel.Controls.Add(this.pictureBox5);
            this.logoPanel.Controls.Add(this.pictureBox4);
            this.logoPanel.Controls.Add(this.pictureBox3);
            this.logoPanel.Controls.Add(this.pictureBox2);
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(45, 561);
            this.logoPanel.TabIndex = 7;
            // 
            // humMenuLeftBtn
            // 
            this.humMenuLeftBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("humMenuLeftBtn.BackgroundImage")));
            this.humMenuLeftBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.humMenuLeftBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.humMenuLeftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.humMenuLeftBtn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.humMenuLeftBtn.Location = new System.Drawing.Point(0, 0);
            this.humMenuLeftBtn.Name = "humMenuLeftBtn";
            this.humMenuLeftBtn.Size = new System.Drawing.Size(45, 42);
            this.humMenuLeftBtn.TabIndex = 7;
            this.humMenuLeftBtn.UseVisualStyleBackColor = true;
            this.humMenuLeftBtn.Click += new System.EventHandler(this.humMenuLeftBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::BillingSystem.Properties.Resources.icons8_transaction_list_36;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox5.Location = new System.Drawing.Point(-2, 397);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.humMenuLeftBtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::BillingSystem.Properties.Resources.icons8_in_inventory_36;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(-2, 344);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.humMenuLeftBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::BillingSystem.Properties.Resources.icons8_basket_36;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 289);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.humMenuLeftBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::BillingSystem.Properties.Resources.icons8_opened_folder_36;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.humMenuLeftBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BillingSystem.Properties.Resources.icons8_male_user_36;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.humMenuLeftBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userBtn.FlatAppearance.BorderSize = 0;
            this.userBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userBtn.Location = new System.Drawing.Point(0, 185);
            this.userBtn.Margin = new System.Windows.Forms.Padding(0);
            this.userBtn.Name = "userBtn";
            this.userBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.userBtn.Size = new System.Drawing.Size(205, 50);
            this.userBtn.TabIndex = 2;
            this.userBtn.Text = "USER LOGIN";
            this.userBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // inventoryBtn
            // 
            this.inventoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventoryBtn.FlatAppearance.BorderSize = 0;
            this.inventoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.inventoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inventoryBtn.Location = new System.Drawing.Point(0, 344);
            this.inventoryBtn.Name = "inventoryBtn";
            this.inventoryBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.inventoryBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inventoryBtn.Size = new System.Drawing.Size(205, 50);
            this.inventoryBtn.TabIndex = 5;
            this.inventoryBtn.Text = "INVENTORY";
            this.inventoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryBtn.UseVisualStyleBackColor = true;
            this.inventoryBtn.Click += new System.EventHandler(this.inventoryBtn_Click);
            // 
            // categoryBtn
            // 
            this.categoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoryBtn.FlatAppearance.BorderSize = 0;
            this.categoryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.categoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryBtn.Location = new System.Drawing.Point(0, 238);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.categoryBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryBtn.Size = new System.Drawing.Size(205, 50);
            this.categoryBtn.TabIndex = 4;
            this.categoryBtn.Text = "CATEGORY";
            this.categoryBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoryBtn.UseVisualStyleBackColor = true;
            this.categoryBtn.Click += new System.EventHandler(this.categoryBtn_Click);
            // 
            // productsBtn
            // 
            this.productsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productsBtn.FlatAppearance.BorderSize = 0;
            this.productsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.productsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productsBtn.Location = new System.Drawing.Point(0, 291);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.productsBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productsBtn.Size = new System.Drawing.Size(205, 50);
            this.productsBtn.TabIndex = 3;
            this.productsBtn.Text = "PRODUCTS";
            this.productsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.productsBtn.UseVisualStyleBackColor = true;
            this.productsBtn.Click += new System.EventHandler(this.productsBtn_Click);
            // 
            // transactionBtn
            // 
            this.transactionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.transactionBtn.FlatAppearance.BorderSize = 0;
            this.transactionBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.transactionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transactionBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionBtn.Location = new System.Drawing.Point(0, 397);
            this.transactionBtn.Name = "transactionBtn";
            this.transactionBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.transactionBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transactionBtn.Size = new System.Drawing.Size(205, 50);
            this.transactionBtn.TabIndex = 6;
            this.transactionBtn.Text = "TRANSACTION";
            this.transactionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionBtn.UseVisualStyleBackColor = true;
            this.transactionBtn.Click += new System.EventHandler(this.transactionBtn_Click);
            // 
            // expandPanel
            // 
            this.expandPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.expandPanel.Controls.Add(this.label1);
            this.expandPanel.Controls.Add(this.linkLabel1);
            this.expandPanel.Controls.Add(this.transactionBtn);
            this.expandPanel.Controls.Add(this.productsBtn);
            this.expandPanel.Controls.Add(this.categoryBtn);
            this.expandPanel.Controls.Add(this.userBtn);
            this.expandPanel.Controls.Add(this.inventoryBtn);
            this.expandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandPanel.Location = new System.Drawing.Point(45, 0);
            this.expandPanel.Name = "expandPanel";
            this.expandPanel.Size = new System.Drawing.Size(180, 561);
            this.expandPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Developed By";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Location = new System.Drawing.Point(24, 528);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(102, 14);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Md. Shafekul Abid";
            // 
            // SPan_timer
            // 
            this.SPan_timer.Interval = 20;
            this.SPan_timer.Tick += new System.EventHandler(this.SPan_timer_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Silver;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.mainUserControl1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.Menu;
            this.MainPanel.Location = new System.Drawing.Point(45, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(963, 561);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // mainUserControl1
            // 
            this.mainUserControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainUserControl1.BackgroundImage")));
            this.mainUserControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainUserControl1.Location = new System.Drawing.Point(0, 0);
            this.mainUserControl1.Name = "mainUserControl1";
            this.mainUserControl1.Size = new System.Drawing.Size(963, 561);
            this.mainUserControl1.TabIndex = 0;
            this.mainUserControl1.Load += new System.EventHandler(this.mainUserControl1_Load);
            // 
            // billingSystemMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.expandPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.logoPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "billingSystemMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillingSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.expandPanel.ResumeLayout(false);
            this.expandPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button transactionBtn;
        private System.Windows.Forms.Button inventoryBtn;
        private System.Windows.Forms.Button categoryBtn;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button humMenuLeftBtn;
        private System.Windows.Forms.Panel expandPanel;
        private System.Windows.Forms.Timer SPan_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private MainUserControl mainUserControl1;
    }
}

