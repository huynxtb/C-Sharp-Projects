using System;

namespace Lab_1_Vietnamese_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            Student[] students = new Student[n];
            Console.WriteLine("Nhap DS sinh vien");
            int sID;
            string tenSV, khoa;
            float diemTB;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap MSSV: ");
                sID = int.Parse(Console.ReadLine());
                Console.Write("Nhap ten SV: ");
                tenSV = Console.ReadLine();
                Console.Write("Nhap khoa: ");
                khoa = Console.ReadLine();
                Console.Write("Nhap diem TB: ");
                diemTB = float.Parse(Console.ReadLine());
                students[i] = new Student(sID, tenSV, khoa, diemTB);
            }

            Console.WriteLine("Danh sach Sinh Vien");
            foreach (Student student in students)
            {
                student.Show();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
