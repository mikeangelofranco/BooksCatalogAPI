using System.Collections.Generic;
using BooksCatalog._Db.Models;

namespace BooksCatalog._DTO
{
    public class GetBooksResponse
    {
        public IEnumerable<Book> data { get; set; }
    }
}