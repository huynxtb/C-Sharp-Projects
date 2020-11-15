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
    class SupplierDAO : Singleton<SupplierDAO>
    {
        public bool Insert(SupplierDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Suppliers (CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage)");
            sb.Append(" VALUES( @CompanyName , @ContactName , @ContactTitle , @Address , @City , @Region , @PostalCode , @Country , @Phone , @Fax , @HomePage )");
            return BaseData.GetInstance.ExecuteQuery(sb.ToString(), new object[] { dto.CompanyName, dto.ContactName, dto.ContactTitle, dto.Address,
                                                                                       dto.City, dto.Region, dto.PostalCode, dto.Country, dto.Phone, dto.Fax, dto.HomePage}); ;
        }
        public bool Update(SupplierDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE Suppliers SET CompanyName= @CompanyName , ContactName= @ContactName , ContactTitle= @ContactTitle , Address= @Address , City= @City , ");
            sb.Append("Region= @Region , PostalCode= @PostalCode , Country= @Country , Phone= @Phone , Fax= @Fax , HomePage= @HomePage WHERE SupplierID= @SupplierID");
            return BaseData.GetInstance.ExecuteQuery(sb.ToString(), new object[] { dto.CompanyName, dto.ContactName, dto.ContactTitle, dto.Address,
                                                                                       dto.City, dto.Region, dto.PostalCode, dto.Country, dto.Phone, dto.Fax, dto.HomePage, dto.ID});
        }
        public bool Delete(int id)
        {
            string sql = "DELETE Suppliers WHERE SupplierID= @SupplierID";
            return BaseData.GetInstance.ExecuteQuery(sql, new object[] { id });
        }
        public DataTable SearchByCompanyName(string text)
        {
            string sql = $"SELECT * FROM Suppliers WHERE CompanyName LIKE '%{text}%'";
            return BaseData.GetInstance.Query(sql);
        }
    }
}
