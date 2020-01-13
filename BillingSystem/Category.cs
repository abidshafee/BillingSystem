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
    public partial class Category : UserControl
    {
        private static Category Ct_instance; // an instance variable of UserLogin class type

        // creating an instance of UserLogin class
        // so that we can access this instance from other class
        public static Category Instance
        {
            get
            {
                if (Ct_instance == null)
                {
                    Ct_instance = new Category();
                }
                return Ct_instance;
            }
        }


        public Category()
        {
            InitializeComponent();
        }
    }
}
