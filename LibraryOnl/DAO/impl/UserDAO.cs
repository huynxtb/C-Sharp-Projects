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
    class UserDAO : AbstractDAO<UserDTO>, IUserDAO
    {
        public UserDTO FindUserByUsername(string username, string password, int status)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM users AS u INNER JOIN roles AS r ON r.id = u.roleid ");
            sb.Append($"WHERE username= @username AND  status= @status");
            DataTable dt = Query(sb.ToString(), new object[] { username, status });
            bool isEmpty;
            List<UserDTO> users = new List<UserDTO>();
            UserDTO user = new UserDTO();
            RoleDTO role = new RoleDTO();
            if (dt != null)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (password == SecurityUtil.Decrypt(item["password"].ToString()))
                    {
                        user.Username = item["username"].ToString();
                        user.Password = item["password"].ToString();
                        user.Fullname = item["fullname"].ToString();
                        user.Avatar = (Byte[])(item["avatar"]);
                        user.Email = item["email"].ToString();
                        role.code = item["code"].ToString();
                        role.name = item["name"].ToString();
                        user.role = role;
                        users.Add(user);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            isEmpty = !users.Any();
            if (isEmpty)
            {
                return null;
            }
            else
            {
                return users.First();
            }
        }
        public bool Insert(UserDTO dto)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO users (username, password, fullname, status, roleid, createddate, createdby, email, avatar)");
            sb.Append(" VALUES( @username , @password , @fullname , @status , @roleid , @createddate , @createdby , @email , @avatar )");
            return ExecuteQuery(sb.ToString(), new object[] { dto.Username, dto.Password, dto.Fullname, dto.Status, dto.RoleId, dto.CreateDate, dto.CreatedBy, dto.Email, dto.Avatar });
        }
        public DataTable IsExistedBy(string values)
        {
            string sql = "SELECT * FROM users WHERE username = @username";
            return Query(sql, new object[] { values });
        }
        public DataTable Query(UserDTO model)
        {
            throw new NotImplementedException();
        }
        public bool Update(UserDTO model)
        {
            throw new NotImplementedException();
        }
        public int Count()
        {
            throw new NotImplementedException();
        }
        public bool Delete(UserDTO model)
        {
            throw new NotImplementedException();
        }

        public DataTable Search(string text)
        {
            string sql = $"SELECT * FROM users WHERE username LIKE '%{text}%' OR fullname LIKE '%{text}%'OR email LIKE '%{text}%'";
            return Query(sql);
        }
        public DataTable FindAll()
        {
            string sql = "SELECT * FROM users";
            return Query(sql);
        }
    }
}
