using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DTO
{
    class AbstractDTO
    {
        public long ID { get; set; }
        public SqlDateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public SqlDateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
