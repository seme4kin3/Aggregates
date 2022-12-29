using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates.CustomerAggregate
{
    public class Customer
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PayMethod> PayMethods { get; set; }

        private Customer()
        {
            Id = Guid.NewGuid().ToString();
            PayMethods = new List<PayMethod>();
        }
        private Customer(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void AddPayMethod(PayMethod payMethod)
        {
            PayMethods.Add(payMethod);
        }
        public override string ToString()
        {
            return $"Покупатель: {Id},Имя: {FirstName},Фамилия: {LastName}";
        }
       
        public class CustomerFactory
        {
            public Customer Create(string firstName, string lastName, PayMethod payMethod)
            {
                var customer = new Customer(firstName,lastName);
                customer.AddPayMethod(payMethod);
                return customer;
            }
        }
    }
}
