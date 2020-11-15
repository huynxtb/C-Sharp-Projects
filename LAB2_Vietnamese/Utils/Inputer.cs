using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Lab02_TiengViet.Bai1_Bai_2
{
    class Inputer
    {
        public static int InputInt(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    int year = int.Parse(Console.ReadLine());
                    return year;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something wrong! Please input interger number");
                }
            }
        }
        public static int InputRange(string s, int a, int b)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    int temp = int.Parse(Console.ReadLine());
                    if (temp < a || temp > b)
                    {
                        Console.WriteLine("Range {0} - {1}", a, b);
                        throw new Exception("Out of range");
                    }
                    return temp;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something wrong! Please input interger number");
                }
            }
        }
        public static double InputDouble(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    return double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something wrong! Please input double number");
                }
            }
        }
        public static string InputString(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    string temp = Console.ReadLine();
                    return temp;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something wrong! Please input string");
                }
            }
        }
    }
}
