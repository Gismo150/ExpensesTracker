using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExpensesTracker.Contracts.Models;
using ExpensesTracker.Data;
using ExpensesTracker.Shared.Interfaces;
using ExpensesTracker.Repositories;

namespace ExpensesTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ExpensesTrackerControllerBase<User, UserRepository>
    {
        public UsersController(UserRepository repository): base(repository)
        {
        }
    }
}
