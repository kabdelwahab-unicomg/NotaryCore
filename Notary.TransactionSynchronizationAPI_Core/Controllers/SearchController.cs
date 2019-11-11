using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Notary.Data.Main_Core.DataBaseContext;
using Notary.Data.Main_Core.Repositories;

namespace Notary.TransactionSynchronizationAPI_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly DB_NotaryMainEntities _context;

        public SearchController(DB_NotaryMainEntities context)
        {
            _context = context;
        }
        [HttpGet("{transactionNumber}")]
        public bool SearchTransactionNumber(string transactionNumber)
        {
            return new TransactionCommonDataRepository_Core(_context).GetSearchTransactionNumber(transactionNumber); ;
        }
        [HttpGet]
        public string SearchTransactionNumber()
        {
            return "Add Id To Query String To Test If It Exist Or Not";
        }
    }
}
