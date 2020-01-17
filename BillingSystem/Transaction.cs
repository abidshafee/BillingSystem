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
    public partial class Transaction : UserControl
    {
        private static Transaction TR_instance;

        public static Transaction Instance
        {
            get
            {
                if(TR_instance == null)
                {
                    TR_instance = new Transaction();
                }return TR_instance;
            }
        }
        public Transaction()
        {
            InitializeComponent();
        }
    }
}
