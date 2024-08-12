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
    public class GradeSubjectDal
    {
        static SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"].ToString());


        public static DataTable GetAll()
        {

            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT [id] ,[grade_id] ,[subject_id] FROM [dbo].[grade_subject]";
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
        public static DataTable GetById(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT [id] ,[grade_id] ,[subject_id] FROM [dbo].[grade_subject] WHERE  [id]= '[id]' ";
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
        public static void insert(String grade_id, String subject_id)
        {

            try
            {
                SqlCommand cmd = conn.CreateCommand();


                cmd.CommandText = $"INSERT INTO [dbo].[grade_subject]([grade_id] ,[subject_id]) VALUES('{grade_id}','{subject_id}')";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.ExecuteNonQuery();
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
        }
        public static void update(String grade_id, String subject_id, int id)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE [dbo].[grade_subject] SET [grade_id] = '{grade_id}',[subject_id] ='{subject_id}' WHERE [id]='{id}'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.ExecuteNonQuery();
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
        }

        public static void delete(int id)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"DELETE FROM [dbo].[grade_subject] WHERE [id]='{id}';";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                cmd.ExecuteNonQuery();
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
        }
    }
}
