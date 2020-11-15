using BasicDBCsharp.dto;
using BasicDBCsharp.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDBCsharp.dao.impl
{
    class ClassDAO : Singleton<ClassDAO>
    {
        public bool Insert(ClassDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO lop (malop, tenlop, nam)");
            sb.Append(" VALUES( @malop , @tenlop , @nam )");
            return DataProvider.GetInstance.ExecuteQuery(sb.ToString(), new object[] { dto.MaLop, dto.TenLop, dto.Year });
        }
        public bool Update(ClassDTO dto)
        {
            string sql = "UPDATE lop SET tenlop= @tenlop , nam= @nam WHERE malop= @malop";
            return DataProvider.GetInstance.ExecuteQuery(sql, new object[] { dto.TenLop, dto.Year, dto.MaLop });
        }
        public bool Delete(ClassDTO MaLop)
        {
            string sql = "DELETE lop WHERE malop= @malop";
            return DataProvider.GetInstance.ExecuteQuery(sql, new object[] { MaLop.MaLop });
        }
        public DataTable FindAll()
        {
            return null;
        }
        public int Count()
        {
            return 0;
        }
        public DataTable IsExistedBy(string values)
        {
            string sql = "SELECT * FROM lop WHERE MaLop = @malop";
            return DataProvider.GetInstance.Query(sql, new object[] { values });
        }
    }
}
