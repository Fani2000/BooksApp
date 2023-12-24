using BooksApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksApp.Data
{
    public class BooksDbContext: DbContext
    {
        public BooksDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookReview> BookReviews { get; set; }
    }
}
