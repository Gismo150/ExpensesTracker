using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces.Models
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
