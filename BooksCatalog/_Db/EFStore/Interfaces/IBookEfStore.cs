using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BooksCatalog._Db.Models;

namespace BooksCatalog._Db.EFStore
{
    public interface IBookEfStore
    {
         public Task<IEnumerable<Book>> GetBooks(CancellationToken cancellationToken);
    }
}