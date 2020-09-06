using ExpensesTracker.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    public class EFGroupAssignment : IGroupAssignment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid GroupId { get; set; }


        //Navigation
        public virtual EFUser User { get; set; }
        public virtual EFGroup Group { get; set; }
    }
}
