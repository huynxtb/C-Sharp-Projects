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
    class StudentDAO : Singleton<StudentDAO>
    {
        public bool Insert(StudentDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO SinhVien (mssv, hoten, malop)");
            sb.Append(" VALUES( @mssv , @hoten , @malop )");
            return DataProvider.GetInstance.ExecuteQuery(sb.ToString(), new object[] { dto.MSSV, dto.HoTen, dto.MaLop });
        }
        public bool Update(StudentDTO dto)
        {
            string sql = "UPDATE SinhVien SET hoten= @hoten , malop= @malop WHERE mssv= @mssv";
            return DataProvider.GetInstance.ExecuteQuery(sql, new object[] { dto.HoTen, dto.MaLop, dto.MSSV });
        }
        public bool Delete(StudentDTO mssv)
        {
            string sql = "DELETE SinhVien WHERE mssv= @mssv";
            return DataProvider.GetInstance.ExecuteQuery(sql, new object[] { mssv.MSSV });
        }
        public DataTable FindAll()
        {
            return null;
        }
        public int Count()
        {
            string sql = "SELECT count(*) FROM SinhVien";
            return DataProvider.GetInstance.Count(sql);
        }
        public DataTable IsExistedBy(string values)
        {
            string sql = "SELECT * FROM SinhVien WHERE mssv = @mssv";
            return DataProvider.GetInstance.Query(sql, new object[] { values });
        }
    }
}
