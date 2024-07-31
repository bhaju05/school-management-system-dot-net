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
    public class GradeDal
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());
        

        public static DataTable GetAll()
        {
            
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from grades";
                if(conn.State != ConnectionState.Open)
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
        public static void GetById(int id)
        {
            MessageBox.Show("This is get all grade details by id");
        }
        public static void insert(String GradeName, String GradeOrder)
        {
            MessageBox.Show("This is insert by grade");
        }
        public static void update(String GradeName, String GradeOrder,int id)
        {
            MessageBox.Show("This is update by grade");
        }
        public static void delete(int id)
        {
            MessageBox.Show("This is delete by grade");
        }
    }
}
