using ExpensesTracker.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces.Models
{
    public interface ICartItem: IEntity
    {

        public string Name { get; set; }

        public ECategory Category { get; set; } //Electronic, Food, etc.

        public string Description { get; set; }

        public double Price { get; set; }

        public double? OfferPrice { get; set; } //Lowest known price
    }
}
