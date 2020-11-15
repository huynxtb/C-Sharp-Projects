using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    class SinhVien
    {
        private string Code;
        private string Name;
        private float Mark;

        public SinhVien()
        {
        }

        public SinhVien(string code, string name, float mark)
        {
            this.Code = code;
            this.Name = name;
            this.Mark = mark;
        }

        public string Code1 { get => Code; set => Code = value; }
        public string Name1 { get => Name; set => Name = value; }
        public float Mark1 { get => Mark; set => Mark = value; }
    }
}
