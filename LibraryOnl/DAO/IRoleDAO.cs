using LibraryOnl.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DAO
{
    interface IRoleDAO : GennericDAO<RoleDTO>
    {
        bool Insert(RoleDTO model);
        bool Update(RoleDTO model);
        bool Delete(RoleDTO model);
        bool IsExistedBy(string values, string row);
        int Count();
        DataTable Query(RoleDTO model);
    }
}
