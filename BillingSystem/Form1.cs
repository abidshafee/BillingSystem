using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BillingSystem
{
    public partial class billingSystemMain : Form
    {

        static billingSystemMain BS_Obj;

        public static billingSystemMain Instance
        {
            get
            {
                if(BS_Obj == null)
                {
                    BS_Obj = new billingSystemMain();
                }return BS_Obj;
            }
        }

        // creating MainPanel instance so that it can be accessed from other class
       public Panel MainPanelInstance
        {
            get {return MainPanel;}
            set {MainPanel = value;}
        }

        // Login Validation
        private Control currentControl;

        public void ChangeControl(UserLogin login)
        {
            if(login == null)
            {
                throw new ArgumentNullException("login");
            }
            if (currentControl != null)
            {
                Controls.Remove(currentControl);
            }
            Controls.Add(UserLogin.Instance);
            currentControl = login;
            

        } // End Login Validation
        
        /// </summary>

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
            hiddenPanelWidth = 180;
            hiddenPan = true;
            expandPanel.Width = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BS_Obj = this;
            
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
                expandPanel.Width += 20;
                if (expandPanel.Width >= hiddenPanelWidth)
                {
                    SPan_timer.Stop();
                    hiddenPan = false;
                    this.Refresh();
                }
            }
            else
            {
                expandPanel.Width = 0;
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
        }// end of userBtn_Click

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

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            //null
        }
        /*
        private void BgLoginBtn_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(Inventory.Instance))
            {
                MainPanel.Controls.Add(Inventory.Instance);
                Inventory.Instance.Dock = DockStyle.Fill;
                Inventory.Instance.BringToFront();
            }
            else
            {
                Inventory.Instance.BringToFront();
            }
        }
        */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(Inventory.Instance))
            {
                MainPanel.Controls.Add(Inventory.Instance);
                Inventory.Instance.Dock = DockStyle.Fill;
                Inventory.Instance.BringToFront();
                SPan_timer.Start();
            }
            else
            {
                Inventory.Instance.BringToFront();
                SPan_timer.Start();
            }

        }

        private void transactionBtn_Click(object sender, EventArgs e)
        {
            if (!MainPanel.Controls.Contains(Transaction.Instance))
            {
                MainPanel.Controls.Add(Transaction.Instance);
                Transaction.Instance.Dock = DockStyle.Fill;
                Transaction.Instance.BringToFront();
                SPan_timer.Start();
            }
            else
            {
                Transaction.Instance.BringToFront();
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

        /*
         * //Mouse down event for capturing mouse hove event
                 private void panel1_MouseDown(object sender, MouseEventArgs e)
                 {
                     if (e.Button == MouseButtons.Left)
                     {
                         ReleaseCapture();
                         SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                     }
                 }
         */

        // activate UserControls upon login Success

        /*
                       public class MainForm: Form {
                       //...
                       private Control currentControl;

                           public void ChangeControl(Control newControl) {
                               if(newControl == null) {
                                   throw new ArgumentNullException("newControl");
                               }
                               if(currentControl != null) {
                                   Me.Controls.Remove(currentControl);
                               }
                               Me.Controls.Add(newControl);
                               currentControl = newControl;
                           }

                       public void ShowHomePage() {
                           // You could use a previously created control
                           this.ChangeControl(this.homePageControl);
                           // Or create a new one.
                           // this.ChangeControl(new HomePageControl());
                           }
                        }// End of Main Form

                        public class LoginControl: Control {
                           private void LoginButton_Click(Object sender, EventArgs e) {
                               if(DoLogin(...)) {
                                   ((MainForm)this.Parent).ShowHomePage()
                               }
                               else {
                                   // Show some error message
                               }
                           }
                        }
                // Personally I prefer to comunicate to MainForm only via events, 
                // and never one control to another:

                        public class MainForm: Form {
                           private Control currentControl;

                           public void ChangeControl(Control newControl) {
                               if(newControl == null) {
                                   throw new ArgumentNullException("newControl");
                               }
                               if(currentControl != null) {
                                   Me.Controls.Remove(currentControl);
                                   // Optionally you could dispose old control
                                   // currentControl.Dispose();
                               }         
                               Me.Controls.Add(newControl);
                               currentControl = newControl;
                           }

                           // Optional generic method
                           public void ChangeControl<TControl>() where TControl: Control, new() {
                               this.Changecontrol(new TControl());
                           }

                           private void OnLoggedIn(Object sender, LoggedInEventArgs e) {
                              this.ChangeControl<HomePageControl>();
                           }

                           private Login_ParentChanged(Object sender, EventArgs e) {
                               var control = sender as LoginControl;
                               if(control != null && control.Parent == null) {
                                   control.LoggedIn -= OnLoggedIn;
                                   control.ParentChanged -= Login_ParentChanged
                               }
                           }

                           private void LogOut_Click(Object sender, EventArgs e) {
                              var control = new LoginControl();
                              control.LoggedIn += OnLoggedIn;
                              this.ChangeControl(control);
                              control.ParentChanged += Login_ParentChanged
                           }
                        }

                        public class LoginControl: Control {
                           public event EventHandler<LoggedInEventArgs> LoggedIn;

                           private void LoginButton_Click(Object sender, EventArgs e) {
                               if(DoLogin(...)) {
                                   if(LoggedIn != null) {
                                      LoggedIn(this, new LoggedInEventArgs(...))
                                   }
                                   else {
                                      // Show some error message
                                   }
                               }
                           }
                        }

        */
    }
}
