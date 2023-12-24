using BooksApp.Data.Models;

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
