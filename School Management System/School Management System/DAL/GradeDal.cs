﻿using System;
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
        public static DataTable GetById(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from grades WHERE  [id]= '[id]' ";
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
        public static void insert(String GradeName, String GradeGroup,String GradeOrder)
        {
            
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText =  $"INSERT INTO [dbo].[grades] ([grade_name] ,[grade_group],[grade_order]) VALUES('{GradeName}','{GradeGroup}','{GradeOrder}')";
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
        public static void update(String GradeName,  String GradeGroup, String GradeOrder,int id)
        {
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"UPDATE [dbo].[grades] SET [grade_name] ='{GradeName}' ,[grade_group] = '{GradeGroup}' ,[grade_order] = '{GradeOrder}'  WHERE [id]='{id}';";
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
                cmd.CommandText = $"DELETE FROM [dbo].[grades] WHERE [id]='{id}';";
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
