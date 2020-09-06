﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces
{
    public interface IGroupAssignment : IEntity
    {
        public Guid UserId { get; set; }
        public Guid GroupId { get; set; }
    }
}
