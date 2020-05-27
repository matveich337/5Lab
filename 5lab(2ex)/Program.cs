using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] BookObjects = new Book[5];
            BookObjects[0] = new Book("book1.txt");
            BookObjects[1] = new Book("book2.txt");
            BookObjects[2] = new Book("book3.txt");
            BookObjects[3] = new Book("book4.txt");
            BookObjects[4] = new Book("book5.txt");
            Console.WriteLine(BookObjects[3]);
            for (int i = 0; i < BookObjects.Length; i++)
            {
                BookObjects[i].SearchBook(125415);
            }
            BookObjects[0].CompareBook(BookObjects[1], "amountOfPagesBook");
        }

    }
}
