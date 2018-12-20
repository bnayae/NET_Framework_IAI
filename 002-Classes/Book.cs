using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Classes
{
    public class Book
    {
        //private  field means the class is the only one who can change it
        private string bookId ;
        //readonly means : private  + only in C'tor or inintialization list
        private readonly int nReaders = 56;

        //const : static + readonly -> you cannot change and you must initialize here
        private const double PI = 3.14;

        //public for reading , private for settings
        public string Data { get; private set; }

        //Property with logic
        private string _title;
        //Same with Property + logic
        public string title
        {
            get
            {
                return "the book is " + _title;
            }
            private set
            {
                if(value.Length >= 6)
                {
                    _title = value;
                }
            }
        }

        

        //readonly with Property
        public string AuthorName { get; }
        public string AuthorName2 { get; } = "John";

        //C# 6
        public string Publisher => "Packet Publishing";


        public Book()
        {
            bookId=  "ISBN:556345434";
            nReaders = 57; //final chance to change the value
            Console.WriteLine(Book.PI);
            title = "myTitle";

            AuthorName = "John Greesham";
        }

        public void DoWithOtherBook(Book other)
        {
            other.bookId = "XXX";
        }

        public void DoSomething()
        {
            bookId = "SSWSSS";
            //AuthorName = "John Greesham";
            //nReaders++;
        }

        public string getBookId()
        {
            return bookId;
        }

    }
}
