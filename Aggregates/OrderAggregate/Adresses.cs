using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates.OrderAggregate
{
    public class Address
    {
        public string Id { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }

        public Address(string street, string city, string country)
        {
            Id = Guid.NewGuid().ToString();
            Street = street;
            City = city;
            Country = country;
        }
    }
}
