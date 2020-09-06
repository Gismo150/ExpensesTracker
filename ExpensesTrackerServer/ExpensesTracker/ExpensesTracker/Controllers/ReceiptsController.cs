using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptsController : ExpensesTrackerControllerBase<IReceipt, IReceiptRepository>
    {
        public ReceiptsController(IReceiptRepository repository) : base(repository)
        {
        }
    }
}
