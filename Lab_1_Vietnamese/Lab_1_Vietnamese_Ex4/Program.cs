using System;
using System.Collections.Generic;

namespace Lab_1_Vietnamese_Ex4
{
    class Program
    {
        public static int Menu()
        {
            Console.WriteLine("1. Nhan vien phong thi nghiem.");
            Console.WriteLine("2. Nha quan ly.");
            Console.WriteLine("3. Nha khoa hoc.");
            Console.WriteLine("4. Xuat danh sach.");
            Console.Write("Nhap so thu tu: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }

        static void Main(string[] args)
        {
            List<NhanVien> danhsach = new List<NhanVien>();
            NhanVien nhanVien;
            bool check = true;

            long tongLuongNV = 0;
            long tongLuongQL = 0;
            long tongLuongNKH = 0;

            while (check)
            {
                int n = Menu();
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Nhan vien phong thi nghiem");
                        nhanVien = new NhanVien();
                        nhanVien.NhapThongTin();
                        danhsach.Add(nhanVien);
                        tongLuongNV += nhanVien.LuongThang;
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Nha Quan Ly");
                        nhanVien = new QuanLy();
                        nhanVien.NhapThongTin();
                        danhsach.Add(nhanVien);
                        tongLuongQL += nhanVien.LuongThang;
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Nha Khoa Hoc");
                        nhanVien = new NhaKhoaHoc();
                        nhanVien.NhapThongTin();
                        danhsach.Add(nhanVien);
                        tongLuongNKH += nhanVien.LuongThang;
                        Console.WriteLine();
                        Console.ReadKey();
                        break;
                    default:
                        check = false;
                        break;
                }
            }
            Console.WriteLine("Danh sach Nhan Vien");
            foreach (NhanVien nv in danhsach)
            {
                nv.XuatThongTin();
                Console.WriteLine();
            }

            Console.WriteLine("Tong luong moi chuc vu");
            Console.WriteLine("Nhan vien phong thi nghiem: {0}", tongLuongNV);
            Console.WriteLine("Quan ly: {0}", tongLuongQL);
            Console.WriteLine("Nha khoa hoc: {0}", tongLuongNKH);
            Console.ReadKey();
        }
    }
}
