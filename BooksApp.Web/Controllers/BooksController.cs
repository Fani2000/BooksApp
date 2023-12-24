using BooksApp.Data.Models;
using BooksApp.Services;
using BooksApp.Web.RequestModels;
using Microsoft.AspNetCore.Mvc;

namespace BooksApp.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {

        private readonly ILogger<BooksController> _logger;
        private readonly IBookService bookService;

        public BooksController(ILogger<BooksController> logger, IBookService bookService)
        {
            _logger = logger;
            this.bookService = bookService;
        }

        [HttpGet]
        public ActionResult GetAllBooks()
        {
            return Ok(bookService.GetAllBooks());
        }

        [HttpGet("{id}")]
        public ActionResult GetBook(int id)
        {
            var book = bookService.GetBook(id);

            return Ok(book);
        }

        [HttpPost]
        public ActionResult PostBook([FromBody] NewBookRequest bookRequest)
        {
            var now = DateTime.UtcNow;
            var book = new Book
            {
                CreatedOn = now,
                UpdateOn = now,
                Title = bookRequest.Title,
                Author = bookRequest.Author,
            };

            bookService.AddBook(book);
            return Ok($"Book Created: {book.Title}");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteBook(int id)
        {
            bookService.DeleteBook(id);
            return Ok($"Book deleted with ID: {id}");
        }

    }
}
