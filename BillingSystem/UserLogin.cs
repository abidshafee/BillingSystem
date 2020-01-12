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
        private static UserLogin _instance;

        public static UserLogin instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserLogin();
                }
                return _instance;
            }
        }

        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
