using CoreDB.model;
using System.Data;

namespace CoreDB.service
{
    interface IModelService
    {
        bool Insert(Model dto);
        bool Update(Model dto);
        bool Delete(long id);
        DataTable FindAll();
        DataTable Search(string text);
        DataTable SearchByCategoryId(long id);
        bool IsExistedBy(string values, string row);
        int Count();
    }
}
