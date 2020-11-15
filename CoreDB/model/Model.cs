using System;
using System.Data.SqlTypes;

namespace CoreDB.model
{
    class Model
    {
        public string Stringg { get; set; }
        public int Intt { get; set; }
        public Byte[] ByteArray { get; set; }
        public long Longg { get; set; }
        public float Floatt { get; set; }
        public SqlDateTime SqlDateTimee { get; set; }
    }
}
