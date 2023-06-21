using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Application.Persistence.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task CreateQuery(FormattableString query);
        Task UpdateQuery(FormattableString query);
    }
}
