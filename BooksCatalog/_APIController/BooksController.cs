using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BooksCatalog._Db.Models;
using BooksCatalog._DTO;
using BooksCatalog._Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BooksCatalog._APIController
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private readonly IBookService _bookSvc;

        public BooksController(ILogger<BooksController> logger, IBookService bookSvc)
        {
            _logger = logger;
            _bookSvc = bookSvc;
        }
        //ADD DTOS
        //COMPLETE CRUD OPERATIONS

        [HttpGet]
        public async Task<ActionResult<GetBooksResponse>> Get(CancellationToken cancellationToken)
        {
            try{
               var resp = await _bookSvc.GetBooks(cancellationToken);
               return Ok(resp);
            }catch(Exception ex){
                throw new Exception("Error encountered fetching Books...\nInfo: " + ex.Message + "\n" + ex.StackTrace);
            } 

        }
    }
}
