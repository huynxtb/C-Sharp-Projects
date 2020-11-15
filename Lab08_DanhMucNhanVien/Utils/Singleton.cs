using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_DanhMucNhanVien.Utils
{
    class Singleton <T> where T : new ()
    {
        private static T instance;

        private static object key = new object();
        public static T Instances
        {
            get
            {
                if (instance == null)
                {
                    lock (key)
                    {
                        instance = new T();
                    }
                }
                return instance;
            }
        }
    }
}
