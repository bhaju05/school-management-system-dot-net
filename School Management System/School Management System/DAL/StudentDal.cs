using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.DAL
{
   public class StudentDal
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());


        public static DataTable GetAll()
        {

            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from subjects";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dt.Load(dr);

                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
