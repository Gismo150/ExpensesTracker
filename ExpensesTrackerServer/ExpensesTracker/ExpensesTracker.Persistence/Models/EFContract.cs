using ExpensesTracker.Shared.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Persistence.Models
{
    [DataContract]
    public class EFContract : IContract
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "userId")]
        public Guid UserId { get; set; }

        [DataMember(Name = "price")]
        public double Price { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "startTime")]
        public DateTime StartTime { get; set; }

        [DataMember(Name = "termination")]
        public DateTime Termination { get; set; }

        [DataMember(Name = "accountingPeriod")]
        public string AccountingPeriod { get; set; } //Cron string

        //Navigation
        public EFUser User { get; set; }
    }
}
