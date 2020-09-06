using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces
{
    public interface IReceiptCartItemAssignment : IEntity
    {
        public Guid ReceiptId { get; set; }

        public Guid CartItemId { get; set; }

    }
}
