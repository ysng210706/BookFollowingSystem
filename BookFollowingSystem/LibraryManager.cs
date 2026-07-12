using System;
using System.Collections.Generic;
using System.Text;

namespace BookFollowingSystem
{
    internal class LibraryManager
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Kitap eklendi");
        }
        public void ListAllItems()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("ID: " + book.ID + " Title: " + book.Title + " Status: " + book.IsAvailable);
            }
        }
        public void BorrowBook(int id, string memberName)
        {
            foreach (Book book in books)
            {
                if (book.ID == id) { book.BorrowItem(memberName); break; }

            }
        }
        public void ReturnBook(int id) {
            foreach (Book book in books)
            {
                if (book.ID == id) { book.ReturnItem();break; }
                    }
        }
    }
}

