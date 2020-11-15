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
    class SubjectDAO : AbstractDAO<SubjectDTO>, ISubjectDAO
    {
        public int Count()
        {
            string sql = "SELECT count(*) FROM Mon";
            return Count(sql);
        }

        public bool Delete(SubjectDTO dto)
        {
            string sql = $"DELETE Mon WHERE MaMH= @MaMH";
            return ExecuteQuery(sql, new object[] { dto.code });
        }

        public bool Insert(SubjectDTO dto)
        {
            string sql = $"INSERT INTO Mon (MaMH, TenMH, SoTiet) VALUES ( @MaMH , @TenMH , @SoTiet )";
            return ExecuteQuery(sql, new object[] { dto.code, dto.name, dto.nOfLesssons });
        }

        public DataTable IsExistedBy(string values)
        {
            string sql = $"SELECT * FROM Mon WHERE MaMH= @MaMH";
            return Query(sql, new object[] { values });
        }

        public bool Update(SubjectDTO dto)
        {
            string sql = $"UPDATE Mon SET TenMH= @TenMH , SoTiet= @SoTiet WHERE MaMH= @MaMH";
            return ExecuteQuery(sql, new object[] { dto.name, dto.nOfLesssons, dto.code });
        }
    }
}
