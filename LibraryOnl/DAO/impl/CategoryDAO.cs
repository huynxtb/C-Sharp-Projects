using LibraryOnl.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DAO.impl
{
    class CategoryDAO : AbstractDAO<CategoryDTO>, ICategoryDAO
    {
        public bool Insert(CategoryDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO category (name, code, createdby, createddate)");
            sb.Append(" VALUES( @name , @code , @createdby , @createddate )");
            return ExecuteQuery(sb.ToString(), new object[] { dto.Name, dto.Code, dto.CreatedBy, dto.CreateDate });
        }
        public bool Update(CategoryDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE category SET name= @name , code= @code ,");
            sb.Append(" modifiedby= @modifiedby , modifieddate= @modifieddate WHERE id= @id");
            return ExecuteQuery(sb.ToString(), new object[] { dto.Name, dto.Code, dto.ModifiedBy, dto.ModifiedDate, dto.ID });
        }
        public bool Delete(long id)
        {
            string sql = "DELETE category WHERE id= @id";
            return ExecuteQuery(sql, new object[] { id });
        }
        public bool IsExistedBy(string values, string row)
        {
            throw new NotImplementedException();
        }
        public DataTable FindAll()
        {
            string sql = "SELECT * FROM category";
            return Query(sql);
        }
        public int Count()
        {
            throw new NotImplementedException();
        }
    }
}
