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
    public partial class Products : UserControl
    {
        private static Products Pr_instance; // an instance variable of UserLogin class type

        // creating an instance of UserLogin class
        // so that we can access this instance from other class
        public static Products Instance
        {
            get
            {
                if (Pr_instance == null)
                {
                    Pr_instance = new Products();
                }
                return Pr_instance;
            }
        }

        public Products()
        {
            InitializeComponent();
        }
    }
}
