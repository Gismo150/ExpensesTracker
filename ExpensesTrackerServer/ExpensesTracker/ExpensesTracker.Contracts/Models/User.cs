using ExpensesTracker.Shared.Enums;
using ExpensesTracker.Shared.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ExpensesTracker.Contracts.Models
{
    [DataContract]
    class User : IUser
    {
        [DataMember(Name ="id")]
        public Guid Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "role")]
        public ERole Role { get; set; }
        [DataMember(Name = "income")]
        public double Income { get; set; }

        [DataMember(Name = "created")]
        public DateTime Created { get; set; }
    }
}
