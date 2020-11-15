using System.Data;

namespace CoreDB
{
    interface GennericDAO<T>
    {
        bool ExecuteQuery(string sql, object[] values = null);
        DataTable Query(string sql, object[] values = null);
        int Count(string sql);
    }
}
