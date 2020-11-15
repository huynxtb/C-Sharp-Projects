using LibraryOnl.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DAO
{
    interface IRoleService
    {
        bool Insert(RoleDTO dto);
        bool Update(RoleDTO dto);
        bool Delete(RoleDTO dto);
        bool IsExistedBy(string values, string row);
        int Count();
        DataTable Query(RoleDTO dto);
    }
}
