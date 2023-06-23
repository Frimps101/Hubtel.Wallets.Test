using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Application.Persistence.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAll(FormattableString query);
        Task<T> GetById(FormattableString query);
        Task<int> Update(FormattableString query);
        Task<int> Delete(FormattableString query);
        Task<int> Add(FormattableString query);
    }
}
