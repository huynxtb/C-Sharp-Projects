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
    class BookService : IBookService
    {
        private IBookDAO bookDAO = Singleton<BookDAO>.GetInstance;
        public bool Insert(BookDTO dto)
        {
            return bookDAO.Insert(dto);
        }
        public bool Update(BookDTO dto)
        {
            return bookDAO.Update(dto);
        }
        public bool Delete(long id)
        {
            return bookDAO.Delete(id);
        }
        public DataTable FindAll()
        {
            return bookDAO.FindAll();
        }
        public DataTable Search(string text)
        {
            return bookDAO.Search(text);
        }
        public DataTable SearchByCategoryId(long id)
        {
            return bookDAO.SearchByCategoryId(id);
        }
        public int Count()
        {
            throw new NotImplementedException();
        }
        public bool IsExistedBy(string values, string row)
        {
            throw new NotImplementedException();
        }
    }
}
