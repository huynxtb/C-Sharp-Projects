using Lab08_DanhMucNhanVien.DAO;
using Lab08_DanhMucNhanVien.DAO.impl;
using Lab08_DanhMucNhanVien.Model;
using Lab08_DanhMucNhanVien.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_DanhMucNhanVien.Service.impl
{
    class EmployeeService : IEmployeeService
    {
        private IEmployeeDAO employeeDAO = Singleton<EmployeeDAO>.Instances;

        public bool Delete(int code)
        {
            return employeeDAO.Delete(code);
        }

        public bool Insert(EmployeeModel model)
        {
            return employeeDAO.Insert(model);
        }

        public bool Update(EmployeeModel model)
        {
            return employeeDAO.Update(model);
        }
        public int Count()
        {
            throw new NotImplementedException();
        }
    }
}
