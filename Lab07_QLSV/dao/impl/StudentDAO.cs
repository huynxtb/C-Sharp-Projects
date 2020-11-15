using Lab07_QLSV.dto;
using System.Data;
using System.Text;

namespace Lab07_QLSV.DAO.impl
{
    class StudentDAO : AbstractDAO<StudentDTO>, IStudentDAO
    {
        public int Count()
        {
            string sql = "SELECT count(*) FROM sinhvien";
            return Count(sql);
        }

        public bool Delete(StudentDTO dto)
        {
            string sql = $"DELETE sinhvien WHERE maso= @maso";
            return ExecuteQuery(sql, new object[] { dto.code });
        }

        public bool Insert(StudentDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO sinhvien (maso, hoten, ngaysinh, gioitinh, diachi, dienthoai, makhoa)");
            sb.Append(" VALUES( @maso , @hoten , @ngaysinh , @gioitinh , @diachi , @dienthoai , @makhoa )");
            return ExecuteQuery(sb.ToString(), new object[] { dto.code, dto.fullName, dto.birthDay, dto.sex, dto.address, dto.phone, dto.majorCode });
        }

        public DataTable IsExistedBy(string values)
        {
            string sql = "SELECT * FROM sinhvien WHERE maso = @maso";
            return Query(sql, new object[] { values });
        }

        public bool Update(StudentDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"UPDATE sinhvien SET hoten= @hoten , ngaysinh= @ngaysinh , gioitinh= @gioitinh ,");
            sb.Append($" diachi= @diachi , dienthoai= @dienthoai , makhoa= @makhoa WHERE maso= @maso");
            return ExecuteQuery(sb.ToString(), new object[] { dto.fullName, dto.birthDay, dto.sex, dto.address, dto.phone, dto.majorCode, dto.code });
        }
    }
}
