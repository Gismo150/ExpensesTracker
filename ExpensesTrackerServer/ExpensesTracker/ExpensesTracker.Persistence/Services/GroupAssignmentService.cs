using ExpensesTracker.Persistence.Data;
using ExpensesTracker.Persistence.EFRepositories;
using ExpensesTracker.Shared.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.Services
{
    public class GroupAssignmentService: GroupAssignmentRepository, IGroupAssignmentService
    {
        public GroupAssignmentService(ExpensesTrackerContext context) : base(context)
        {

        }
    }
}
