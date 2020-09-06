using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces.Models
{
    public interface IReceipt : IEntity
    {

        public Guid UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateOfInvoice { get; set; }

    }
}
