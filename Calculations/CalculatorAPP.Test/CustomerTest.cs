using System;
using Xunit;

namespace CalculatorAPP.Test
{
    public class CustomerTest
    {
        [Fact]
        [Trait("Category","Rules")]
        public void CheckNameNorEmpty()
        {
            var customer = new Customer();

            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrEmpty(customer.Name));
        }


        [Fact]
        public void CheckLegiForDiscount()
        {
            var customer = new Customer();

            Assert.InRange<int>(customer.Age, 25 , 40);
   
        }

        [Fact]
        [Trait("Category", "Rules")]
        public void GetOrdersByNameNotNull()
        {
            var customer = new Customer();
            Assert.Throws<ArgumentException>(() => customer.GetOrdersByName(""));

        }

        [Fact]
        [Trait("Category", "Rules")]
        public void GetOrdersByNameNotNullAndCheckMessage()
        {
            var customer = new Customer();
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
