using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Contracts.Models;
using ExpensesTracker.Persistence.EFRepositories;
using ExpensesTracker.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ExpensesTrackerControllerBase<Group, GroupRepository>
    {
        private readonly IRepository<Group> groupRepository;
        public GroupsController(GroupRepository repository) : base(repository)
        {
            this.groupRepository = repository;
        }

        /*[HttpGet("{name}")]
        public Task<IActionResult> findByName(string name)
        {
            return null;
        }*/
    }
}
