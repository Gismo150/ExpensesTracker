using ExpensesTracker.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    public class EFGroup : IGroup
    {
        [Key]
        public Guid Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        //Navigation
        public virtual ICollection<EFGroupAssignment> GroupAssignments { get; set; }
    }
}
