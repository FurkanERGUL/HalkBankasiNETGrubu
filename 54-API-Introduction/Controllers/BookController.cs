using _54_API_Introduction.Models;
using Microsoft.AspNetCore.Mvc;

namespace _54_API_Introduction.Controllers
{
    [ApiController]
    [Route("api/[controller]s/[action]")]
    public class BookController : Controller
    {
        private static List<Book> BookList = new List<Book>()
        {
            new Book()
            {
                Id= 1,
                Title="Kitap-1",
                GenreId= 1,
                PageCount=200,
                PublishDate= new DateTime(1994,10,15)
            },
            new Book()
            {
                Id= 2,
                Title="Kitap-2",
                GenreId= 1,
                PageCount=200,
                PublishDate= new DateTime(1994,1,12)
            },
            new Book()
            {
                Id= 3,
                Title="Kitap-3",
                GenreId= 2,
                PageCount=200,
                PublishDate= new DateTime(1994,7,7)
            },
            new Book()
            {
                Id= 4,
                Title="Kitap-4",
                GenreId= 3,
                PageCount=200,
                PublishDate= new DateTime(1978,10,15)

            },
            new Book()
            {
                Id= 5,
                Title="Kitap-5",
                GenreId= 1,
                PageCount=200,
                PublishDate= new DateTime(1972,10,15)
            },
            new Book()
            {
                Id= 6,
                Title="Kitap-6",
                GenreId= 4,
                PageCount=200,
                PublishDate= new DateTime(1993,10,15)
            },
            new Book()
            {
                Id= 7,
                Title="Kitap-7",
                GenreId= 4,
                PageCount=200,
                PublishDate= new DateTime(1989,10,15)
            },
            new Book()
            {
                Id= 8,
                Title="Kitap-8",
                GenreId= 1,
                PageCount=200,
                PublishDate= new DateTime(1991,10,15)
            },
            new Book()
            {
                Id= 9,
                Title="Kitap-9",
                GenreId= 2,
                PageCount=200,
                PublishDate= new DateTime(1992,10,15)
            },
        };

        //Api methodlarda:
        //-Void, Primitive tip veya complex tip
        //-HttpResponseMessage
        //-IActionResult
        //Endpoints
        [HttpGet]
        public List<Book> Books()
        {
            List<Book> bookList = BookList.OrderBy(x => x.Id).ToList();
            return bookList;
        }

        [HttpGet("Id")]
        public Book GetById(int id)
        {
            var book = BookList.SingleOrDefault(x=>x.Id==id);
            return book;
        }

        [HttpGet("Id")]
        public Book BookById([FromQuery] string id)
        {
            var book = BookList.SingleOrDefault(x=>x.Id == Convert.ToInt32(id)); 
            return book;
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            var book = BookList.SingleOrDefault(x=>x.Title==newBook.Title);
            if (book is not null)
            {
                return BadRequest();
            }
            else
            {
                BookList.Add(newBook);
                return Ok();
            }
        }

        [HttpPut("ID")]
        public IActionResult UpdateBook(int id, [FromBody] Book updateBook)
        {
            var book = BookList.SingleOrDefault(x=>x.Id==id);
            if (book is null)
            {
                return BadRequest();
            }
            else
            {
                book.GenreId = updateBook.GenreId != default ? updateBook.GenreId : book.GenreId;
                book.PageCount= updateBook.PageCount != default? updateBook.PageCount : book.PageCount;
                book.PublishDate= updateBook.PublishDate != default? updateBook.PublishDate : book.PublishDate;
                book.Title= updateBook.Title != "string" ? updateBook.Title : book.Title;
                return Ok();
            }
        }

        [HttpDelete("ID")]
        public void DeleteBook(int id)
        {
            var ff=BookList.SingleOrDefault(x=> x.Id==id);
            BookList.Remove(ff);
        }

        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var book = BookList.SingleOrDefault(x=> x.Id==id);
            if (book==null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NoContent);
            }
            else
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
        }
    }
}
