using System;
using System.Collections.Generic;
using System.Text;

namespace DBProvider.Data
{
    interface IDBContextFactory
    {
        ApplicationDbContext CreateDbContext(Tenant tenant, IConfiguration confifuration);
    }
}
