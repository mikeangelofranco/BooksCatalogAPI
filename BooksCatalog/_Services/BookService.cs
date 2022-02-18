using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BooksCatalog._Db.EFStore;
using BooksCatalog._Db.Models;
using BooksCatalog._DTO;

namespace BooksCatalog._Services
{
    public class BookService : IBookService
    {
        private readonly IBookEfStore _bookStore;
        public BookService(IBookEfStore bookStore){
            _bookStore = bookStore;
        }

        public async Task<GetBooksResponse> GetBooks(CancellationToken cancellationToken)
        {
            try{
                GetBooksResponse resp = new GetBooksResponse(); 
                resp.data = await _bookStore.GetBooks(cancellationToken);
                return resp;
            }catch(Exception ex){
                throw new Exception("Error encountered fetching to store...\nInfo: " + ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}