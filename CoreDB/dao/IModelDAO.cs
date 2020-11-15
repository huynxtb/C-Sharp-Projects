using CoreDB.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CoreDB.dao
{
    interface IModelDAO : GennericDAO<Model>
    {
        bool Insert(Model dto);
        bool Update(Model dto);
        bool Delete(Model dto);
        DataTable IsExistedBy(string values);
        Model FindUserByUsername(string username, string password, int status);
        int Count();
        DataTable Query(Model dto);
        DataTable Search(string text);
        DataTable FindAll();
    }
}
