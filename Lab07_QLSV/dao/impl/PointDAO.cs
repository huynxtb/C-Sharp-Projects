using Lab07_QLSV.DAO.impl;
using Lab07_QLSV.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QLSV.dao.impl
{
    class PointDAO : AbstractDAO<PointDTO>, IPointDAO
    {
        public int Count()
        {
            string sql = "SELECT count(*) FROM ketqua";
            return Count(sql);
        }

        public bool Delete(PointDTO dto)
        {
            string[] parameters = new string[] { "", "", "" };
            string sql = $"DELETE FROM KetQua WHERE MaSo= @MaSo AND MaMH= @MaMH AND Diem= @Diem";
            return ExecuteQuery(sql, new object[] { dto.stdCode, dto.subCode, dto.point });
        }

        public bool Insert(PointDTO dto)
        {
            string sql = $"INSERT INTO KetQua (MaSo, MaMH, Diem) VALUES ( @MaSo , @MaMH , @Diem )";
            return ExecuteQuery(sql, new object[] { dto.stdCode, dto.subCode, dto.point });
        }

        public bool IsExistedBy(string values, string row)
        {
            return false;
        }

        public DataTable FindByMSSV(int stdCode)
        {
            string sql = $"SELECT *FROM KetQua WHERE MaSo = @MaSo";
            return Query(sql, new object[] { stdCode });
        }

        public bool Update(PointDTO dto)
        {
            string sql = $"UPDATE KetQua SET Diem= @Diem WHERE MaSo= @MaSo AND MaMH= @MaMH";
            return ExecuteQuery(sql, new object[] { dto.point, dto.stdCode, dto.subCode });
        }
    }
}
