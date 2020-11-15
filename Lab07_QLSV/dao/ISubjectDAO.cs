using Lab07_QLSV.DAO;
using Lab07_QLSV.dto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QLSV.dao
{
    interface ISubjectDAO : IAbstractDAO<SubjectDTO>
    {
        bool Insert(SubjectDTO dto);
        bool Update(SubjectDTO dto);
        bool Delete(SubjectDTO dto);
        DataTable IsExistedBy(string values);
        int Count();
    }
}
