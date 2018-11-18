using AltenChallengeApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AltenChallengeApp.Infrastructure.Data
{
    public class Seed
    {
        //public static async System.Threading.Tasks.Task SeedAsync(AltenChallengeAppDbContext dbContext, int? retry = 0)
        //{

        //    int retryForAvailability = retry.Value;
        //    try
        //    {
        //        // TODO: Only run this if using a real database
        //        dbContext.Database.Migrate();

        //        if (!dbContext.Customers.Any())
        //        {
        //            dbContext.Customers.AddRange(GetPreconfiguredCustomers());

        //            await dbContext.SaveChangesAsync();
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //static List<Customer> GetPreconfiguredCustomers()
        //{
        //    return new List<Customer>(){
        //        new Customer()
        //        {
        //            Id = new Guid(),
        //            Name = "Kalles Grustransporter AB",
        //            Address = "Cementvägen 8",
        //            ZipCode = "111 11",
        //            City = "Södertälje",
        //            Country = "Sweden",
        //            CreatedAt = DateTime.Now,
        //            UpdateddAt = DateTime.Now,
        //            Vehicles = new List<Vehicle>()
        //            {
        //                new Vehicle()
        //                {
        //                    Id = new Guid(),
        //                    RegistrationNumber = "ABC123",
        //                    CreatedAt = DateTime.Now,
        //                    UpdateddAt = DateTime.Now,
        //                },
        //                new Vehicle()
        //                {
        //                    Id = new Guid(),
        //                    RegistrationNumber = "DEF456",
        //                    CreatedAt = DateTime.Now,
        //                    UpdateddAt = DateTime.Now,
        //                },
        //                new Vehicle()
        //                {
        //                    Id = new Guid(),
        //                    RegistrationNumber = "GHI789",
        //                    CreatedAt = DateTime.Now,
        //                    UpdateddAt = DateTime.Now,
        //                },
        //            }
        //        },
        //        new Customer()
        //        {
        //            Id = new Guid(),
        //            Name = "Johans Bulk AB",
        //            Address = "Balkvägen 12",
        //            ZipCode = "222 22",
        //            City = "Stockholm",
        //            Country = "Sweden",
        //            CreatedAt = DateTime.Now,
        //            UpdateddAt = DateTime.Now,
        //            Vehicles = new List<Vehicle>()
        //            {
        //                new Vehicle()
        //                {
        //                    Id = new Guid(),
        //                    RegistrationNumber = "JKL012",
        //                    CreatedAt = DateTime.Now,
        //                    UpdateddAt = DateTime.Now,
        //                },
        //                new Vehicle()
        //                {
        //                    Id = new Guid(),
        //                    RegistrationNumber = "MNO345      ",
        //                    CreatedAt = DateTime.Now,
        //                    UpdateddAt = DateTime.Now,
        //                }
        //            }
        //        },
        //        new Customer()
        //        {
        //            Id = new Guid(),
        //            Name = "Haralds Värdetransporter AB",
        //            Address = "Budgetvägen 1",
        //            ZipCode = "333 33",
        //            City = "Uppsala",
        //            Country = "Sweden",
        //            CreatedAt = DateTime.Now,
        //            UpdateddAt = DateTime.Now,
        //            Vehicles = new List<Vehicle>()
        //            {
        //                new Vehicle()
        //                {
        //                    Id = new Guid(),
        //                    RegistrationNumber = "PQR678",
        //                    CreatedAt = DateTime.Now,
        //                    UpdateddAt = DateTime.Now,
        //                },
        //                new Vehicle()
        //                {
        //                    Id = new Guid(),
        //                    RegistrationNumber = "STU901",
        //                    CreatedAt = DateTime.Now,
        //                    UpdateddAt = DateTime.Now,
        //                }
        //            }
        //        }
        //    };
        //}
    }
}