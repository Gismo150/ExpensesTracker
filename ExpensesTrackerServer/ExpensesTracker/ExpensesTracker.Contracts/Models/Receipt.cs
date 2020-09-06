using ExpensesTracker.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Contracts.Models
{
    public class Receipt: IReceipt
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateOfInvoice { get; set; }
    }
}
