using ExpensesTracker.Persistence.Data;
using ExpensesTracker.Persistence.Models;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Persistence.EFRepositories
{
    public class UserRepository : RepositoryBase<IUser, ExpensesTrackerContext>, IUserRepository
    {
        public UserRepository(ExpensesTrackerContext context) : base(context)
        {

        }
    }
}
