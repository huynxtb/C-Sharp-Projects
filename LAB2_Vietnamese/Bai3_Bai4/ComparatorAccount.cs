using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Lab02_TiengViet.Bai3_Bai4
{
    class SortById : Comparer<Account>
    {
        public override int Compare(Account x, Account y)
        {
            return x.id.CompareTo(y.id);
        }
    }
    class SortByName : Comparer<Account>
    {
        public override int Compare( Account x, Account y)
        {
            return x.fname.CompareTo(y.fname);
        }
    }
    class SortByBalance : Comparer<Account>
    {
        public override int Compare(Account x, Account y)
        {
            return x.balance.CompareTo(y.balance);
        }
    }
}
