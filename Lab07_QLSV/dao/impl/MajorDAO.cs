using Lab07_QLSV.DAO.impl;
using Lab07_QLSV.dto;
using System.Data;
using System.Text;

namespace Lab07_QLSV.dao.impl
{
    class MajorDAO : AbstractDAO<MajorDTO>, IMajorDAO
    {
        public int Count()
        {
            string sql = "SELECT count(*) FROM khoa";
            return Count(sql);
        }

        public bool Delete(MajorDTO dto)
        {
            string sql = $"DELETE khoa WHERE makhoa= @makhoa";
            return ExecuteQuery(sql, new object[] { dto.code });
        }

        public bool Insert(MajorDTO dto)
        {
            string sql = $"INSERT INTO khoa (MaKhoa, TenKhoa) VALUES ( @MaKhoa , @TenKhoa )";
            return ExecuteQuery(sql, new object[] { dto.code, dto.majorName });
        }

        public DataTable IsExistedBy(string values)
        {
            string sql = $"SELECT * FROM khoa WHERE MaKhoa = @MaKhoa";
            return Query(sql, new object[] { values });
        }

        public DataTable FindAll()
        {
            string sql = "SELECT COUNT(MaSo), MaKhoa FROM SinhVien GROUP BY MaKhoa ORDER BY COUNT(MaKhoa) DESC";
            return Query(sql);
        }

        public bool Update(MajorDTO dto)
        {
            string sql = "UPDATE khoa SET tenkhoa= @tenkhoa WHERE makhoa= @makhoa"; 
            return ExecuteQuery(sql, new object[] { dto.majorName, dto.code });
        }
    }
}
