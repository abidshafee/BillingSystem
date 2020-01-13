﻿using System;
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
    }
}
