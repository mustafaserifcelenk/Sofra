using Sofra.DAL.Abstract;
using Sofra.DAL.EntityFramework.Context;
using Sofra.DAL.EntityFramework.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofra.DAL.EntityFramework
{
    public class UnitOfWork(SofraContext context) : IUnitOfWork
    {
        private readonly SofraContext _context = context;

        private EFTableRepository _tableRepository;
        private EFCustomerRepository _customerRepository;
        private EFReservationRepository _reservationRepository;

        public ITableRepository Tables => _tableRepository ?? new EFTableRepository(_context);

        public ICustomerRepository Customers => _customerRepository ?? new EFCustomerRepository(_context);
        public IReservationRepository Reservations => _reservationRepository ?? new EFReservationRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
