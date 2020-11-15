using Lab07_QLSV.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QLSV.DAO
{
    interface IStudentDAO : IAbstractDAO<StudentDTO>
    {
        bool Insert(StudentDTO dto);
        bool Update(StudentDTO dto);
        bool Delete(StudentDTO dto);
        DataTable IsExistedBy(string values);
        int Count();
    }
}
