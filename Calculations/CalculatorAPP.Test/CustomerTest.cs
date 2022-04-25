using System;
using Xunit;

namespace CalculatorAPP.Test
{
    [Collection("Customer")]
    public class CustomerTest 
    {
        private readonly CustomerFixture _customerFixture;
        public CustomerTest(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;   
        }

        [Fact]
        [Trait("Category","Rules")]
        public void CheckNameNorEmpty()
        {
            var customer = _customerFixture.Customer;

            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }


        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = _customerFixture.Customer;

            Assert.InRange<int>(customer.Age, 25 , 40);
   
        }

        [Fact]
        [Trait("Category", "Rules")]
        public void GetOrdersByNameNotNull()
        {
            var customer = _customerFixture.Customer;
            Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));

        }

        [Fact]
        [Trait("Category", "Rules")]
        public void GetOrdersByNameNotNullAndCheckMessage()
        {
            var customer = _customerFixture.Customer;
            var exeptionDetails = Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));

            Assert.Equal("Name can't be nulll!", exeptionDetails.Message);
        }


        [Fact]
        public void LoyalCustomerForOrdersG100()
        {
            var customer = CustomerFactory.CreateCustomerInstance(105);
            var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);

            Assert.Equal(10, loyalCustomer.Discount);
        }
    }
}
