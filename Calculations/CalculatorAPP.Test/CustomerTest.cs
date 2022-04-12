using Xunit;

namespace CalculatorAPP.Test
{
    public class CustomerTest
    {
        [Fact]
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
    }
}
