using ExpensesTracker.Persistence.Data;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.EFRepositories
{
    public class GroupRepository: RepositoryBase<IGroup, ExpensesTrackerContext>, IGroupService
    {
        public GroupRepository(ExpensesTrackerContext context) : base(context)
        {

        }
    }
}
