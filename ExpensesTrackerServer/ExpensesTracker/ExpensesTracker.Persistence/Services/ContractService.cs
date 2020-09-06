using ExpensesTracker.Persistence.Data;
using ExpensesTracker.Persistence.EFRepositories;
using ExpensesTracker.Shared.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.Services
{
    public class ContractService: ContractRepository, IContractService
    {
        public ContractService(ExpensesTrackerContext context) : base(context)
        {

        }
    }
}
