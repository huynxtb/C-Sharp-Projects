using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Lab02_TiengViet.Bai1_Bai_2
{
    class SortByAuthor : Comparer<Book>
    {
        public override int Compare(Book x, Book y)
        {
            return x.author.CompareTo(y.author);
        }
    }
    class SortByYear : Comparer<Book>
    {
        public override int Compare(Book x, Book y)
        {
            return x.year.CompareTo(y.year);
        }
    }
}
