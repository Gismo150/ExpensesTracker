using ExpensesTracker.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    public class EFGroup : IGroup
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        //Navigation
        public virtual ICollection<EFGroupAssignment> GroupAssignments { get; set; }
    }
}
