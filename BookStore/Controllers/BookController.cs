using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private BookService _bookService;
        private readonly ILogger<BookController> _logger;
        public BookController(ILogger<BookController> logger, BookService bookService)
        {
            this._logger = logger;
            _bookService = bookService;
        }
        
    }
}
