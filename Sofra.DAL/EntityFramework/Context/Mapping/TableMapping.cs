using Microsoft.EntityFrameworkCore;
using Sofra.Data.Domain;

namespace Sofra.DAL.EntityFramework.Context.Mapping
{
    public class TableMapping : IEntityTypeConfiguration<Table>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Table> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Capacity).IsRequired();
            builder.HasData(
                                              new Table { Id = 1, Capacity = 4 },
                                                                            new Table { Id = 2, Capacity = 6 },
                                                                                                          new Table { Id = 3, Capacity = 4 },
                                                                                                                                        new Table { Id = 4, Capacity = 6 },
                                                                                                                                        new Table { Id = 5, Capacity = 5 },
                                                                                                                                        new Table { Id = 6, Capacity = 4 },
                                                                                                                                        new Table { Id = 7, Capacity = 4 },
                                                                                                                                        new Table { Id = 8, Capacity = 3 },
                                                                                                                                        new Table { Id = 9, Capacity = 2 }
                                                                                                                                                                  );
        }

    }
}
