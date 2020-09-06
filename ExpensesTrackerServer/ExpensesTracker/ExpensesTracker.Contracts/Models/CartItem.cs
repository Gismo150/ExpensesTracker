using ExpensesTracker.Shared.Enums;
using ExpensesTracker.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Contracts.Models
{
    public class CartItem : ICartItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ECategory Category { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public double? OfferPrice { get; set; }
    }
}
