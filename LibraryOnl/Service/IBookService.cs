using LibraryOnl.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DAO
{
    interface IBookService
    {
        bool Insert(BookDTO dto);
        bool Update(BookDTO dto);
        bool Delete(long id); 
        DataTable FindAll();
        DataTable Search(string text);
        DataTable SearchByCategoryId(long id);
        bool IsExistedBy(string values, string row);
        int Count();
    }
}
