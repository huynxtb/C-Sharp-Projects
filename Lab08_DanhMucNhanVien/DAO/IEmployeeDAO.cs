using Lab08_DanhMucNhanVien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_DanhMucNhanVien.DAO
{
    interface IEmployeeDAO : GennericDAO<EmployeeModel>
    {
        bool Insert(EmployeeModel model);
        bool Update(EmployeeModel model);
        bool Delete(long id);
        int Count();
    }
}
