using System;
using AltenChallengeApp.Core.Entities;
using AltenChallengeApp.Core.Specificataions;

namespace AltenChallengeApp.Infrastructure.Specifications
{
    public class VehicleFilterSpecification : BaseSpecification<Vehicle>
    {
        public VehicleFilterSpecification(Guid? customerId)
            : base(i => (customerId.HasValue || i.CustomerId == customerId))
        {
            AddInclude(i => i.Customer);
        }
    }
}
