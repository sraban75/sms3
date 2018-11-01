using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SMS.DAL
{
    public class CityRepository
    {
        static string conString = @"Server=BITMTRAINER-301\SQLEXPRESS; Database=EmployeeDb_52_13; Integrated Security=true";
        SqlConnection con = new SqlConnection(conString);

        public DataTable GetCityBindingDataSource()
        {
            try
            {
                
                string query = @"SELECT * FROM City";
                SqlCommand command = new SqlCommand(query, con);
                con.Open();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            return null;
        }

    }
}