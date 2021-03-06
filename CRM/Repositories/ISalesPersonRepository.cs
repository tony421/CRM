﻿using CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Repositories
{
    public interface ISalesPersonRepository : IRepository<SalesPerson>
    {
        IEnumerable<SalesPerson> GetByBranch(Guid branchId);

        IEnumerable<SalesPerson> GetByPartner(Guid partnerId);
    }
}
