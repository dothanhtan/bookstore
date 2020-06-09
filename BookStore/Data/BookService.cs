using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BookService
    {
        public static int PageSize = 4;
        private AppDataContext appDataContext;

        public BookService(AppDataContext appDataContext)
        {
            this.appDataContext = appDataContext;
        }

        public ICollection<Book> ListAllBooks()
        {
            return appDataContext.Book.ToList();
        }

    }
}
