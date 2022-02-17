using BooksCatalog._Db.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksCatalog._Db.Contexts {
    public class BookContext : DbContext{
        public BookContext(DbContextOptions options) : base(options)
        {
            
        }

        public  DbSet<Book>  Books {get; set;}
    }
}