using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionRepository transactionRepository;

        public TransactionController(TransactionRepository transactionRepository)
        {
            this.transactionRepository = transactionRepository;
        }

        [HttpPost,Route("AddTran")]
        public IActionResult AddTran(Transaction tran)
        {
            tran.TransactionId = Guid.NewGuid();
            tran.TransactionDate= DateTime.Now;
            transactionRepository.AddTransaction(tran);
            return Ok(tran);
        }
    }
}
