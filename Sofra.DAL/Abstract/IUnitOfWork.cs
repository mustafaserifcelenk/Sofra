using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofra.DAL.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        ITableRepository Tables { get; }
        ICustomerRepository Customers { get; }
        IReservationRepository Reservations { get; }
        Task<int> SaveAsync();

    }
}
