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
                string sql = "select UserName, Password, UserType from UserTable WHERE UserName=@User AND Password=@Pass AND UserType=@UType";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@User", lg.UserName);
                cmd.Parameters.AddWithValue("@Pass", lg.Password);
                cmd.Parameters.AddWithValue("@UType", lg.UserType);

                conn.Open();
                //cmd.ExecuteNonQuery();

                // data adapter will hold data from database temporarily
                SqlDataAdapter dtAdapter = new SqlDataAdapter(cmd);

                DataTable dtValue = new DataTable();
                dtAdapter.Fill(dtValue);

                //checking if query successful
                if (dtValue.Rows.Count>0)
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