using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDBCsharp.utils
{
    public abstract class Singleton<T> where T : Singleton<T>, new()
    {
        private static volatile T instance;
        private static object locker = new object();

        public static T GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (locker)
                    {
                        instance = new T();
                    }
                }
                return instance;
            }
        }
    }
}
