using System;
using System.Text;

namespace SimpleCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Manager manager = new Manager();
            while (true)
            {
                int choice = manager.menu();
                switch (choice)
                {
                    case 1:
                        manager.calculatorTwoDigt();
                        break;
                    case 2:
                        manager.checkIsLeapYear();
                        break;
                    case 3:
                        manager.calculatorSumS();
                        break;
                    case 4:
                        manager.chooseCalculation();
                        break;
                    case 5:
                        manager.ptb2();
                        break;
                    case 6:
                        manager.processString();
                        break;
                    case 7:
                        manager.gameRandomNumber();
                        break;
                    case 8:
                        int n;
                        Console.WriteLine("Nhập tham số n: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        int sum = manager.sum(n);
                        Console.WriteLine("S = {0} ", sum);
                        Console.WriteLine();
                        break;
                    case 0:
                        Console.WriteLine("Bạn đã thoát!");
                        Console.ReadKey();
                        return;
                }
            }
        }
    }
}
