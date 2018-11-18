using AltenChallengeApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AltenChallengeApp.Infrastructure.EntityConfigurations
{
    public class VehicleConfig : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasQueryFilter(x => !x.IsDeleted);

            builder.HasData(
                new Vehicle()
                {
                    Id = new Guid("cc9d160d-9cb4-43bf-80f5-ef945e619408"),
                    RegistrationNumber = "ABC123",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CustomerId = new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"),
                },
                new Vehicle()
                {
                    Id = new Guid("5c131134-6d49-48f5-ad8d-a2dccf738ce7"),
                    RegistrationNumber = "DEF456",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CustomerId = new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"),
                },
                new Vehicle()
                {
                    Id = new Guid("9fa0be73-befe-4584-9aac-81c04605f905"),
                    RegistrationNumber = "GHI789",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CustomerId = new Guid("4dcd05e1-69c4-49ca-8863-9359858d8ff5"),
                },
                new Vehicle()
                {
                    Id = new Guid("ed6a27e9-7f20-4bf4-896e-4ce540307a73"),
                    RegistrationNumber = "JKL012",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CustomerId = new Guid("6d23151a-6904-4154-af0e-f97ae201c89b"),
                },
                new Vehicle()
                {
                    Id = new Guid("d40f33e3-19f6-4c55-ba5f-28d7a575879f"),
                    RegistrationNumber = "MNO345      ",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CustomerId = new Guid("6d23151a-6904-4154-af0e-f97ae201c89b"),
                },
                new Vehicle()
                {
                    Id = new Guid("b38f284c-d6f3-4732-adc1-94dd56b04e62"),
                    RegistrationNumber = "PQR678",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CustomerId = new Guid("7df039b0-eb98-4415-813a-f930ce3a20c7"),
                },
                new Vehicle()
                {
                    Id = new Guid("e3131a06-3a3f-4fc8-98b4-ee762ca4af83"),
                    RegistrationNumber = "STU901",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CustomerId = new Guid("7df039b0-eb98-4415-813a-f930ce3a20c7"),
                });
        }
    }
}
