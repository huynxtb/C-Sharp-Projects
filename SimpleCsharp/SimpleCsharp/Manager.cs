using java.lang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleCsharp
{
    class Manager
    {
        public void calculatorTwoDigt()
        {
            double sum = 0;
            Console.WriteLine("Nhập số a: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số b: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tổng {0} + {1} = {2}", a, b, (a + b));
            Console.WriteLine();
        }

        public void checkIsLeapYear()
        {
            Console.WriteLine("Nhập năm muốn kiểm tra : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0} là năm nhuận ", year);
            }
            else
            {
                Console.WriteLine("{0} không phải là năm nhuận ", year);
            }
            Console.WriteLine();
        }

        public void calculatorSumS()
        {
            Console.WriteLine("Nhập số tự nhiên n > 0:");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1 / (double)i;
            }
            Console.WriteLine("Tổng S= {0}", sum);
            Console.WriteLine();
        }

        public void gameRandomNumber()
        {
            Random random = new Random();
            int com = random.Next(0, 100);
            int human, count = 3;
            bool flag = true;
            Console.WriteLine("COM: {0}", com);
            Console.WriteLine("Máy tính đã chọn ra 1 số ngẫu nhiên từ 0 -> 100 ( Bạn có 3 lần đoán )");
            Console.WriteLine("Xin mời đoán: ");
            while (true)
            {
                human = Convert.ToInt32(Console.ReadLine());
                count--;
                if (human > 100 || human < 0)
                {
                    Console.WriteLine("Số chỉ nằm trong khoảng 0 -> 100", com);
                    flag = false;
                }
                if (human > com)
                {
                    Console.WriteLine("Số của bạn lớn hơn số máy", com);
                    flag = false;
                }
                else if(human < com)
                {
                    Console.WriteLine("Số của bạn nhỏ hơn số máy", com);
                    flag = false;
                } 
                else if (human == com)
                {
                    Console.WriteLine("Chúc mừng bạn đã đoán trúng, Số của máy là {0}", com);
                    Console.WriteLine();
                    flag = true;
                    return;
                }

                if (!flag)
                {
                    Console.WriteLine("Bạn đã đoán sai!");
                    Console.WriteLine("Bạn còn {0} lần đoán.", count);
                    Console.WriteLine();
                    if (count == 0)
                    {
                        Console.WriteLine("Bạn đã thua!");
                        Console.WriteLine("Số của máy là {0}", com);
                        Console.WriteLine();
                        return;
                    }
                }
            }
            Console.WriteLine();
        }

        public void processString()
        {
            int chu_hoa = 0, chu_thuong = 0, so = 0, khoang_trang = 0;
            Console.WriteLine("Mời bạn nhập chuỗi: ");
            string text = Convert.ToString(Console.ReadLine());
            khoang_trang = text.Count(Char.IsWhiteSpace);
            string[] list_string = text.Split(',', ' ');
            foreach (string s in list_string)
            {
                if (Regex.IsMatch(s, @"^\d+$")) so++;
                if (!s.Any(char.IsUpper) && !Regex.IsMatch(s, @"^\d+$")) chu_thuong++;
                if (s.Any(char.IsUpper)) chu_hoa++;
            }

            Console.WriteLine("Chuỗi của bạn có {0} chữ hoa", chu_hoa);
            Console.WriteLine("Chuỗi của bạn có {0} chữ thường", chu_thuong);
            Console.WriteLine("Chuỗi của bạn có {0} chữ số", so);
            Console.WriteLine("Chuỗi của bạn có {0} khoảng trắng", khoang_trang);
            Console.WriteLine();
        }

        public void chooseCalculation()
        {
            double a, b;
            double result = 0;
            char op;
            bool flag = true;
            Console.WriteLine("Nhập số a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập phép tính bạn muốn thực hiện ( +, -, *, / ): ");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Không thể thực hiện phép chia cho 0");
                        Console.WriteLine();
                        flag = false;
                        break;
                    }
                    else
                        result = a / b;
                    break;
                default:
                    Console.WriteLine("Phép tính không hợp lệ");
                    flag = false;
                    Console.WriteLine();
                    break;
            }
            if (flag)
                Console.WriteLine("Kết quả của phép tính {0} {1} {2} = {3} ", a, op, b, result);
            Console.WriteLine();
        }

        public void ptb2()
        {
            double a, b, c;
            double delta = 0;

            Console.WriteLine("Nhập tham số a: ");
            a = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Phương trình của bạn sẽ có dạng ax+b=0");
            }
            Console.WriteLine("Nhập tham số b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập tham số c: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phương trình của bạn sẽ có dạng 0=0 => PT vô số nghiệm");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("PT {0}x + {1} = 0 vô nghiệm", b, c);
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("PT {0}x + {1} = 0 có 1 nghiệm x = {2}", b, c, (-b / a));
                    Console.WriteLine();
                }
            }
            else
            {
                delta = System.Math.Pow(b, 2) - 4 * a * c;

                if (delta < 0)
                {
                    Console.WriteLine("PT {0}x^2 + {1}x + {2} = 0 vô nghiệm", a, b, c);
                    Console.WriteLine();
                }
                else if (delta == 0)
                {
                    Console.WriteLine("PT {0}x^2 + {1}x + {2} = 0 có 1 nghiệm duy nhất x = {3}", a, b, c, (-b / (2 * a)));
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("PT {0}x^2 + {1}x + {2} = 0 có 2 nghiệm phân biệt x1 = {3}, x2 = {4}",
                        a, b, c, ((-b + System.Math.Sqrt(delta)) / (2 * a)), ((-b - System.Math.Sqrt(delta)) / (2 * a)));
                    Console.WriteLine();
                }
            }
        }

        public int menu()
        {
            int choice;
            Console.WriteLine("1. Tính tổng 2 số nguyên");
            Console.WriteLine("2. Kiểm tra năm nhuận");
            Console.WriteLine("3. Tính tổng S=1+1/2+1/3+..+1/n");
            Console.WriteLine("4. Thực hiện phép toán được chỉ định cho 2 số");
            Console.WriteLine("5. Tính phương trình bậc 2");
            Console.WriteLine("6. Đếm số lượng chữ hoa, thường, số, khoảng trắng");
            Console.WriteLine("7. Game đoán số từ 0 đến 100");
            Console.WriteLine("8. Tính Sum = 1 + 2 + 3 +...+ n");
            Console.WriteLine("0. Thoát");
            Console.WriteLine("Lựa chọn chức năng của chương trình:");
            choice = checkInputLimit(0, 7);
            Console.WriteLine();
            return choice;
        }

        public int checkInputLimit(int min, int max)
        {
            while (true)
            {
                try
                {
                    int result = Convert.ToInt32(Console.ReadLine());
                    if (result < min || result > max)
                    {
                        Console.WriteLine("Hãy nhập số trong khoảng {0}-{1}", min, max);
                        Console.WriteLine();
                    }
                    return result;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine("Hãy nhập số trong khoảng {0}-{1}", min, max);
                    Console.WriteLine();
                }
            }
        }

        public double checkInputDouble(string message)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(message);
                    double result = Convert.ToDouble(Console.ReadLine());
                    if (result < 0)
                    {
                        throw new NumberFormatException();
                    }
                    return result;
                }
                catch (System.Exception e)
                {
                   
                }
            }
        }

        //public int checkInputInt()
        //{
        //    try
        //    {

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public int sum(int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                s += i;
            }
            return s;
        }


    }
}
