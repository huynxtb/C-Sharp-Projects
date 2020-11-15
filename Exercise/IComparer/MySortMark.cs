using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Exercise.IComparer
{
    class MySortMark : IComparer<SinhVien>
    {
        public int Compare(SinhVien x, SinhVien y)
        {
            return x.Mark1.CompareTo(y.Mark1);
        }
    }
}
