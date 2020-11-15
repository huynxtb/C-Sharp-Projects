using LibraryOnl.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DAO
{
    interface IUserService
    {
        bool Insert(UserDTO dto);
        bool Update(UserDTO dto);
        bool Delete(UserDTO dto);
        bool IsExistedBy(string values);
        UserDTO FindUserByUsername(string username, string password, int status);
        int Count();
        DataTable Query(UserDTO dto);
        DataTable Search(string text);
        DataTable FindAll();
    }
}
