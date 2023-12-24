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
            context.Add(book);
            context.SaveChanges();
        }

        public void DeleteBook(int bookId)
        {
            var bookToDelete = context.Books.Find(bookId);

            if(bookToDelete != null)
            {
                context.Remove(bookToDelete);
                context.SaveChanges();
            }else
            {
                throw new InvalidOperationException("Can't delet book that doesn't exists.");
            }
        }

        public List<Book> GetAllBooks()
        {
            return context.Books.ToList();
        }

        public Book GetBook(int bookId)
        {
            var book = context.Books.FirstOrDefault(x => x.Id == bookId); 

            if(book == null)
            {
                return null;
            }

            return book;
        }
    }
}
