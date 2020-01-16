using BillingSystem.OtherClasses;
using System;
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

        // instanciating gettersetter and data access class
        GetterSetterForLoginForm lgin = new GetterSetterForLoginForm();
        DataAccessForLogin DAlgin = new DataAccessForLogin();

        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        // loading Signup user control in the mainpanel
        private void SinUpBtn_Click(object sender, EventArgs e)
        {
            if (!billingSystemMain.Instance.MainPanelInstance.Controls.ContainsKey("SignUp"))
            {
                billingSystemMain.Instance.MainPanelInstance.Controls.Add(SignUp.Instance);
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

        // loding home or mainUserControl
        private void home_Click(object sender, EventArgs e)
        {
            if (!billingSystemMain.Instance.MainPanelInstance.Controls.Contains(MainUserControl.Instance))
            {
                billingSystemMain.Instance.MainPanelInstance.Controls.Add(MainUserControl.Instance);
                MainUserControl.Instance.Dock = DockStyle.Fill;
                MainUserControl.Instance.BringToFront();
            }
            else
            {
                MainUserControl.Instance.BringToFront();
            }
        }

        // take user to MainUserControl or Home
        private void SUBackBtn_Click(object sender, EventArgs e)
        {
            billingSystemMain.Instance.MainPanelInstance.Controls.Add(MainUserControl.Instance);
            MainUserControl.Instance.Dock = DockStyle.Fill;
            MainUserControl.Instance.BringToFront();
        }

        /*
        private bool ValidatingInput()
        {
            // Confirm there is text in the control.
            if ()
            {
                MessageBox.Show("Username Can't be Empty!");
            }
            // Confirm that there is a "." and an "@" in the email address.
            else if (userNameTextBox.Text.IndexOf(".") == -1 || userNameTextBox.Text.IndexOf("@") == -1)
            {
                MessageBox.Show("Enter Valid Email Address");
            }
        }*/

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // validating input for empty input or if it contains '.' or '@'
           if (userNameTextBox.Text.Length != 0) //&& userNameTextBox.Text.IndexOf(".") != -1 && userNameTextBox.Text.IndexOf("@") != -1)
            {
                bool loginSuccess = DAlgin.IsLoginSuccess(lgin);

                // assigning value to gettersetterForLoginForm properties 
                lgin.UserName = userNameTextBox.Text;
                lgin.Password = PassTextBox.Text;
                lgin.UserType = UserTypeComboBox.Text;

                if (loginSuccess == true)
                {
                    MessageBox.Show("login Success!");
                }
                else
                {
                    MessageBox.Show("Login Fail");
                }
            }
            else
            {
                MessageBox.Show("Any Field Can't be left empty!\n Please input Valid entry!");
            }
        }
    }
}