using ExpensesTracker.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    [DataContract]
    public class EFReceiptCartItemAssignment : IReceiptCartItemAssignment
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "billId")]
        public Guid ReceiptId { get; set; }

        [DataMember(Name = "cartItemId")]
        public Guid CartItemId { get; set; }

        public virtual EFReceipt Receipt { get; set; }
        public virtual EFCartItem CartItem { get; set; }
    }
}
