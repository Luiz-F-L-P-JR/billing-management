﻿
using Billing.Management.Domain.Billing.Repositories.Interfaces;
using Billing.Management.Infra.Data.Context;
using Billing.Management.Infra.Data.Generic;
using Microsoft.Extensions.Logging;

namespace Billing.Management.Infra.Data.Billing.Repositories
{
    public class BillingRepository : RepositoryGeneric<Domain.Billing.Models.Billing>, IBillingRepository
    {
        public BillingRepository(ILogger<Domain.Billing.Models.Billing>? logger, BillingApiContext? context) 
            : base(logger, context)
        {
        }

        public Task<IEnumerable<Domain.Billing.Models.Billing>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
