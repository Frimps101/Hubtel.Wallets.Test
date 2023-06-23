using Hubtel.Wallets.Application.Persistence.Repositories;
using Hubtel.Wallets.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private HubtelDbContext _context;
        public GenericRepository(HubtelDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(FormattableString query)
        {
            // var result = await _context.Database.SqlQuery(query);
            var result =  await _context.Database.ExecuteSqlInterpolatedAsync(query);
            return result;
        }

        public async Task<int> Delete(FormattableString query)
        {
            var result = await _context.Database.ExecuteSqlInterpolatedAsync(query);
            await _context.SaveChangesAsync();
            return result;
        }

        public async Task<IReadOnlyList<T>> GetAll(FormattableString query)
        {
            List<T> result = await _context.Set<T>().FromSqlInterpolated(query).AsNoTracking().ToListAsync();
            return result;
        }

        public async Task<T> GetById(FormattableString query)
        {
            List<T> result = await _context.Set<T>().FromSqlInterpolated(query).AsNoTracking().ToListAsync();
            return result.FirstOrDefault()!;
        }

        public async Task<int> Update(FormattableString query)
        {
            var result = await _context.Database.ExecuteSqlInterpolatedAsync(query);
            await _context.SaveChangesAsync();
            return result;
        }
    }
}
