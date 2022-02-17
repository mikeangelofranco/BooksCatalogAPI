using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using BooksCatalog._Db.Contexts;
using BooksCatalog._Db.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksCatalog._Db.EFStore
{
    public class BookEfStore : IBookEfStore
    {
        private readonly BookContext _bookCtx;

        public BookEfStore(BookContext bookCtx){
            _bookCtx = bookCtx;
        }


        public async Task<IEnumerable<Book>> GetBooks(CancellationToken cancellationToken)
        {
            try{
                var resp = await _bookCtx.Books.AsNoTracking().ToListAsync(cancellationToken);
                return resp;
            }catch(Exception ex){
                throw new Exception("Error encountered fetching to db...\nInfo: "+ex.Message+"\n"+ex.StackTrace);
            }
        }
    }
}