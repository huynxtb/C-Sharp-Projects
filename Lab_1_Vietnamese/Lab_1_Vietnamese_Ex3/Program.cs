using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_1_Vietnamese_Ex3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien : ");
            int n = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();
            Student student = new Student();
            Console.WriteLine("Nhap DS Sinh Vien");
            for (int i = 0; i < n; i++)
            {
                studentsList.Add(student.Nhap1SV());
            }
            Console.WriteLine("Danh sach Sinh Vien");
            foreach (Student s in studentsList)
            {
                s.Show();
            }

            ArrayList sal = new ArrayList(n);
            Console.WriteLine("Nhap DS Sinh Vien");
            for (int i = 0; i < n; i++)
            {
                sal.Add(student.Nhap1SV());
            }
            Console.WriteLine("=Danh sach Sinh Vien");
            foreach (Student s in sal)
            {
                ((Student)s).Show();
            }
            Console.ReadKey();
        }
    }
}
