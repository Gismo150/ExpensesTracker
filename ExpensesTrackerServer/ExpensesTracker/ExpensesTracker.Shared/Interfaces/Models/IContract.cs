using ExpensesTracker.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces.Models
{
    public interface IContract : IEntity
    {
        public Guid UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime Termination { get; set; }

        public string AccountingPeriod { get; set; } //Cron string
    }
}
