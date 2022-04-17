﻿using AnalyticReportApp.Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticReportApp.Infrastructure.Repositories
{
    internal class C1NWindRepository : IC1NWindRepository
    {
        private readonly C1NWindContext _c1NWindContext;

        public C1NWindRepository(C1NWindContext c1NWindContext)
        {
            _c1NWindContext = c1NWindContext ?? throw new ArgumentNullException(nameof(c1NWindContext));
        }

        public async Task<IList<Car>> GetCarsAsync(
            string brand,
            CancellationToken cancellationToken)
        {
            return await _c1NWindContext
                 .Cars
                 .AsNoTracking()
                 .Where(car => car.Brand == brand)
                 .ToListAsync(cancellationToken);
        }

        public async Task<int> GetCarsCountAsync(
CancellationToken cancellationToken)
        {
            return await _c1NWindContext
                .Cars
     .AsNoTracking()
     .CountAsync(cancellationToken);
        }

        public async Task<double> GetAverageFuelAsync(
CancellationToken cancellationToken)
        {
            return             await _c1NWindContext
.Cars
.AsNoTracking()
.AverageAsync(car => car.Liter);
        }
    }
}
