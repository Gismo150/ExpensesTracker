﻿using ExpensesTracker.Shared.Enums;
using ExpensesTracker.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    [DataContract]
    public class EFCartItem : ICartItem
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "category")]
        public ECategory Category { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "price")]
        public double Price { get; set; }

        [DataMember(Name = "offerPrice")]
        public double? OfferPrice { get; set; }

        //Navigation
        public virtual ICollection<EFReceiptCartItemAssignment> ReceiptCartItemAssignments { get; set; }
    }
}