using CoreDB.dao;
using CoreDB.dao.impl;
using CoreDB.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CoreDB.service.impl
{
    class ModelService : IModelService
    {
        private IModelDAO modelDAO = new ModelDAO();
        public bool Insert(Model model)
        {
            return modelDAO.Insert(model);
        }
        public bool Update(Model model)
        {
            return modelDAO.Update(model);
        }
        public bool Delete(long id)
        {
            return modelDAO.Delete(id);
        }
        public DataTable FindAll()
        {
            return modelDAO.FindAll();
        }
        public DataTable Search(string text)
        {
            return modelDAO.Search(text);
        }
        public DataTable SearchByCategoryId(long id)
        {
            return modelDAO.SearchByCategoryId(id);
        }
        public int Count()
        {
            return modelDAO.Count();
        }
        public bool IsExistedBy(string values, string row)
        {
            string sql = "SELECT * FROM users WHERE username = @username";
            return Query(sql, new object[] { values });
        }
    }
}
