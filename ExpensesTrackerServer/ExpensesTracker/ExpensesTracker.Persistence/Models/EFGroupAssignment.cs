using ExpensesTracker.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    public class EFGroupAssignment : IGroupAssignment
    {
        [Key]
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "userId")]
        public Guid UserId { get; set; }

        [DataMember(Name = "groupId")]
        public Guid GroupId { get; set; }


        //Navigation
        [ForeignKey(nameof(UserId))]
        public virtual EFUser User { get; set; }

        [ForeignKey(nameof(GroupId))]
        public virtual EFGroup Group { get; set; }
    }
}
