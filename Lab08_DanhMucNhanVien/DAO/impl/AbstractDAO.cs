using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_DanhMucNhanVien.DAO.impl
{
    class AbstractDAO<T> : GennericDAO<T>
    {
        private static ResourceManager resource = new ResourceManager("Lab08_DanhMucNhanVien.database", Assembly.GetExecutingAssembly());
        public SqlConnection GetDBConnection()
        {
            string connString = @"Data Source=" + resource.GetString("dataSource")
                                + ";Initial Catalog=" + resource.GetString("dbName")
                                + ";Persist Security Info=True;User ID=" + resource.GetString("username")
                                + ";Password=" + resource.GetString("password");
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        private void SetParam<T>(string sql,  SqlCommand cmd, object[] values)
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
        public bool IsExistedBy(string sql, string values, string row)
        {
            using (SqlConnection con = GetDBConnection())
            {
                try
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow item in dt.Rows)
                        {
                            if (values == item[row].ToString())
                            {
                                //Console.WriteLine(values);
                                //Console.WriteLine(item[row].ToString());
                                return false;
                            }

                        }
                    }

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
                return true;
            }
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
