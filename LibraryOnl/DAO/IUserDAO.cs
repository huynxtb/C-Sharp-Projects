using LibraryOnl.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DAO
{
    interface IUserDAO : GennericDAO<UserDTO>
    {
        bool Insert(UserDTO model);
        bool Update(UserDTO model);
        bool Delete(UserDTO model);
        DataTable IsExistedBy(string values);
        UserDTO FindUserByUsername(string username, string password, int status);
        int Count();
        DataTable Query(UserDTO model);
        DataTable Search(string text);
        DataTable FindAll();
    }
}
