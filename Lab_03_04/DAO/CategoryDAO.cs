using Lab_03_04.DTO.lab4;
using Lab_03_04.Singleton;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_04.DAO
{
    class CategoryDAO : Singleton<CategoryDAO>
    {
        public bool Insert(CategoryDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Categories (CategoryName, Description, Picture)");
            sb.Append(" VALUES( @CategoryName , @Description , @Picture )");
            return BaseData.GetInstance.ExecuteQuery(sb.ToString(), new object[] { dto.CateName, dto.Description, dto.Pricture }); ;
        }
        public bool Update(CategoryDTO dto)
        {
            string sql = "UPDATE Categories SET CategoryName= @CategoryName , Description= @Description , Picture= @Picture WHERE CategoryID= @CategoryID";
            return BaseData.GetInstance.ExecuteQuery(sql, new object[] { dto.CateName, dto.Description, dto.Pricture, dto.ID });
        }
        public bool Delete(int id)
        {
            string sql = "DELETE Categories WHERE CategoryID= @CategoryID";
            return BaseData.GetInstance.ExecuteQuery(sql, new object[] { id });
        }
        public DataTable SearchByCategoryName(string text)
        {
            string sql = $"SELECT * FROM Categories WHERE CategoryName LIKE '%{text}%'";
            return BaseData.GetInstance.Query(sql);
        }
    }
}
