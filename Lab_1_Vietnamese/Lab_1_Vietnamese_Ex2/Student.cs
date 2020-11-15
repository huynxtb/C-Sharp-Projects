using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_Vietnamese_Ex2
{
    class Student
    {
        Student[] students;

        public Student()
        {
        }
        public Student(Student[] students)
        {
            this.students = students;
        }

        public int SID { get; set; }
        public string TenSV { get; set; }
        public string Khoa { get; set; }
        public float DiemTB { get; set; }

        public void Nhap1SV(int i)
        {
            students[i] = new Student();
            Console.Write("Nhap MSSV: ");
            students[i].SID = int.Parse(Console.ReadLine());
            Console.Write("Nhap ten SV: ");
            students[i].TenSV = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            students[i].Khoa = Console.ReadLine();
            Console.Write("Nhap diem TB: ");
            students[i].DiemTB = float.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        public void NhapDS()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Nhap1SV(i);
            }
        }

        public void Show(int i)
        {
            Console.WriteLine("MSSV: {0}", students[i].SID);
            Console.WriteLine("TenSV: {0}", students[i].TenSV);
            Console.WriteLine("Khoa: {0}", students[i].Khoa);
            Console.WriteLine("Diem TB: {0}", students[i].DiemTB);
        }

        public void XuatDS()
        {
            Console.WriteLine("Danh sach Sinh Vien");
            for (int i = 0; i < students.Length; i++)
            {
                Show(i);
            }
        }
    }
}
