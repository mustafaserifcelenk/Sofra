using Sofra.Data.Entity;

namespace Sofra.Data.Domain
{
    public class Reservation : EntityBase, IEntity
    {
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public int CustomerCount { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Table> Tables { get; set; }
    }
}
