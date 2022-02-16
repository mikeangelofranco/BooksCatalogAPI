using BooksCatalog.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksCatalog.Contexts {
    public class BookContext : DbContext{
        public BookContext(DbContextOptions options) : base(options)
        {
            
        }

        public  DbSet<Book>  Books {get; set;}
    }
}