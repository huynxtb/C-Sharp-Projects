using System;

namespace Lab_1_Vietnamese_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];

            Student student = new Student(students);
            student.NhapDS();
            student.XuatDS();
            Console.ReadKey();
        }
    }
}
