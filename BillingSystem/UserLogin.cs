﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.OtherClasses;

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

        GetterSetterForLoginForm lgin = new GetterSetterForLoginForm();
        DataAccessForLogin dalgin = new DataAccessForLogin();

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

        private void home_Click(object sender, EventArgs e)
        {
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
        // take user to MainUserControl or Home
        private void SUBackBtn_Click(object sender, EventArgs e)
        {
            billingSystemMain.Instance.MainPanel_Instance.Controls.Add(MainUserControl.Instance);
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
            // validating input
            if (userNameTextBox.Text.Length != 0 && userNameTextBox.Text.IndexOf(".") != -1 && userNameTextBox.Text.IndexOf("@") != -1)
            {
                lgin.UserName = userNameTextBox.Text.Trim();
                lgin.Password = PassTextBox.Text.Trim();

                bool loginCheck = dalgin.IsLoginSuccess(lgin);

                if (loginCheck == true)
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
                MessageBox.Show("Username Can't be Empty!\n Or input a Valid Email Address!");
            }

        }
    }
}
