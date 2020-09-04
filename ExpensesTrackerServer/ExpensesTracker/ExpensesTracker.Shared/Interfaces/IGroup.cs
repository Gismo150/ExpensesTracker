using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces
{
    public interface IGroup
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
