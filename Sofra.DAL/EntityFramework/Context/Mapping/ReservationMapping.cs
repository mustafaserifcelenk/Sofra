using Microsoft.EntityFrameworkCore;
using Sofra.Data.Domain;

namespace Sofra.DAL.EntityFramework.Context.Mapping
{
    public class ReservationMapping : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.Note).HasMaxLength(200);
            builder.HasOne(x => x.Customer).WithMany(x => x.Reservation).HasForeignKey(x => x.CustomerId);
        }
    }
}
