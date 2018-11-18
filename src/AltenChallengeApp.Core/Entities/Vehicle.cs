using System;
using AltenChallengeApp.Core.Interfaces;

namespace AltenChallengeApp.Core.Entities
{
    public class Vehicle : BaseEntity, IAuditable
    {
        public string RegistrationNumber { get; set; }
        public Guid CustomerId { get; set; }

        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdatedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
