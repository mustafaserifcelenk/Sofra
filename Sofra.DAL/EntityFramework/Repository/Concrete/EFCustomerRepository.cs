using Microsoft.EntityFrameworkCore;
using Sofra.DAL.Abstract;
using Sofra.Data.Domain;

namespace Sofra.DAL.EntityFramework.Repository.Concrete
{
    public class EFCustomerRepository : EfEntityRepositoryBase<Customer>, ICustomerRepository
    {
        public EFCustomerRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}