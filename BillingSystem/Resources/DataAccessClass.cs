using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BillingSystem.Resources;

namespace BillingSystem.Resources
{
    class DataAccessClass
    {
        // billingSystemDb is connectionString name which i given in App.config file
        static string DBConnString = ConfigurationManager.ConnectionStrings["connstrbs"].ConnectionString;
        
        #region Select Data from Database
        public DataTable Select() 
        {
            SqlConnection conn = new SqlConnection(DBConnString);
            DataTable dt = new DataTable();
 
            try
            {
                string sql = "SELECT * from UserTable";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                conn.Open();
                dataAdapter.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }return dt;
        }
        #endregion

        #region Inserting Data in UserTable
        public bool Insert(GetterSetterForUserTable ds)
        {
            bool isReturnSuccess = false;
            SqlConnection conn = new SqlConnection(DBConnString);
            try
            {
                String sql = "INSERT into UserTable (FirstName, LastName, Email, UserName, Password, Mobile, Address, Gender, UserType, AddedDate, AddedBy) VALUES (@FirstName, @LastName, @Email, @UserName, @Password, @Mobile, @Address, @Gender, @UserType, @AddedDate, @AddedBy)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", ds.FirstName);
                cmd.Parameters.AddWithValue("@LastName", ds.LastName);
                cmd.Parameters.AddWithValue("@Email", ds.Email);
                cmd.Parameters.AddWithValue("@UserName", ds.UserName);
                cmd.Parameters.AddWithValue("@Password", ds.Password);
                cmd.Parameters.AddWithValue("@Mobile", ds.Mobile);
                cmd.Parameters.AddWithValue("@Address", ds.Address);
                cmd.Parameters.AddWithValue("@Gender", ds.Gender);
                cmd.Parameters.AddWithValue("@UserType", ds.UserType);
                cmd.Parameters.AddWithValue("@AddedDate", ds.AddedDate);
                cmd.Parameters.AddWithValue("@AddedBy", ds.AddedBy);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                // if row is greater than 0 it means query executed successfully
                if (rows > 0)
                {
                    isReturnSuccess = true;
                }
                else
                {
                    isReturnSuccess = false;
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
            return isReturnSuccess;
        }
        #endregion
        #region updating data in UserTable
        public bool Update(GetterSetterForUserTable updt)
        {
            bool isReturnSuccess = false;
            SqlConnection conn = new SqlConnection(DBConnString);
            try
            {
                string sql = "UPDATE UserTable SET FirstName = @FirstName, LastName = @LastName, Email = @Email, UserName = @UserName, Password = @Password, Mobile = @Mobile, Address = @Adderss, Gender = @Gender, UserType = @UserType, AddedDate = @AddedDate, AddedBy = @AddedBy Where ID = @ID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", updt.FirstName);
                cmd.Parameters.AddWithValue("@LastName", updt.LastName);
                cmd.Parameters.AddWithValue("@Email", updt.Email);
                cmd.Parameters.AddWithValue("@UserName", updt.UserName);
                cmd.Parameters.AddWithValue("@Password", updt.Password);
                cmd.Parameters.AddWithValue("@Mobile", updt.Mobile);
                cmd.Parameters.AddWithValue("@Address", updt.Address);
                cmd.Parameters.AddWithValue("@Gender", updt.Gender);
                cmd.Parameters.AddWithValue("@UserType", updt.UserType);
                cmd.Parameters.AddWithValue("@AddedDate", updt.AddedDate);
                cmd.Parameters.AddWithValue("@AddedBy", updt.AddedBy);
                cmd.Parameters.AddWithValue("@ID", updt.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isReturnSuccess = true;
                }
                else
                {
                    isReturnSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }return isReturnSuccess;
        }
        #endregion

        #region delete data from UserTable
        public bool Delete(GetterSetterForUserTable dl)
        {
            bool isReturnSuccess = false;
            SqlConnection conn = new SqlConnection(DBConnString);

            try
            {
                string sql = "DELETE from UserTable WHERE id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", dl.id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isReturnSuccess = true;
                }
                else
                {
                    isReturnSuccess = false;
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
            return isReturnSuccess;
        }
        #endregion
    }
}
