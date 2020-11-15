using LibraryOnl.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DAO
{
    interface ICategoryService
    {
        bool Insert(CategoryDTO dto);
        bool Update(CategoryDTO dto);
        bool Delete(long id);
        bool IsExistedBy(string values, string row);
        int Count();
        DataTable FindAll();
    }
}
