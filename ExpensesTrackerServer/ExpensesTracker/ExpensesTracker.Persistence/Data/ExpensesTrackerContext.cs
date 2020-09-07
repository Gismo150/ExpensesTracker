using ExpensesTracker.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.Data
{
    public class ExpensesTrackerContext : DbContext
    {
        public ExpensesTrackerContext(DbContextOptions<ExpensesTrackerContext> options)
            : base(options)
        {
          //  System.Data.Entity.Database.SetInitializer()  ;
        }

        public DbSet<EFUser> User { get; set; }
        public DbSet<EFReceipt> Receipt { get; set; }
        public DbSet<EFGroup> Group { get; set; }
        public DbSet<EFContract> Contract { get; set; }
        public DbSet<EFCartItem> CartItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO define fluent api
           /* modelBuilder.Entity<EFUser>(entity =>
            {
                entity.HasKey(x => x.Id);
            });*/

        }
    }
}
