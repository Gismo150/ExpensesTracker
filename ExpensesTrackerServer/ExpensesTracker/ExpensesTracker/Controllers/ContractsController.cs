using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Contracts.Models;
using ExpensesTracker.Repositories;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ExpensesTrackerControllerBase<IContract, IContractRepository>
    {
        public ContractsController(IContractRepository repository) : base(repository)
        {
        }
    }
}
