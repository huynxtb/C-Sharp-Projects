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
    interface IPointDAO : IAbstractDAO<PointDTO>
    {
        bool Insert(PointDTO dto);
        bool Update(PointDTO dto);
        bool Delete(PointDTO dto);
        int Count();
        DataTable FindByMSSV(int stdCode);
    }
}
