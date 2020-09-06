using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Repositories;

namespace ExpensesTracker.Controllers
{
    public class CartItemsController : ExpensesTrackerControllerBase<ICartItem, ICartItemRepository>
    {
        public CartItemsController(ICartItemRepository repository) : base(repository)
        {
        }
    }
}
