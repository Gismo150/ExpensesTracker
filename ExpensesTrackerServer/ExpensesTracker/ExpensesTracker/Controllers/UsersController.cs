using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExpensesTracker.Contracts.Models;
using ExpensesTracker.Shared.Interfaces;
using ExpensesTracker.Repositories;
using ExpensesTracker.Shared.Interfaces.Repositories;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Services;

namespace ExpensesTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ExpensesTrackerControllerBase<IUser, IUserService>
    {
        public UsersController(IUserService repositoryService): base(repositoryService)
        {
        }
    }
}
