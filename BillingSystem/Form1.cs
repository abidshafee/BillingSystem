using System;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class billingSystemMain : Form
    {

        /* public const int WM_NCLBUTTONDOWN = 0xA1;
         public const int HT_CAPTION = 0x2;

         [DllImportAttribute("user32.dll")]
         public static extern int SendMessage(IntPtr hWnd,
                          int Msg, int wParam, int lParam);
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
            //expandPanel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void humMenuLeftBtn_Click(object sender, EventArgs e)
        {
            sPan_timer.Start();
        }

        private void sPan_timer_Tick(object sender, EventArgs e)
        {
            if (hiddenPan)
            {
                expandPanel.Width = 205;
                if (expandPanel.Width >= hiddenPanelWidth)
                {
                    sPan_timer.Stop();
                    hiddenPan = false;
                    this.Refresh();
                }
            }
            else
            {
                expandPanel.Width = 0;
                if (expandPanel.Width <= 0)
                {
                    sPan_timer.Stop();
                    hiddenPan = true;
                    this.Refresh();
                }
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
