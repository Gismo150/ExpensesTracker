﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Shared.Interfaces
{
    public interface IGroup : IEntity
    {
        public string Name { get; set; }
    }
}
