using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_Vietnamese_Ex3
{
    class Student : People
    {
        private int sID;
        private string khoa;
        private float diemTB;

        public Student()
        {
        }

        public Student(int sID, string name, string khoa, float diemTB) : base(name)
        {
            this.SID = sID;
            this.Khoa = khoa;
            this.DiemTB = diemTB;
        }

        public int SID { get => sID; set => sID = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }

        public Student Nhap1SV()
        {
            Console.Write("Nhap MSSV: ");
            SID = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten SV: ");
            Name = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            Khoa = Console.ReadLine();
            Console.Write("Nhap diem TB: ");
            DiemTB = float.Parse(Console.ReadLine());
            Console.WriteLine();
            return new Student(SID, Name, Khoa, DiemTB);
        }

        public void Show()
        {
            Console.WriteLine("MSSV: {0}", SID);
            Console.WriteLine("TenSV: {0}", Name);
            Console.WriteLine("Khoa: {0}", Khoa);
            Console.WriteLine("Diem TB: {0}", DiemTB);
        }
    }
}
