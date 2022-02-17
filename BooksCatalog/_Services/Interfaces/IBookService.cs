using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BooksCatalog._Db.Models;

namespace BooksCatalog._Services
{
    public interface IBookService
    {
        public Task<IEnumerable<Book>> GetBooks(CancellationToken cancellationToken);
    }
}