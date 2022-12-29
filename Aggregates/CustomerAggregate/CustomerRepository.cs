using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates.CustomerAggregate
{
    public class CustomerRepository : IDisposable
    {
        private List<Customer> _customerList;

        public CustomerRepository()
        {
            _customerList = new List<Customer>();
        }
        public void Add(Customer customer)
        {
            _customerList.Add(customer);
        }

        public void Dispose()
        {

        }
    }
}
