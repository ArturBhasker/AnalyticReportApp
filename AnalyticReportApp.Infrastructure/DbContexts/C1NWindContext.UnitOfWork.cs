using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticReportApp.Infrastructure.DbContexts
{
    partial class C1NWindContext : IUnitOfWork
    {
        public async System.Threading.Tasks.Task SaveEntitiesAsync(CancellationToken cancellationToken)
        {
            await SaveChangesAsync(cancellationToken);
        }
    }
}
