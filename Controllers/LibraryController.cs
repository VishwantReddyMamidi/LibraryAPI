using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private LibraryDBContext _context;

        public LibraryController()
        {
            _context = new LibraryDBContext();
        }
        [HttpGet] //SHOWS ALL BOOKS
        public IEnumerable<Books> GetAllBooks()
        {

            return _context.Books_1.ToList();

        }

        [HttpGet("{id}")]  // GET PARTICULAR BOOK
        public Books GetSingleBook(Guid id)
        {
            return _context.Find<Books>(id);
        }
    }
}