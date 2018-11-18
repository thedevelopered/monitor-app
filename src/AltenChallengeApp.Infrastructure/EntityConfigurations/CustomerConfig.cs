using AltenChallengeApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AltenChallengeApp.Infrastructure.EntityConfigurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasQueryFilter(x => !x.IsDeleted);

            // seed data
            builder.HasData(new Customer()
            {
                Id = new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"),
                Name = "Kalles Grustransporter AB",
                Address = "Cementvägen 8",
                ZipCode = "111 11",
                City = "Södertälje",
                Country = "Sweden",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,

            },
                new Customer()
                {
                    Id = new Guid("6d23151a-6904-4154-af0e-f97ae201c89b"),
                    Name = "Johans Bulk AB",
                    Address = "Balkvägen 12",
                    ZipCode = "222 22",
                    City = "Stockholm",
                    Country = "Sweden",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,

                },
                new Customer()
                {
                    Id = new Guid("7df039b0-eb98-4415-813a-f930ce3a20c7"),
                    Name = "Haralds Värdetransporter AB",
                    Address = "Budgetvägen 1",
                    ZipCode = "333 33",
                    City = "Uppsala",
                    Country = "Sweden",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                });
        }
    }
}
