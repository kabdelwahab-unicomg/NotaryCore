
using Notary.Data.Main_Core.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Notary.Data.Main_Core.Model;

namespace Notary.Data.Main_Core.Repositories
{
    public class TransactionCommonDataRepository_Core
    {
        protected DB_NotaryMainEntities _context;
        public TransactionCommonDataRepository_Core(DB_NotaryMainEntities context)
        {
            _context = context;
        }

        public bool GetSearchTransactionNumber(string transactionNumber)
        {
            return _context.transaction_common_data.Any(x => x.TransactionNo == transactionNumber);
        }        
    }
}
