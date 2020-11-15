using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_Vietnamese_Ex4
{
    class NhanVien
    {
        protected string hoten;
        protected int namSinh;
        protected string bangCap;
        protected long luongThang;

        public long LuongThang { get => luongThang; set => luongThang = value; }

        public NhanVien()
        {
        }
        public virtual void NhapLuong()
        {
            Console.Write("Nhap luong: ");
            LuongThang = long.Parse(Console.ReadLine());
        }
        public virtual void NhapThongTin()
        {
            Console.Write("Nhap Ho - Ten: ");
            hoten = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap bang cap: ");
            bangCap = Console.ReadLine();
            NhapLuong();
        }
        public virtual void ChucVu()
        {
            Console.WriteLine("Chuc vu: Nhan vien phong thi nghiem");
        }
        public virtual void XuatThongTin()
        {
            ChucVu();
            Console.WriteLine("Ho - Ten: {0}", hoten);
            Console.WriteLine("Nam sinh: {0}", namSinh);
            Console.WriteLine("Bang cap: {0}", bangCap);
            Console.WriteLine("Luong thang: {0}", LuongThang);
        }
    }
}
