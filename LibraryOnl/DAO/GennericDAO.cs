using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DAO
{
    interface GennericDAO<T>
    {
        bool ExecuteQuery(string sql, object[] values = null);
        DataTable Query(string sql, object[] values = null);
        int Count(string sql);
    }
}
