using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
