using Microsoft.AspNetCore.Mvc;

namespace BooksApp.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {

        private readonly ILogger<BooksController> _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult GetAllBooks()
        {
            return Ok("Books");
        }
    }
}
