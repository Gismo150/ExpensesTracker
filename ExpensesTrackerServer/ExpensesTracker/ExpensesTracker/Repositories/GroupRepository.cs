using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Contracts.Models;
using ExpensesTracker.Persistence.Data;
using ExpensesTracker.Persistence.EFRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Repositories
{
    public class GroupRepository : RepositoryBase<Group, ExpensesTrackerContext>
    {
        public GroupRepository(ExpensesTrackerContext context) : base(context)
        {

        }
    }
}
