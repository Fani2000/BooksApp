using BooksApp.Data;
using BooksApp.Data.Models;

namespace BooksApp.Services
{
    public class BookServices : IBookService
    {
        private readonly BooksDbContext context;

        public BookServices(BooksDbContext context)
        {
            this.context = context;
        }

        public void AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
