using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QLSV.dto
{
    class StudentDTO
    {
        public int code { get; set; }
        public string fullName { get; set; }
        public DateTime birthDay { get; set; }
        public int sex { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string majorCode { get; set; }
    }
}
