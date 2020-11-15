using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Lab02_TiengViet.Bai1_Bai_2
{
    interface IBook
    {
        string this[int index] { get; set; }
        string title { get; set; }
        string author { get; set; }
        string publisher { get; set; }
        string IBSN { get; set; }
        int year { get; set; }
        void show();
    }
}
