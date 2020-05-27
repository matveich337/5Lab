using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5
{
    class Book
    {
        private string nameAuthor;
        private string nameBook;
        private int codeBook;
        private int yearBook;
        private int amountOfPagesBook;
        private string genreBook;
        public override string ToString()
        {
            return this.nameAuthor + " " + this.nameBook + " " + this.codeBook + " " + this.yearBook + " " + this.amountOfPagesBook + " " + this.genreBook;
        }

        public string NameAuthor{
            get { return nameAuthor; }
        }
        public string NameBook
        {
            get { return nameBook; }
        }
        public int CodeBook
        {
            get { return codeBook; }
            set { codeBook = value; }
        }
        public int YearBook
        {
            get { return yearBook; }
        }
        public int AmountOfPagesBook
        {
            get { return amountOfPagesBook; }
        }
        public string GenreBook
        {
            get { return genreBook; }
        }

        public Book()
        {
        }
        public Book(string author, string name, int code, int year, int amountOfPages, string genre)
        {
            this.nameAuthor = author;
            this.nameBook = name;
            this.codeBook = code;
            this.yearBook = year;
            this.amountOfPagesBook = amountOfPages;
            this.genreBook = genre;
        }
        public Book(string path)
        {
            string[] strFromFile;

            using (StreamReader sr = new StreamReader(path))
            {
                 strFromFile = sr.ReadToEnd().Split(' ');
            }
            this.nameAuthor = strFromFile[0];
            this.nameBook = strFromFile[1];
            this.codeBook = Convert.ToInt32(strFromFile[2]);
            this.yearBook = Convert.ToInt32(strFromFile[3]);
            this.amountOfPagesBook = Convert.ToInt32(strFromFile[4]);
            this.genreBook = strFromFile[5];
        }
        public void SearchBook(int code)
        {
            if (this.CodeBook == code)
            {
                Console.WriteLine(this.NameBook);
            }
        }
        public void CompareBook(Book example1, string field)
        {
            if (field == "nameAuthor")
            {
                if (this.NameAuthor == example1.NameAuthor)
                {
                    Console.WriteLine("Authors are same!");
                }
                else
                {
                    Console.WriteLine("Authors are not same!");
                }
            }
            else if (field == "nameBook")
            {
                if (this.NameBook == example1.NameBook)
                {
                    Console.WriteLine("Name of books are same!");
                }
                else
                {
                    Console.WriteLine("Name of books are not same!");
                }
            }
            else if (field == "codeBook")
            {
                if (this.CodeBook == example1.CodeBook)
                {
                    Console.WriteLine("Code of books are same!");
                }
                else
                {
                    Console.WriteLine("Code of books are not same!");
                }
            }
            else if (field == "yearBook")
            {
                if (this.YearBook == example1.YearBook)
                {
                    Console.WriteLine("Year of books are same!");
                }
                else
                {
                    Console.WriteLine("Year of books are not same!");
                }
            }
            else if (field == "amountOfPagesBook")
            {
                if (this.AmountOfPagesBook == example1.AmountOfPagesBook)
                {
                    Console.WriteLine("Amount of pages are equal");
                }
                else if (this.AmountOfPagesBook > example1.AmountOfPagesBook)
                {
                    Console.WriteLine("Amount of pages of first book is bigger");
                }
                else if (this.AmountOfPagesBook < example1.AmountOfPagesBook)
                {
                    Console.WriteLine("Amount of pages of first book is smaller");
                }
            }
            else if (field == "genreBook")
            {
                if (this.GenreBook == example1.GenreBook)
                {
                    Console.WriteLine("Genre of books are same!");
                }
                else
                {
                    Console.WriteLine("Genre of books are not same!");
                }
            }
            else
            {
                Console.WriteLine("You wrote a wrong genre!");
            }
        }
    }
}
