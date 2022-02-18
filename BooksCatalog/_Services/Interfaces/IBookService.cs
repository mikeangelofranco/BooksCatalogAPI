using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BooksCatalog._Db.Models;
using BooksCatalog._DTO;

namespace BooksCatalog._Services
{
    public interface IBookService
    {
        public Task<GetBooksResponse> GetBooks(CancellationToken cancellationToken);
    }
}