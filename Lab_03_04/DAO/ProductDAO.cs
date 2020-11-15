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
    class ProductDAO : Singleton<ProductDAO>
    {
        public bool Insert(ProductDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)");
            sb.Append(" VALUES( @ProductName , @SupplierID , @CategoryID , @QuantityPerUnit , @UnitPrice , @UnitsInStock , @UnitsOnOrder , @ReorderLevel , @Discontinued )");
            return BaseData.GetInstance.ExecuteQuery(sb.ToString(), new object[] { dto.ProductName, dto.SupplierID, dto.CategoryID, dto.Quarity,
                                                                                       dto.Price, dto.Stock, dto.Order, dto.Reorder, dto.Discontinued }); ;
        }
        public bool Update(ProductDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE Products SET ProductName= @ProductName , SupplierID= @SupplierID , CategoryID= @CategoryID , QuantityPerUnit= @QuantityPerUnit ");
            sb.Append(", UnitPrice= @UnitPrice , UnitsInStock= @UnitsInStock , UnitsOnOrder= @UnitsOnOrder , ReorderLevel= @ReorderLevel , Discontinued= @Discontinued WHERE ProductID= @ProductID");
            return BaseData.GetInstance.ExecuteQuery(sb.ToString(), new object[] { dto.ProductName, dto.SupplierID, dto.CategoryID, dto.Quarity,
                                                                                       dto.Price, dto.Stock, dto.Order, dto.Reorder, dto.Discontinued, dto.ID });
        }
        public bool Delete(int id)
        {
            string sql = "DELETE Products WHERE ProductID= @ProductID";
            return BaseData.GetInstance.ExecuteQuery(sql, new object[] { id });
        }
        public DataTable SearchByProductName(string text)
        {
            string sql = $"SELECT * FROM Products WHERE ProductName LIKE '%{text}%'";
            return BaseData.GetInstance.Query(sql);
        }
    }
}
