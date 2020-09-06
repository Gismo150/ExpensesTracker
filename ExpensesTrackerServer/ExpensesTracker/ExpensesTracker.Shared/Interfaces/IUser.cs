using ExpensesTracker.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces
{
    public interface IUser : IEntity
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public ERole Role { get; set; }

        public double Income { get; set; }

        public DateTime Created { get; set; }
    }
}
