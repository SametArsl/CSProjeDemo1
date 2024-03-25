using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;

namespace CSProjeDemo1.Concrete
{
    public class Library
    {
        public List<Book> BookList { get; set; }
        public List<Member> MemberList { get; set; }

        public Library()
        {
            BookList = new List<Book>();
            MemberList = new List<Member>();
        }

        // Writes All Library Members and Books Borrowed by Members
        public void ShowMembers()
        {
            Console.WriteLine("Members :");
            foreach (Member member in MemberList)
            {
                // Writes Member No and Member's Full Name
                Console.WriteLine($"Member No: {member.MemberNo}");
                Console.WriteLine($"Name: {member.Name} {member.Surname}");
                // Empty Line
                Console.WriteLine();
                // Writes Borrowed Books by Member
                Console.WriteLine("Borrowed Books: ");

                foreach (Book book in member.BorrowedBooks)
                {
                    Console.WriteLine($"ISBN: {book.ISBN}, Title: {book.Title}");
                }
                // Empty Line
                Console.WriteLine();
            }
        }

        // Writes All Books
        public void ShowBooks()
        {
            Console.WriteLine("Books :");

            foreach (Book book in BookList)
            {
                Console.WriteLine($"ISBN: {book.ISBN}, Title: {book.Title}, Author: {book.Author}, Status: {book.BookStatus} ");
            }
        }

        // Borrow Book
        public void BorrowBook(Book book, Member member)
        {
            if (book.BookStatus == Status.AvailableForBorrowing)
            {
                member.BorrowBook(book);

                Console.WriteLine($"{book.Title} was borrowed by {member.Name} {member.Surname} !");
            }

            else
            {
                Console.WriteLine($"{book.Title} is not available at the moment !");
            }
        }

        // Return Book
        public void ReturnBook(Book book, Member member)
        {
            if (member.BorrowedBooks.Contains(book))
            {
                member.ReturnBook(book);

                Console.WriteLine($"{book.Title} was returned by {member.Name} {member.Surname}");
            }
            else
            {
                Console.WriteLine($"{book.Title} was not borrowed by {member.Name} {member.Surname}");
            }
        }
    }
}
