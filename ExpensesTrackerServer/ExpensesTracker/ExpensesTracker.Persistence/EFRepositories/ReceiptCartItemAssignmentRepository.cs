using ExpensesTracker.Persistence.Data;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.EFRepositories
{
    public class ReceiptCartItemAssignmentRepository: RepositoryBase<IReceiptCartItemAssignment, ExpensesTrackerContext>, IReceiptCartItemAssignmentService
    {
        public ReceiptCartItemAssignmentRepository(ExpensesTrackerContext context) : base(context)
        {

        }
    }
}
