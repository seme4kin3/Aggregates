using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates.OrderAggregate
{
    public class OrderRepository : IDisposable
    {
        private List<Order> _orders;

        public OrderRepository()
        {
            _orders = new List<Order>();
        }

        public void Add(Order order)
        {
            _orders.Add(order);
        }

        public void Dispose()
        {

        }
    }
}
