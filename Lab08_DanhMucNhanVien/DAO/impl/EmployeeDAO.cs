using Lab08_DanhMucNhanVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_DanhMucNhanVien.DAO.impl
{
    class EmployeeDAO : AbstractDAO<EmployeeModel>, IEmployeeDAO
    {

        public int Count()
        {
            string sql = "";
            return Count(sql);
        }

        public bool Insert(EmployeeModel model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO NHANVIEN (HoTenNhanVien, NgaySinh, DiaChi, DienThoai, MaBangCap)");
            sb.Append($" VALUES( @HoTenNhanVien , @NgaySinh , @DiaChi , @DienThoai , @MaBangCap )");
            return ExecuteQuery(sb.ToString(), new object[] { model.FullName, model.Date, model.Address, model.Phone, model.MaBangCap });
        }
        public bool Update(EmployeeModel model)
        {
            string sql =$"UPDATE NHANVIEN SET HoTenNhanVien= @HoTenNhanVien , NgaySinh= @NgaySinh , " +
                        $"DiaChi= @DiaChi , DienThoai= @DienThoai , MaBangCap= @MaBangCap WHERE MaNhanVien= @MaNhanVien"; 
            return ExecuteQuery(sql, new object[] { model.FullName, model.Date, model.Address, model.Phone, model.MaBangCap, model.Code});
        }
        public bool Delete(long id)
        {
            string sql = $"DELETE NHANVIEN WHERE MaNhanVien= @MaNhanVien";
            return ExecuteQuery(sql, new object[] { id });
        }
    }
}
