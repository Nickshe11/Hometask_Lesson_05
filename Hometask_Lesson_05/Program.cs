﻿using System.Data.Common;
using static System.Console;

namespace Hometask
{
    class MyClass
    {
        class Journal //Класс для задания 1
        {
            private int _number;
            public int Number
            {
                get { return _number; }
                set { _number = value >= 0 ? value : 0; }
            }

            public static Journal operator -(Journal journal, int num)
            {
                journal._number = journal._number - num >= 0 ? journal._number - num : 0;
                return journal;
            }
            public static Journal operator -(Journal journal, Journal journal1)
            {
                journal._number = journal._number - journal1._number >= 0 ? journal._number - journal1._number : 0;
                return journal;
            }
            public static Journal operator +(Journal journal, int num)
            {
                journal._number = journal._number + num;
                return journal;
            }
            public static Journal operator +(Journal journal, Journal journal1)
            {
                journal._number = journal._number + journal1._number;
                return journal;
            }
            public override bool Equals(Object obj)
            {
                return this.ToString()==obj.ToString();
            }
            public override int GetHashCode()
            {
                return this.ToString().GetHashCode(); 
            }
            public static bool operator ==(Journal journal, int num)
            {
               return journal.Equals(num);
            }
            public static bool operator !=(Journal journal, int num)
            {
                return !(journal.Equals(num));
            }

        }

        //Класс для задания 3
        class Book
        {
            public string Author { get; set; }
            public string Name { get; set; }

            public override string ToString()
            {
                return "Author: "+Author+" Name: "+ Name;
            }
            public override bool Equals(object obj)
            {
                if (obj == null) return false;
                Book objBook = obj as Book;
                if (objBook == null) return false;
                else return Equals(objBook);                
            }
            public bool Equals (Book other)
            {
                if ((this.Author == other.Author) && (this.Name == other.Name)) return true;
                else return false;
            }
            public override int GetHashCode()
            {
                return Author.GetHashCode()+Name.GetHashCode();
            }
        }
        class Storage
        {
            public List<Book> list = new List<Book>();
        }
        static void Main(string[] args)
        {
            Journal jr = new Journal();
            Journal jr1 = new Journal();
            jr.Number = 6;
            jr1.Number = 2;
            jr += 5;
            jr += jr1;
            WriteLine($"{jr.Number}");
            WriteLine( jr.Number!=6);

        }
    }
}