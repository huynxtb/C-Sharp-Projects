using LibraryOnl.DTO;
using LibraryOnl.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DAO.impl
{
    class BookDAO : AbstractDAO<BookDTO>, IBookDAO
    {
        public bool Insert(BookDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO books (title, content, createdby, createddate, categoryid, images)");
            sb.Append(" VALUES( @title , @content , @createdby , @createddate , @categoryid , @images )");
            return ExecuteQuery(sb.ToString(), new object[] { dto.Title, dto.Content, dto.CreatedBy, dto.CreateDate, dto.CategoryId, dto.images });
        }
        public bool Update(BookDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE books SET title= @title , content= @content , modifiedby= @modifiedby ,");
            sb.Append(" modifieddate= @modifieddate , categoryid= @categoryid , images= @images  WHERE id= @id ");
            return ExecuteQuery(sb.ToString(), new object[] {dto.Title, dto.Content, dto.ModifiedBy, dto.ModifiedDate, dto.CategoryId, dto.images, dto.ID });
        }
        public bool Delete(long id)
        {
            string sql = "DELETE books WHERE id= @id";
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
        public bool IsExistedBy(string values, string row)
        {
            throw new NotImplementedException();
        }
    }
}
