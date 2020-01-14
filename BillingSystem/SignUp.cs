using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.Resources;

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

        // instanciting other class that required here
        GetterSetterForUserTable UT = new GetterSetterForUserTable(); //instanciating gettersetterforusertable class
        DataAccessClass DA = new DataAccessClass();// instanciating dataaccess class

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

        private void home_Click(object sender, EventArgs e)
        {
            //billingSystemMain.Instance.MainPanel_Instance.Controls.Clear();
            if (!billingSystemMain.Instance.MainPanel_Instance.Controls.Contains(MainUserControl.Instance))
            {
                billingSystemMain.Instance.MainPanel_Instance.Controls.Add(MainUserControl.Instance);
                MainUserControl.Instance.Dock = DockStyle.Fill;
                MainUserControl.Instance.BringToFront();
            }
            else
            {
                MainUserControl.Instance.BringToFront();
            }
        }
            DateTime dateTime = DateTime.Now;
        private void SinUpBtn_Click(object sender, EventArgs e)
        {
            //getting data from signup form
            UT.FirstName = FirstNameTextBox.Text;
            UT.LastName = LastNameTextBox.Text;
            UT.Email = UsernameEmailTxtBx.Text;
            UT.UserName = UsernameEmailTxtBx.Text;
            UT.Password = PassTextBox.Text;
            UT.Mobile = MobileTextBox.Text;
            UT.Address = AddressTxtBox.Text;
            UT.Gender = GenderComboBox.Text;
            UT.UserType = UserTypeComboBox.Text;
            UT.AddedDate = dateTime.ToString();
            UT.AddedBy = 1;

            // using DataAccess Class we will insert data into database
            bool isReturnSuccess = DA.Insert(UT);
            if(isReturnSuccess == true)
            {
                MessageBox.Show ("SignUp Successful!\n Now Login");
            }
            else
            {
                MessageBox.Show("SignUp Process Failled!");
            }

        }
    }
}
