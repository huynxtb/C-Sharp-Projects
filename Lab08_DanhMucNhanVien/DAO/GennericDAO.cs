using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_DanhMucNhanVien.DAO
{
    interface GennericDAO<T>
    {
        bool ExecuteQuery(string sql, object[] values);
        bool IsExistedBy(string sql, string values, string row);
        DataTable Query(string sql, object[] values);
        int Count(string sql);
    }
}
