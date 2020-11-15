using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryOnl.DTO
{
    class BookDTO : AbstractDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Byte[] images { get; set; }
        public long CategoryId { get; set; }
        public string CategoryCode { get; set; }
    }
}
