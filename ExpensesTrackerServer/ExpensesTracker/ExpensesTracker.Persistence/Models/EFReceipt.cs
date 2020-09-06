using ExpensesTracker.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    [DataContract]
    public class EFReceipt : IReceipt
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        [DataMember(Name = "dateOfInvoice")]
        public DateTime DateOfInvoice { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        //Navigation
        public virtual EFUser User { get; set; }
        public virtual ICollection<EFReceiptCartItemAssignment> ReceiptCartItemAssignments { get; set; }
    }
}
