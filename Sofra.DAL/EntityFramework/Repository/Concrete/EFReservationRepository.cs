using Microsoft.EntityFrameworkCore;
using Sofra.DAL.Abstract;
using Sofra.Data.Domain;

namespace Sofra.DAL.EntityFramework.Repository.Concrete
{
    public class EFReservationRepository : EfEntityRepositoryBase<Reservation>, IReservationRepository
    {
        public EFReservationRepository(DbContext dbContext) : base(dbContext)
        {

        }
    }
}
