using ExpensesTracker.Shared.Enums;
using ExpensesTracker.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    public class EFUser : IUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ERole Role { get; set; }
        public double Income { get; set; }
        public DateTime Created { get; set; }

        //Navigation
        public virtual ICollection<EFGroupAssignment> GroupAssignments { get; set; }
    }
}
