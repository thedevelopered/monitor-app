using AltenChallengeApp.Core.Entities;
using Xunit;

namespace AltenChallengeApp.Tests.Entity
{
    public class CustomerShould
    {
        [Fact]
        public void ShouldBeSubClassOfBaseEntity()
        {
            var customer = new Customer();
            Assert.True(typeof(Customer).IsSubclassOf(typeof(BaseEntity)));
        }

        [Fact]
        public void ShouldHaveTheVehiclesListInitialized()
        {
            var customer = new Customer();
            Assert.True(customer.Vehicles != null);
        }
    }
}
