using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BooksCatalog._Db.EFStore;
using BooksCatalog._Db.Models;

namespace BooksCatalog._Services
{
    public class BookService : IBookService
    {
        private readonly IBookEfStore _bookStore;
        public BookService(IBookEfStore bookStore){
            _bookStore = bookStore;
        }

        public async Task<IEnumerable<Book>> GetBooks(CancellationToken cancellationToken)
        {
            try{
                return await _bookStore.GetBooks(cancellationToken);
            }catch(Exception ex){
                throw new Exception("Error encountered fetching to store...\nInfo: " + ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}