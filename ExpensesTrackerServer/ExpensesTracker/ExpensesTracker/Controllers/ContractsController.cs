using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Contracts.Models;
using ExpensesTracker.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractsController : ExpensesTrackerControllerBase<Contract, ContractRepository>
    {
        public ContractsController(ContractRepository repository) : base(repository)
        {
        }
    }
}
