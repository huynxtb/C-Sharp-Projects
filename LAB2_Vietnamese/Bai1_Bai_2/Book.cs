using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BaiTap_Lab02_TiengViet.Bai1_Bai_2
{
    class Book : IBook, IComparable
    {
        public string title;
        public string author;
        public string publisher;
        public string IBSN;
        public int year;
        public ArrayList chapter = new ArrayList();

        public Book(string title, string author, string publisher, string iBSN, int year, ArrayList chapter)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            IBSN = iBSN;
            this.year = year;
            this.chapter = chapter;
        }

        public string this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        string IBook.title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBook.author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBook.publisher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IBook.IBSN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IBook.year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int CompareTo(Object other)
        {
            return title.CompareTo(((Book)other).title);
        }

        public void show()
        {
            Console.WriteLine($"Book {IBSN} [Name = {title}, Author = {author}, Pub = {publisher}, Year = {year}]");
            int count = 0;
            foreach (string i in chapter)
            {
                count++;
                Console.WriteLine($"Chapter {count}: {i}");
            }
        }
    }
}
