using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_Vietnamese_Ex1
{
    class Student
    {
        private int sID;
        private string tenSV;
        private string khoa;
        private float diemTB;

        public Student(int sID, string tenSV, string khoa, float diemTB)
        {
            this.sID = sID;
            this.tenSV = tenSV;
            this.khoa = khoa;
            this.diemTB = diemTB;
        }

        public Student()
        {
            sID = 1;
            tenSV = "Nguyen Xuan Huy";
            khoa = "CNTT";
            diemTB = 9;
        }

        public Student(Student student)
        {
            sID = student.sID;
            tenSV = student.tenSV;
            khoa = student.khoa;
            diemTB = student.diemTB;
        }

        public int SID
        {
            get { return sID; }
            set { sID = value; }
        }

        public string TenSV
        {
            get { return tenSV; }
            set { tenSV = value; }
        }

        public string Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }

        public float DiemTB
        {
            get { return diemTB; }
            set { diemTB = value; }
        }

        public void Show()
        {
            Console.WriteLine("MSSV: {0}", this.sID);
            Console.WriteLine("TenSV: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.khoa);
            Console.WriteLine("Diem TB: {0}", this.diemTB);
        }
    }
}
