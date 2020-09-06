using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExpensesTracker.Contracts.Models;

namespace ExpensesTracker.Data
{
    public class ExpensesTrackerContext : DbContext
    {
        public ExpensesTrackerContext (DbContextOptions<ExpensesTrackerContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Receipt> Receipt { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Contract> Contract { get; set; }
        public DbSet<CartItem> CartItem { get; set; }
    }
}
