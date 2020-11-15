using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Lab02_TiengViet.Bai3_Bai4
{
    class Account
    {
        public int id;
        public string fname;
        public string lname;
        public double balance;

        public Account(int id, string fname, string lname, double balance)
        {
            this.fname = fname;
            this.lname = lname;
            this.id = id;
            this.balance = balance;
        }
        public void show()
        {
            Console.WriteLine($"Account {id} [First Name = {fname}, Last Name = {lname}, Banlance = {balance}]");
        }
    }
}
