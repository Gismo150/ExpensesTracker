using ExpensesTracker.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    [DataContract]
    public class EFReceiptCartItemAssignment : IReceiptCartItemAssignment
    {
        [Key]
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "billId")]
        public Guid ReceiptId { get; set; }

        [DataMember(Name = "cartItemId")]
        public Guid CartItemId { get; set; }

        [ForeignKey(nameof(ReceiptId))]
        public virtual EFReceipt Receipt { get; set; }

        [ForeignKey(nameof(CartItemId))]
        public virtual EFCartItem CartItem { get; set; }
    }
}
