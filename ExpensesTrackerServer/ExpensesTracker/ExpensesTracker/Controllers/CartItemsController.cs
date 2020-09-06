using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Contracts.Models;
using ExpensesTracker.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Controllers
{
    public class CartItemsController : ExpensesTrackerControllerBase<CartItem, CartItemRepository>
    {
        public CartItemsController(CartItemRepository repository) : base(repository)
        {
        }
    }
}
