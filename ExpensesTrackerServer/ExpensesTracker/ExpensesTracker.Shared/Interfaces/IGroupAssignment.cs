using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces
{
    public interface IGroupAssignment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid GroupId { get; set; }
    }
}
