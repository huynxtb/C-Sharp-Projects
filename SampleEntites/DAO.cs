using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntites
{
    class DAO
    {
        public bool Insert(SinhVien dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO SinhVien (mssv, hoten, malop)");
            sb.Append(" VALUES( @mssv , @hoten , @malop )");
            return DataProvider.GetInstance.ExecuteQuery(sb.ToString(), new object[] { dto.mssv, dto.hoten, dto.malop }); ;
        }
        public bool Update(SinhVien dto)
        {
            string sql = "UPDATE SinhVien SET hoten= @hoten , malop= @malop WHERE mssv= @mssv";
            return DataProvider.GetInstance.ExecuteQuery(sql, new object[] { dto.hoten, dto.malop, dto.mssv });
        }
        public bool Delete(SinhVien dto)
        {
            string sql = "DELETE SinhVien WHERE mssv= @mssv";
            return DataProvider.GetInstance.ExecuteQuery(sql, new object[] { dto.mssv });
        }
    }
}
