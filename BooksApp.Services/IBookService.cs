using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.Services
{
    public interface IBookService
    {
        public List<Book> GetAllBooks();
        public Book GetBook(int bookId);
        public void AddBook(Book book);
        public void DeleteBook(int bookId);

    }
}
