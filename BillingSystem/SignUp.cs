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
    public partial class SignUp : UserControl
    {

        private static SignUp SU_instance; // an instance variable of SignUp class type

        // creating an instance of SignUp class
        // so that we can access this instance from other class
        public static SignUp Instance
        {
            get
            {
                if (SU_instance == null)
                {
                    SU_instance = new SignUp();
                }
                return SU_instance;
            }
        }


        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        // login button on SignUp control will load the UserLogin on MainPanel
        private void LoginBtn_Click(object sender, EventArgs e)
        {
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

        // this click event will bring UserLogin control to front
        private void SUBackBtn_Click(object sender, EventArgs e)
        {
            billingSystemMain.Instance.MainPanel_Instance.Controls["UserLogin"].BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            billingSystemMain.Instance.MainPanel_Instance.Controls.Clear();
        }
    }
}
