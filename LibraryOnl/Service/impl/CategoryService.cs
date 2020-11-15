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
    class CategoryService : ICategoryService
    {
        private ICategoryDAO categoryDAO = Singleton<CategoryDAO>.GetInstance;
        public bool Insert(CategoryDTO dto)
        {
            return categoryDAO.Insert(dto);
        }
        public bool Update(CategoryDTO dto)
        {
            return categoryDAO.Update(dto);
        }
        public bool Delete(long id)
        {
            return categoryDAO.Delete(id);
        }
        public bool IsExistedBy(string values, string row)
        {
            throw new NotImplementedException();
        }
        public DataTable FindAll()
        {
            return categoryDAO.FindAll();
        }
        public int Count()
        {
            throw new NotImplementedException();
        }
    }
}
