
using Sofra.Data.Entity;

namespace Sofra.Data.Domain
{
    public class Customer : EntityBase, IEntity
    {
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public ICollection<Reservation>? Reservation { get; set; }
    }
}
