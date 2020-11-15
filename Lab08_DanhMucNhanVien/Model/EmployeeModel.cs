using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_DanhMucNhanVien.Model
{
    class EmployeeModel
    {
        public int Code { get; set; }
        public string FullName { get; set; }
        public DateTime Date { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int MaBangCap { get; set; } 
    }
}
