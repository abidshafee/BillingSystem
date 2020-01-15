using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BillingSystem.OtherClasses;

namespace BillingSystem.OtherClasses
{
    class DataAccessForLogin
    {
        static string DBConnString = ConfigurationManager.ConnectionStrings["connstrbs"].ConnectionString;

        public bool IsLoginSuccess(GetterSetterForLoginForm lg)
        {
            // flag that hold boolean value
            bool IsLoginSuccess = false;

            SqlConnection conn = new SqlConnection(DBConnString);
            try
            {
                // SQL query to check login data in UserTable
                string sql = "SELECT * from UserTable WHERE UserName=@UserName AND Password=@Password AND UserType=@UserType";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", lg.UserName);
                cmd.Parameters.AddWithValue("@password", lg.Password);
                cmd.Parameters.AddWithValue("@UserType", lg.UserType);

                //conn.Open();
                //cmd.ExecuteNonQuery();

                // data adapter will hold data from database temporarily
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                //checking if query successful
                if (dataTable.Rows.Count>0)
                {
                    IsLoginSuccess = true;
                }
                else
                {
                    IsLoginSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return IsLoginSuccess;
        }

    }
}