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
    public partial class Inventory : UserControl
    {
        private static Inventory INV_instance; // an instance variable of Inventory class type

        // creating an instance of Inventory class
        // so that we can access this instance from other class
        public static Inventory Instance
        {
            get
            {
                if (INV_instance == null)
                {
                    INV_instance = new Inventory();
                }
                return INV_instance;
            }
        }

        public Inventory()
        {
            InitializeComponent();
        }
    }
}
