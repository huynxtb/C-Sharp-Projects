using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_04.DAO
{
    class BaseData
    {
        private static volatile BaseData instance;
        private static object locker = new object();
        private string connString;
        private BaseData() { }

        public static BaseData GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        instance = new BaseData();
                    }
                }
                return instance;
            }
        }
        private SqlConnection GetDBConnection()
        {
            connString = ConfigurationManager.ConnectionStrings["DE130146"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        private void SetParam(string sql, SqlCommand cmd, object[] values)
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
                        SetParam(sql, cmd, values);
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
                        SetParam(sql, cmd, values);
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
