using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_05
{
    internal class Program
    {
        class LibraryBook
        {
            public string Title;
            public string Author;
            public bool Available;

            public void BorrowBook(LibraryBook y)
            {
                CheckAvailabilty(y);
                if (Available)
                {
                    Console.WriteLine("You have borrowed the book.\n");
                    Available = false;
                }
                else
                {
                    Console.WriteLine("The book has already been taken.\n");
                }
            }
            public LibraryBook(string x, string y, bool z)
            {
                Title = x;
                Author = y;
                Available = z;
            }
        }
        static void CheckAvailabilty(LibraryBook x)
        {
            Console.WriteLine("Book: " + x.Title + "\nAuthor: " + x.Author + "\nAvailability: " + x.Available +"\n\n");
        }
        
        static void Main(string[] args)
        {
            LibraryBook book = new LibraryBook("Harry Potter","J K Rowling",true);
            LibraryBook book1 = new LibraryBook("Madolduwa", "Martin Wickramasinghe", true);
            LibraryBook book2 = new LibraryBook("Sherlock Holmes", "Arthur Conan Doyle", false);

            book.BorrowBook(book);
            book1.BorrowBook(book1);
            book2.BorrowBook(book2);

            CheckAvailabilty(book);
            CheckAvailabilty(book1);
            CheckAvailabilty(book2);

            Console.ReadLine();
        }
    }
}
