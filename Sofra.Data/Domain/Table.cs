using Sofra.Data.Entity;

namespace Sofra.Data.Domain
{
    public class Table : EntityBase, IEntity
    {
        public int Capacity { get; set; }
        public ICollection<Customer>? Customer { get; set; }
        public ICollection<Reservation>? Reservation { get; set; }
    }
}
