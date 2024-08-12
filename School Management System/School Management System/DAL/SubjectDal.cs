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
    public class SubjectDal
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
        public static DataTable GetById(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from subjects WHERE  [id]= '[id]' ";
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
        public static void insert(String SubjectName, String SubjectIndex, String SubjectNumber,String SubjectOrder)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"INSERT INTO [dbo].[subjects] ([subject_name] ,[subject_index],[subject_number],[subject_order]) VALUES('{SubjectName}','{SubjectIndex}','{SubjectNumber}','{SubjectOrder}')";
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
        public static void update(int SelectedId,String SubjectName, String SubjectIndex, String SubjectNumber, String SubjectOrder, int id)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE [dbo].[subjects] SET [subject_name] ='{SubjectName}' ,[subject_index] = '{SubjectIndex}' ,[subject_number] = '{SubjectNumber}',[subject_order] = '{SubjectOrder}',[created_at]='{DateTime.Now.ToString()}' WHERE [id]='{id}';";
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
                cmd.CommandText = $"DELETE FROM [dbo].[subjects] WHERE [id]='{id}';";
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

