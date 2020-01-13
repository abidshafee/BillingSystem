using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BillingSystem.Resources
{
    class DataAccessClass
    {
        static string DBConnString = ConfigurationManager.ConnectionStrings["billingSystemDb"].ConnectionString;
        #region Select Data from Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(DBConnString);
            DataTable dt = new DataTable();
            // working

        }
        #endregion
    }
}
