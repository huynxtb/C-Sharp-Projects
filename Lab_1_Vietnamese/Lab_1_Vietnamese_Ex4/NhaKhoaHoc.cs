using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_Vietnamese_Ex4
{
    class NhaKhoaHoc : QuanLy
    {
        private int soBaiBao;

        public NhaKhoaHoc()
        {
        }

        public override void NhapLuong()
        {
            base.NhapLuong();
        }

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Nhap so bai bao da cong bo: ");
            soBaiBao = int.Parse(Console.ReadLine());
        }

        public override void ChucVu()
        {
            Console.WriteLine("Chuc vu: Nha Khoa Hoc");
        }

        public override void XuatThongTin()
        {
            base.XuatThongTin();
            Console.WriteLine("So bai bao da cong bao: {0}", soBaiBao);
        }
    }
}
