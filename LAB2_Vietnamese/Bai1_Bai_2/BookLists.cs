using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Lab02_TiengViet.Bai1_Bai_2
{
    class BookLists
    {
        private ArrayList list = new ArrayList();
        public void GUI()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------ BOOK MANAGER ------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Sort by Title (Using IComparable)");
                Console.WriteLine("4. Sort by Author (Using Comparer)");
                Console.WriteLine("5. Sort by Year (Using Comparer)");
                Console.WriteLine("0. EXIT");
                int choice = Inputer.InputRange("What is your choice?: ", 0, 5);
                Console.WriteLine("");
                switch (choice)
                {
                    case 1: 
                        Add(); break;
                    case 2: 
                        Console.Clear();
                        ShowAll(); 
                        Console.ReadLine(); break;
                    case 3: 
                        Sort1(); 
                        Console.ReadLine(); break;
                    case 4: 
                        Sort2(); 
                        Console.ReadLine(); break;
                    case 5: 
                        Sort3(); 
                        Console.ReadLine(); break;
                    case 0: return;
                }
            }
        }
        public void Add()
        {
            Console.Clear();
            Console.WriteLine("------------ Input Book ------------");
            string Title = Inputer.InputString("Title: ");
            string Author = Inputer.InputString("Author: ");
            string Publisher = Inputer.InputString("Publisher: ");
            string IBSN = Inputer.InputString("IBSN: ");
            int year = Inputer.InputInt("Year: ");
            ArrayList chapter = new ArrayList();
            do
            {
                string chap = Inputer.InputString($"Input chapter {chapter.Count + 1} (0 to EXIT)");
                if (chap.Equals("0")) break;
                chapter.Add(chap);
            } while (true);
            list.Add(new Book(Title, Author, Publisher, IBSN, year, chapter));
        }
        public void ShowAll()
        {
            foreach (Book item in list)
            {
                item.show();
            }
        }
        public void Sort1()
        {
            Console.Clear();
            Console.WriteLine("------------ Before Sort ------------");
            Console.WriteLine();
            ShowAll();
            list.Sort();
            Console.WriteLine("------------ After Sort ------------");
            ShowAll();
        }
        public void Sort2()
        {
            Console.Clear();
            Console.WriteLine("------------ Before Sort ------------");
            Console.WriteLine();
            ShowAll();
            list.Sort(new SortByAuthor());
            Console.WriteLine("------------ After Sort ------------");
            ShowAll();
        }
        public void Sort3()
        {
            Console.Clear();
            Console.WriteLine("------------ Before Sort ------------");
            Console.WriteLine();
            ShowAll();
            list.Sort(new SortByYear());
            Console.WriteLine("------------ After Sort ------------");
            ShowAll();
        }
    }
}
