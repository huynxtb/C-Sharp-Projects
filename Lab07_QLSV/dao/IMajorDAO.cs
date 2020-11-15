using Lab07_QLSV.DAO;
using Lab07_QLSV.dto;
using System.Data;

namespace Lab07_QLSV.dao
{
    interface IMajorDAO : IAbstractDAO<MajorDTO>
    {
        bool Insert(MajorDTO dto);
        bool Update(MajorDTO dto);
        bool Delete(MajorDTO dto);
        DataTable IsExistedBy(string values);
        int Count();
        DataTable FindAll();
    }
}
