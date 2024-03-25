using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSProjeDemo1.Abstract;

namespace CSProjeDemo1.Interface
{
    public interface IMember
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MemberNo { get; set; }
        public List<Book>? BorrowedBooks { get; set; }

        void BorrowBook(Book book);
        void ReturnBook(Book book);
    }
}
