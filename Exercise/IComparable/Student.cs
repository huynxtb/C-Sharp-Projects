using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Exercise
{
    class Student : IComparable<Student>
    {
        private string Code;
        private string Name;
        private float Mark;

        public Student()
        {
        }

        public Student(string code, string name, float mark)
        {
            this.Code = code;
            this.Name = name;
            this.Mark = mark;
        }

        public string Code1 { get => Code; set => Code = value; }
        public string Name1 { get => Name; set => Name = value; }
        public float Mark1 { get => Mark; set => Mark = value; }

        public int CompareTo( Student other)
        {
            if (this.Mark > other.Mark) return -1;
            else if (this.Mark == other.Mark) return 0;
            else return 1;
        }
    }
}
