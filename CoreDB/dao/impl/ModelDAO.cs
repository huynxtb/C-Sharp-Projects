using CoreDB.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CoreDB.dao.impl
{
    class ModelDAO : AbstractDAO<Model>, IModelDAO
    {
         public bool Insert(Model dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO books (title, content, createdby, createddate, categoryid, images)");
            sb.Append(" VALUES( @title , @content , @createdby , @createddate , @categoryid , @images )");
            return ExecuteQuery(sb.ToString(), new object[] { dto.Title, dto.Content, dto.CreatedBy, dto.CreateDate, dto.CategoryId, dto.images });
        }
        public bool Update(Model dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"UPDATE books SET title= @title , content= @content , modifiedby= @modifiedby ,");
            sb.Append($" modifieddate= @modifieddate , categoryid= @categoryid , images= @images  WHERE id= @id ");
            return ExecuteQuery(sb.ToString(), new object[] {dto.Title, dto.Content, dto.ModifiedBy, dto.ModifiedDate, dto.CategoryId, dto.images, dto.ID });
        }
        public bool Delete(long id)
        {
            string sql = $"DELETE books WHERE id= @id";
            return ExecuteQuery(sql, new object[] { id });
        }
        public DataTable FindAll()
        {
            string sql = "SELECT * FROM books";
            return Query(sql);
        }
        public DataTable Search(string text)
        {
            string sql = $"SELECT * FROM books WHERE content LIKE '%{text}%' OR title LIKE '%{text}%'";
            return Query(sql);
        }
        public DataTable SearchByCategoryId(long id)
        {
            string sql = $"SELECT * FROM books WHERE categoryid ={id}";
            return Query(sql);
        }
        public int Count()
        {
            throw new NotImplementedException();
        }
       public DataTable IsExistedBy(string values)
        {
            string sql = "SELECT * FROM users WHERE username = @username";
            return Query(sql, new object[] { values });
        }
    }
}
