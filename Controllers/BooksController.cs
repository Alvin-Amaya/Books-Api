using Books_Api.Entities;
using Books_Api.Features;
using Microsoft.AspNetCore.Mvc;


namespace Books_Api.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksAppService _booksAppService;

        public BooksController(BooksAppService booksAppService)
        {
            this._booksAppService = booksAppService;
        }

        // GET api/<BooksController>
        [HttpGet]
        public IActionResult Get()
        {
            List<Book> books = _booksAppService.GetBooks();
            return Ok(books);
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            Book book = _booksAppService.GetBookById(id);
            if (book == null) return NotFound("Book not found");
            return Ok(book);
        }

        // POST api/<BooksController>
        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            _booksAppService.AddBook(book);
            return Ok("Book added successfully");
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] Book book)
        {
            _booksAppService.UpdateBook(id, book);
            return Ok("Book updated successfully");
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _booksAppService.DeleteBook(id);
            return Ok("Book deleted successfully");
        }
    }
}
