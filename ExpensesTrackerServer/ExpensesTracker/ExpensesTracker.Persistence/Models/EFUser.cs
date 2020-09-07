using ExpensesTracker.Shared.Enums;
using ExpensesTracker.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    public class EFUser : IUser
    {
        [Key]
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "role")]
        public ERole Role { get; set; }

        [DataMember(Name = "income")]
        public double Income { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }

        //Navigation
        public virtual ICollection<EFGroupAssignment> GroupAssignments { get; set; }
    }
}
