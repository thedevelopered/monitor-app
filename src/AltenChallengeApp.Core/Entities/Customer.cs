using AltenChallengeApp.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace AltenChallengeApp.Core.Entities
{
    public class Customer : BaseEntity, IAuditable
    {
        public Customer()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
