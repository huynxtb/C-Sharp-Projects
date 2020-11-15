
using Lab07_QLSV.utils;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Resources;

namespace Lab07_QLSV.DAO.impl
{
    class AbstractDAO<T> : IAbstractDAO<T>
    {
        //private string dbName = "";
        //private string dataSource = "MSI";
        //private string username = "sa";
        //private string password = "%Rootkit#0101";

        private static ResourceManager resource = new ResourceManager("Lab07_QLSV.database", Assembly.GetExecutingAssembly());

        public SqlConnection GetDBConnection()
        {
            //string connString = @"Data Source=" + resource.GetString("dataSource")
            //                    + ";Initial Catalog=" + resource.GetString("dbName")
            //                    + ";Persist Security Info=True;User ID=" + resource.GetString("username")
            //                    + ";Password=" + resource.GetString("password");
            string connString = ConfigurationManager.ConnectionStrings["LAB07"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        private void SetParam<T>(string sql, SqlCommand cmd, object[] values)
        {
            string[] parameters = sql.Split(' ');
            int i = 0;
            foreach (string param in parameters)
            {
                if (param.Contains('@'))
                {
                    if (values[i] is string)
                        cmd.Parameters.Add(param, SqlDbType.NVarChar).Value = values[i];
                    else if (values[i] is int)
                        cmd.Parameters.Add(param, SqlDbType.Int).Value = values[i];
                    else if (values[i] is float)
                        cmd.Parameters.Add(param, SqlDbType.Float).Value = values[i];
                    else if (values[i] is double)
                        cmd.Parameters.Add(param, SqlDbType.Float).Value = values[i];
                    else if (values[i] is long)
                        cmd.Parameters.Add(param, SqlDbType.BigInt).Value = values[i];
                    else if (values[i] is Byte[])
                        cmd.Parameters.Add(param, SqlDbType.VarBinary).Value = values[i];
                    else if (values[i] is SqlDateTime)
                        cmd.Parameters.Add(param, SqlDbType.DateTime).Value = values[i];
                    else if (values[i] is DateTime)
                        cmd.Parameters.Add(param, SqlDbType.DateTime).Value = values[i];
                    i++;
                }
            }

        }
        public bool ExecuteQuery(string sql, object[] values = null)
        {

            SqlTransaction transaction = null;
            using (SqlConnection con = GetDBConnection())
            {
                try
                {
                    con.Open();
                    transaction = con.BeginTransaction();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Transaction = transaction;
                    if (values != null)
                    {
                        SetParam<T>(sql, cmd, values);
                    }
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    if (con != null)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception e1)
                        {
                            e1.StackTrace.ToString();
                        }
                    }
                    e.StackTrace.ToString();
                }
                finally
                {
                    con.Close();
                }
            }
            return false;
        }
        public DataTable Query(string sql, object[] values = null)
        {
            DataTable dt = null;
            using (SqlConnection con = GetDBConnection())
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    dt = new DataTable();
                    if (values != null)
                    {
                        SetParam<T>(sql, cmd, values);
                    }

                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);
                }
                catch (Exception e)
                {
                    con.Close();
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    con.Close();
                }
                return dt;
            }
        }
        public int Count(string sql)
        {
            using (SqlConnection con = GetDBConnection())
            {
                int i = 0;
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql);
                    cmd.Connection = con;
                    i = Convert.ToInt32(cmd.ExecuteScalar());
                    return i;
                }
                catch (Exception e)
                {
                    con.Close();
                    e.StackTrace.ToString();
                }
                finally
                {
                    con.Close();
                }
                return 0;
            }
        }

    }
}
