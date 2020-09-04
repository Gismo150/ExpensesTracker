using ExpensesTracker.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Contracts.Models
{
    [DataContract]
    public class Group: IGroup
    {
        [DataMember(Name = "id")]
        public Guid Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
    }
}
