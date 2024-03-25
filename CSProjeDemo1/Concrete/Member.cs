using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo1.Abstract;
using CSProjeDemo1.Enum;
using CSProjeDemo1.Interface;

namespace CSProjeDemo1.Concrete
{
    public class Member : IMember
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MemberNo { get; set; }
        public List<Book>? BorrowedBooks { get; set; }

        public void BorrowBook(Book book)
        {
            book.BookStatus = Status.Borrowed;
            BorrowedBooks.Add(book);
        }

        public void ReturnBook(Book book)
        {
            book.BookStatus = Status.AvailableForBorrowing;
            BorrowedBooks.Remove(book);
        }
    }
}
