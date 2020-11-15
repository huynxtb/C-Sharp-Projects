using LibraryOnl.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DTO
{
    class UserDTO : AbstractDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public Byte[] Avatar { get; set; }
        public int Status { get; set; }
        public long RoleId { get; set; }
        public RoleDTO role { get; set; }
    }
}
