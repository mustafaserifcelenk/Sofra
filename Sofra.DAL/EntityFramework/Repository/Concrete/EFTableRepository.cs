using Microsoft.EntityFrameworkCore;
using Sofra.DAL.Abstract;
using Sofra.Data.Domain;

namespace Sofra.DAL.EntityFramework.Repository.Concrete
{
    public class EFTableRepository : EfEntityRepositoryBase<Table>, ITableRepository
    {
        public EFTableRepository(DbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
