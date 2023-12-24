namespace BooksApp.Data.Models
{
    public class BookReview
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Author { get; set; }
        public string ReviewAuthor { get; set; }
        public Book book { get; set; }
    }
}
