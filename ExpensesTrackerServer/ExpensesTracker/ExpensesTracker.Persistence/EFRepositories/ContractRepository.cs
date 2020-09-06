using ExpensesTracker.Persistence.Data;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.EFRepositories
{
    public class ContractRepository: RepositoryBase<IContract, ExpensesTrackerContext>, IContractService
    {
        public ContractRepository(ExpensesTrackerContext context) : base(context)
        {

        }
    }
}
