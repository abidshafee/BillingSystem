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
    public partial class UserLogin : UserControl
    {
        private static UserLogin UL_instance; // an instance variable of UserLogin class type

        // creating an instance of UserLogin class
        // so that we can access this instance from other class
        public static UserLogin Instance
        {
            get
            {
                if (UL_instance == null)
                {
                    UL_instance = new UserLogin();
                }
                return UL_instance;
            }
        }

        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void SinUpBtn_Click(object sender, EventArgs e)
        {
            if (!billingSystemMain.Instance.MainPanel_Instance.Controls.ContainsKey("SignUp"))
            {
                billingSystemMain.Instance.MainPanel_Instance.Controls.Add(SignUp.Instance);
                SignUp.Instance.Dock = DockStyle.Fill;
                SignUp.Instance.BringToFront();
                
            }
            else
            {
                SignUp.Instance.BringToFront();
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_MouseEnter(object sender, EventArgs e)
        {
           
        }
    }
}
