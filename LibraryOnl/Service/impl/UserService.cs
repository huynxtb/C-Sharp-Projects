using LibraryOnl.DAO;
using LibraryOnl.DAO.impl;
using LibraryOnl.DTO;
using LibraryOnl.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.Service
{
    class UserService : IUserService
    {
        private IUserDAO userDAO = Singleton<UserDAO>.GetInstance;
        public UserDTO FindUserByUsername(string username, string password, int status)
        {
            return userDAO.FindUserByUsername(username, password, status);
        }
        public bool Insert(UserDTO dto)
        {
            return userDAO.Insert(dto);
        }
        public bool IsExistedBy(string values)
        {
            Console.WriteLine(userDAO.IsExistedBy(values).Rows.Count);
            return (userDAO.IsExistedBy(values).Rows.Count > 0) ? true : false;
        }
        public DataTable Query(UserDTO dto)
        {
            throw new NotImplementedException();
        }
        public bool Update(UserDTO dto)
        {
            throw new NotImplementedException();
        }
        public int Count()
        {
            throw new NotImplementedException();
        }
        public bool Delete(UserDTO dto)
        {
            throw new NotImplementedException();
        }

        public DataTable Search(string text)
        {
            return userDAO.Search(text);
        }
        public DataTable FindAll()
        {
            return userDAO.FindAll();
        }
    }
}
