using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpensesTracker.Persistence.Services;
using ExpensesTracker.Shared.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ExpensesTracker.Configuration
{
    public static class PersistenceConfiguration
    {
       public static void ConfigurePersistenceServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IReceiptService, ReceiptService>();
            services.AddScoped<ICartItemService, CartItemService>();
            services.AddScoped<IContractService, ContractService>();

            services.AddScoped<IGroupAssignmentService, GroupAssignmentService>();
            services.AddScoped<IReceiptCartItemAssignmentService, ReceiptCartItemAssignmentService>();
        }
    }
}
