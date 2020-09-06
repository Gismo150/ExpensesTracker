using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Contracts.Models;
using ExpensesTracker.Data;
using ExpensesTracker.Persistence.EFRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Repositories
{
    public class UserRepository: RepositoryBase<User, ExpensesTrackerContext>
    {
        public UserRepository(ExpensesTrackerContext context): base(context)
        {

        }
        // We can add new methods specific to the specific repository here in the future
    }
}
