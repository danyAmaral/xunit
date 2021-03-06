using System;

namespace CalculatorAPP
{
    public class Customer
    {
        public string Name = "Maria";
        public int Age = 35;

        public virtual int GetOrdersByName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name can't be nulll!");
            }
            return 100;
        }

        public string GetFullName(string firstName, string lastName) {
            return  $"{firstName} {lastName}";
        }
    }


    public class LoyalCustomer : Customer {

        public int Discount { get;set; }

        public LoyalCustomer()
        {
            Discount = 10;
        }

        public override int GetOrdersByName(string name)
        {
            return 101;
        }
    }

    public static class CustomerFactory { 
    
        public static Customer CreateCustomerInstance(int orderCount)
        {
            if (orderCount > 100)
                return new LoyalCustomer();

            return new Customer();
        }
    }


}
