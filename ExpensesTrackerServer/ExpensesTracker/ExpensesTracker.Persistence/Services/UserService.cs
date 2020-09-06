using ExpensesTracker.Persistence.Data;
using ExpensesTracker.Persistence.EFRepositories;
using ExpensesTracker.Shared.Interfaces.Models;
using ExpensesTracker.Shared.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpensesTracker.Persistence.Services
{
    public class UserService : UserRepository, IUserService
    {
        public UserService(ExpensesTrackerContext context) : base(context)
        {

        }
    }

    /*
         Recall that the Service classes are designed to do two things:

        Inherit from the Repository classes AND
        Implement their own functionality, which is only necessary when said functionality deals with more than one business object.
     * */
}
