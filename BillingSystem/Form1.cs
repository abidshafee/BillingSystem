﻿using System;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class billingSystemMain : Form
    {

        /* public const int WM_NCLBUTTONDOWN = 0xA1;
         public const int HT_CAPTION = 0x2;

         [DllImportAttribute("user32.dll")]
         public static extern int SendMessage(IntPtr hWnd,
                          int Msg, intwParam, int lParam);
         [DllImportAttribute("user32.dll")]
         public static extern bool ReleaseCapture();
         */
        int hiddenPanelWidth;
        bool hiddenPan;

        public billingSystemMain()
        {
            InitializeComponent();
            hiddenPanelWidth = 205;
            hiddenPan = true;
            expandPanel.Width = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        // calling timer in the button, bcoz timer holds the requited -
        // Animation for slider animation
        private void humMenuLeftBtn_Click(object sender, EventArgs e)
        {
            SPan_timer.Start();
        }
        // timer containing anim code for sliding manu
        private void SPan_timer_Tick(object sender, EventArgs e)
        {
            if (hiddenPan)
            {
                expandPanel.Width += 25;
                if (expandPanel.Width >= hiddenPanelWidth)
                {
                    SPan_timer.Stop();
                    hiddenPan = false;
                    this.Refresh();
                }
            }
            else
            {
                expandPanel.Width -= 25;
                if (expandPanel.Width <= 0)
                {
                    SPan_timer.Stop();
                    hiddenPan = true;
                    this.Refresh();
                }
            }
        }// end_of sPan_timer
        
        // this will bring userlogin front of the Main Panel
        private void userBtn_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(UserLogin.Instance))
            {
                MainPanel.Controls.Add(UserLogin.Instance);
                UserLogin.Instance.Dock = DockStyle.Fill;
                UserLogin.Instance.BringToFront();
                SPan_timer.Start();
            }
            else
            {
                UserLogin.Instance.BringToFront();
                SPan_timer.Start();
            }
        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(Category.Instance))
            {
                MainPanel.Controls.Add(Category.Instance);
                Category.Instance.Dock = DockStyle.Fill;
                Category.Instance.BringToFront();
                SPan_timer.Start();
            }
            else
            {
                Category.Instance.BringToFront();
                SPan_timer.Start();
            }
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(Products.Instance))
            {
                MainPanel.Controls.Add(Products.Instance);
                Products.Instance.Dock = DockStyle.Fill;
                Products.Instance.BringToFront();
                SPan_timer.Start();
            }
            else
            {
                Products.Instance.BringToFront();
                SPan_timer.Start();
            }
        }

        // private void pictureBox1_Click(object sender, EventArgs e)
        //{
        //this.Close();
        //}

        // private void closeBtn_Click(object sender, EventArgs e)
        // {
        //     Environment.Exit(0);
        // }

        // private void minBtn_Click(object sender, EventArgs e)
        // {
        //    this.WindowState = FormWindowState.Minimized;
        // }
        //Mouse down event for capturing mouse hove event
        /*
         private void panel1_MouseDown(object sender, MouseEventArgs e)
         {
             if (e.Button == MouseButtons.Left)
             {
                 ReleaseCapture();
                 SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
             }
         }
         */
    }
}
