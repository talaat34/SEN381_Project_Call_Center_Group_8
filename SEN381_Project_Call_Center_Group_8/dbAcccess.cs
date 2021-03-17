using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms;

namespace SEN381_Project_Call_Center_Group_8
{
    class dbAcccess
    {
        SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder();
        public dbAcccess()
        {
            connBuilder.DataSource = @"(LocalDB)\MSSQLLocalDB";
            connBuilder.InitialCatalog = "CallCenterDB";
            connBuilder.IntegratedSecurity = true;
        }
        

        //CHECK IF ADMINSTARTOR EXISTS IN DATABASE
        public List<adminstrator> checkAdminstrator(string name, string password)
        {
            //LIST FOR ADMINSTRATOR INFROMATION
            List<adminstrator> checkAdminstratorList = new List<adminstrator>();
            //DATABASE CONNECTION
            SqlConnection conn = new SqlConnection(connBuilder.ToString());
            //SQL QUERY
            string checkUserQuery = @"SELECT * FROM adminstrators WHERE name=@name AND password=@password";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(checkUserQuery, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@password", password);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int adminId = reader.GetInt32(0);
                        string adminName = reader.GetString(1);
                        string adminSurname = reader.GetString(2);
                        string adminPassword = reader.GetString(3);

                        checkAdminstratorList.Add(new adminstrator(adminId, adminName, adminSurname, adminPassword));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurred: {0}", ex.Message.ToString());
            }


            return checkAdminstratorList;
        }
        
    }
}
