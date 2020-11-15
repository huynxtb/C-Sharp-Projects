using Lab08_DanhMucNhanVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_DanhMucNhanVien.Service
{
    interface IEmployeeService
    {
        bool Insert(EmployeeModel model);
        bool Update(EmployeeModel model);
        bool Delete(int code);
        int Count();
    }
}
