using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_Vietnamese_Ex3
{
    class People
    {
        protected String name;

        public string Name { get => name; set => name = value; }

        public People()
        {
        }

        public People(string name)
        {
            this.name = name;
        }
    }
}
