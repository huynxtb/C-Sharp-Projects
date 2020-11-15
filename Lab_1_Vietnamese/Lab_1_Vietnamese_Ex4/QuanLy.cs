using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_Vietnamese_Ex4
{
    class QuanLy : NhanVien
    {
        protected int soNgayCong;
        protected int bacLuong;

        public QuanLy() : base()
        {
        }

        public override void NhapLuong()
        {
            Console.Write("Nhap so ngay cong: ");
            soNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap so bac luong: ");
            bacLuong = int.Parse(Console.ReadLine());
            LuongThang = soNgayCong * bacLuong;
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
        }

        public override void ChucVu()
        {
            Console.WriteLine("Chuc vu: Quan Ly");
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
        }
    }
}
