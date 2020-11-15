using Exercise;
using Exercise.IComparer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise
{
    class Program
    {
        public static void Display(List<int> result)
        {
            foreach (int item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static List<int> InputData()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Nhập các phần từ cho danh sách:");
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return list;
        }
        public static void Menu()
        {
            Console.WriteLine("1. Sum Adjective Equals Number");
            Console.WriteLine("2. Gauss Trick");
            Console.WriteLine("3. Merging List");
            Console.WriteLine("4. Count Word");
            Console.WriteLine("5. IComparable");
            Console.WriteLine("6. IComparer");
            Console.WriteLine("0. Thoát");
        }
        public static void SumAdjectiveEqualsNumber(List<int> list)
        {
            int i = 0;
            while (i < list.Count - 1)
            {
                if (list[i] == list[i + 1])
                {
                    list[i] = 2 * list[i];
                    list.RemoveAt(i + 1);
                    i = 0;
                    continue;
                }
                i++;
            }
            Console.WriteLine("Danh sách mới: ");
            Display(list);
        }
        public static void GaussTrick(List<int> list, List<int> result)
        {
            int i = 0;
            while (i < list.Count / 2)
            {
                int sum = list[i] + list[list.Count - 1 - i];
                result.Add(sum);
                i++;
            }

            if (list.Count % 2 != 0)
            {
                result.Add(list[list.Count / 2]);
            }
            Console.WriteLine("Danh sách mới: ");
            Display(result);
        }
        public static void MergingList(List<int> list_1, List<int> list_2, List<int> result)
        {
            if (list_1.Count() > list_2.Count())
            {
                for (int i = 0; i < list_1.Count; i++)
                {
                    if (i < list_1.Count)
                        result.Add(list_1[i]);
                    if (i < list_2.Count)
                        result.Add(list_2[i]);
                }
            }
            else
            {
                for (int i = 0; i < list_2.Count; i++)
                {
                    if (i < list_2.Count)
                        result.Add(list_2[i]);
                    if (i < list_1.Count)
                        result.Add(list_1[i]);
                }
            }
            Console.WriteLine("Danh sách mới: ");
            Display(result);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<int> ls_1 = new List<int>();
            List<int> ls_2 = new List<int>();
            List<int> rs = new List<int>();
            List<string> list = new List<string>();
            Dictionary<string, double> dic = new Dictionary<string, double>();
            List<Student> students = new List<Student>();
            List<SinhVien> sinhViens = new List<SinhVien>();
            int choice;
            do
            {
                Menu();
                Console.WriteLine("Chọn bài tập:");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Sum Adjective Equals Number");
                        while (true)
                        {
                            ls_1 = InputData();
                            SumAdjectiveEqualsNumber(ls_1);
                            ls_1.Clear();
                            Console.WriteLine("Tiếp tục? (Y/N)");
                            string s1 = Console.ReadLine();
                            if (s1.Equals("n")) break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Gauss Trick");
                        while (true)
                        {
                            ls_1 = InputData();
                            GaussTrick(ls_1, rs);
                            ls_1.Clear();
                            rs.Clear();
                            Console.WriteLine("Tiếp tục? (Y/N)");
                            string s2 = Console.ReadLine();
                            if (s2.Equals("n")) break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Merging List");
                        while (true)
                        {
                            ls_1 = InputData();
                            ls_2 = InputData();
                            MergingList(ls_1, ls_2, rs);
                            ls_1.Clear();
                            ls_2.Clear();
                            rs.Clear();
                            Console.WriteLine("Tiếp tục? (Y/N)");
                            string s3 = Console.ReadLine();
                            if (s3.Equals("n")) break;
                        }
                        break;
                    case 4:
                        while (true)
                        {
                            list = Console.ReadLine().Split(' ').ToList();
                            for (int i = 0; i < list.Count(); i++)
                            {
                                if (dic.ContainsKey(list[i]))
                                {
                                    dic[list[i]]++;
                                }
                                else
                                {
                                    dic[list[i]] = 1;
                                }
                            }

                            for (int i = 0; i < dic.Count(); i++)
                            {
                                Console.WriteLine("Key: {0}, Value: {1}",
                                                                        dic.ElementAt(i).Key,
                                                                        dic.ElementAt(i).Value);
                            }
                            Console.WriteLine("Tiếp tục? (Y/N)");
                            string s3 = Console.ReadLine();
                            if (s3.Equals("n")) break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("IComparable Students");
                        students.Add(new Student("SE01", "Huy", 9));
                        students.Add(new Student("SE03", "Hung", 7));
                        students.Add(new Student("SE02", "Nam", 8));
                        students.Add(new Student("SE04", "Duong", 6));
                        Console.WriteLine("Danh sách chưa sắp xếp");
                        foreach (Student item in students)
                        {
                            Console.WriteLine(item.Code1 + " " + item.Name1 + " " + item.Mark1);
                        }
                        Console.WriteLine("===============================");
                        students.Sort();
                        Console.WriteLine("Danh sách sau sắp xếp");
                        foreach (Student item in students)
                        {
                            Console.WriteLine(item.Code1 + " " + item.Name1 + " " + item.Mark1);
                        }
                        Console.WriteLine("===============================");
                        break;
                    case 6:
                        Console.WriteLine("IComparer SinhVien");
                        sinhViens.Add(new SinhVien("SE01", "Huy", 9));
                        sinhViens.Add(new SinhVien("SE03", "Hung", 7));
                        sinhViens.Add(new SinhVien("SE02", "Nam", 8));
                        sinhViens.Add(new SinhVien("SE04", "Duong", 6));
                        sinhViens.Sort(new MySortName());
                        Console.WriteLine("Sắp xếp theo tên");
                        foreach (SinhVien item in sinhViens)
                        {
                            Console.WriteLine(item.Code1 + " " + item.Name1 + " " + item.Mark1);
                        }
                        sinhViens.Sort(new MySortCode());
                        Console.WriteLine("===============================");
                        Console.WriteLine("Sắp xếp theo mã");
                        foreach (SinhVien item in sinhViens)
                        {
                            Console.WriteLine(item.Code1 + " " + item.Name1 + " " + item.Mark1);
                        }
                        sinhViens.Sort(new MySortMark());
                        Console.WriteLine("===============================");
                        Console.WriteLine("Sắp xếp theo điểm");
                        foreach (SinhVien item in sinhViens)
                        {
                            Console.WriteLine(item.Code1 + " " + item.Name1 + " " + item.Mark1);
                        }
                        Console.WriteLine("===============================");
                        break;
                    case 0: return;
                    default:
                        Console.WriteLine("Bạn đã chọn sai!");
                        break;
                }
            } while (true);
        }
    }
}
