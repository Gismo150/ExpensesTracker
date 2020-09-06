using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Contracts.Models;
using ExpensesTracker.Persistence.EFRepositories;
using ExpensesTracker.Repositories;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ExpensesTrackerControllerBase<IGroup, IGroupRepository>
    {
        public GroupsController(IGroupRepository repository) : base(repository)
        {
        }
    }
}
