using BaiTap_Lab02_TiengViet.Bai1_Bai_2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BaiTap_Lab02_TiengViet.Bai3_Bai4
{
    class AccountList
    {
        private ArrayList accList = new ArrayList();
        public void GUI()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ------------ ACCOUNT MANAGER ------------ ");
                Console.WriteLine("1. Add account");
                Console.WriteLine("2. Delete account");
                Console.WriteLine("3. Show all accounts");
                Console.WriteLine("4. Sort account by Id (Using Comparer)");
                Console.WriteLine("5. Sort account by First Name (Using Comparer)");
                Console.WriteLine("6. Sort account by Balance (Using Comparer)");
                Console.WriteLine("7. Save to FILE");
                Console.WriteLine("8. Load from FILE");
                Console.WriteLine("0. EXIT");
                int choice = Inputer.InputRange("What is your choice?: ", 0, 8);
                Console.WriteLine("");
                switch (choice)
                {
                    case 1: 
                        Add(); break;
                    case 2: 
                        Delete(); break;
                    case 3: 
                        Console.Clear(); 
                        ShowAll(); 
                        Console.ReadLine(); break;
                    case 4: 
                        Sort1(); 
                        Console.ReadLine(); break;
                    case 5: 
                        Sort2(); 
                        Console.ReadLine(); break;
                    case 6: 
                        Sort3(); 
                        Console.ReadLine(); break;
                    case 7: 
                        SaveFile(); 
                        Console.ReadLine(); break;
                    case 8: 
                        LoadFile(); 
                        Console.ReadLine(); break;
                    case 0: return;
                }
            }
        }
        public void Add()
        {
            Console.Clear();
            Console.WriteLine(" ------------ Input Book ------------ ");
            int id = Inputer.InputInt("ID: ");
            string fname = Inputer.InputString("First Name: ");
            string lname = Inputer.InputString("Last Name: ");
            double balance = Inputer.InputDouble("Balance: ");
            accList.Add(new Account(id, fname, lname, balance));
        }
        public void Delete()
        {
            Console.Clear();
            ShowAll();
            int index = Inputer.InputRange("Index to delete: ", 0, accList.Count);
            accList.RemoveAt(index - 1);
        }
        public void ShowAll()
        {
            int count = 0;
            foreach (Account i in accList)
            {
                count++;
                Console.Write($"{count} : ");
                i.show();
            }
        }
        public void Sort1()
        {
            Console.Clear();
            Console.WriteLine("------------ Before Sort ------------");
            Console.WriteLine();
            ShowAll();
            accList.Sort(new SortById());
            Console.WriteLine("------------ After Sort ------------");
            ShowAll();
        }
        public void Sort2()
        {
            Console.Clear();
            Console.WriteLine("------------ Before Sort ------------");
            Console.WriteLine();
            ShowAll();
            accList.Sort(new SortByName());
            Console.WriteLine("------------ After Sort ------------");
            ShowAll();
        }
        public void Sort3()
        {
            Console.Clear();
            Console.WriteLine("------------ Before Sort ------------");
            Console.WriteLine();
            ShowAll();
            accList.Sort(new SortByBalance());
            Console.WriteLine("------------ After Sort ------------");
            ShowAll();
        }
        public void SaveFile()
        {
            StreamWriter st = null;
            try
            {
                string filename = Inputer.InputString("Filename to save: ");
                string fname = filename + ".txt";
                if (File.Exists(fname)) 
                {
                    Console.WriteLine("File " + filename + " is already! System have written in the end of file");
                    st = File.AppendText(fname);
                    foreach (Account i in accList)
                    {
                        st.WriteLine($"{i.id}|{i.fname}|{i.lname}|{i.balance}");
                    }
                }
                else
                {
                    FileStream ft = new FileStream(fname, FileMode.CreateNew, FileAccess.Write);
                    st = new StreamWriter(ft);
                    foreach (Account i in accList)
                    {
                        st.WriteLine($"{i.id}|{i.fname}|{i.lname}|{i.balance}");
                    }
                    ft.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Save Failure");
                st.Close();
                return;
            }

            Console.WriteLine("Save Success");
        }
        public void LoadFile()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"");
            DirectoryInfo dinfo = new DirectoryInfo(path);
            FileInfo[] Files = dinfo.GetFiles("*.txt");

            int length = Files.Count();
            if (length == 0)
            {
                Console.WriteLine("Not found any file in project.");
            }
            else
            {
                FileStream ft = null;
                StreamReader sr = null;
                Console.WriteLine("List file in project: ");
                for (int i = 0; i < length; i++) Console.WriteLine((i + 1) + ". " + Files[i].Name);

                try
                {
                    string filename = Inputer.InputString("Filename to load: ");
                    string fname = filename + ".txt";
                     ft = new FileStream(fname, FileMode.Open, FileAccess.Read);
                     sr = new StreamReader(ft);
                    string temp;
                    accList.Clear();
                    while ((temp = sr.ReadLine()) != null)
                    {
                        string[] data = temp.Split("|");
                        accList.Add(new Account(int.Parse(data[0]), data[1], data[2], double.Parse(data[3])));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Load Failure" + e);
                    sr.Close();
                    ft.Close();
                    return;
                }
                finally
                {
                    sr.Close();
                    ft.Close();
                }
                Console.WriteLine("Load Success. Result: ");
                ShowAll();
            }
        }
    }
}
