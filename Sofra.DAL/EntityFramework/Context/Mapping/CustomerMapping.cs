using Microsoft.EntityFrameworkCore;
using Sofra.Data.Domain;

namespace Sofra.DAL.EntityFramework.Context.Mapping
{
    public class CustomerMapping : IEntityTypeConfiguration<Customer>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(15).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(100).IsRequired();
            builder.HasData(
                               new Customer { Id = 1, Name = "John Doe", Phone = "1234567890", Email = "johnDoe@mail.com", }
                                          );
        }
    }
}
