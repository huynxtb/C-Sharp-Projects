using BaiTap_Lab02_TiengViet.Bai1_Bai_2;
using BaiTap_Lab02_TiengViet.Bai3_Bai4;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace BaiTap_Lab02_TiengViet
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("1. Bài 1 + Bài 2");
            Console.WriteLine("2. Bài 3 + Bài 4");
            Console.WriteLine("0. Thoát");

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.Clear();
                Menu();
                int choice = Inputer.InputInt("Chọn chương trình muốn chạy!: ");
                switch (choice)
                {
                    case 1:
                        BookLists book = new BookLists();
                        book.GUI();
                        break;
                    case 2:
                        AccountList acc = new AccountList();
                        acc.GUI();
                        break;
                    case 0: return;
                }

            } while (true);
        }
    }
}
