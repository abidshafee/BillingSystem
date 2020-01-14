using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class MainUserControl : UserControl
    {
        private static MainUserControl MUC_instance; // an instance variable of SignUp class type

        // creating an instance of SignUp class
        // so that we can access this instance from other class
        public static MainUserControl Instance
        {
            get
            {
                if (MUC_instance == null)
                {
                    MUC_instance = new MainUserControl();
                }
                return MUC_instance;
            }
        }

        public MainUserControl()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BgLoginBtn_Click(object sender, EventArgs e)
        {

        }

        private void MainUserControl_Load(object sender, EventArgs e)
        {

        }

        private void MainUCLoginBtn_Click(object sender, EventArgs e)
        {
            // loading one user control on main panel from another user control
            if (!billingSystemMain.Instance.MainPanel_Instance.Controls.Contains(UserLogin.Instance))
            {
                billingSystemMain.Instance.MainPanel_Instance.Controls.Add(UserLogin.Instance);
                UserLogin.Instance.Dock = DockStyle.Fill;
                UserLogin.Instance.BringToFront();
            }
            else
            {
                UserLogin.Instance.BringToFront();
            }
        }
    }
}
