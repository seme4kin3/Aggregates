using Aggregates.CustomerAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates.OrderAggregate
{
    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }

    public class Order
    {
        public string Id { get; private set; }
        public Customer Customer { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<Product> Products { get; private set; }
        public Address ShippingAddress { get; private set; }

        private Order()
        {
            Id = Guid.NewGuid().ToString();
            Status = OrderStatus.Processing;
            Products = new List<Product>();
        }

        private Order(Customer customer) : this()
        {
            Customer = customer;
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void SetShippingAddress(Address address)
        {
            ShippingAddress = address;
        }

        public void SetStatus(OrderStatus status)
        {
            Status = status;
        }

        public override string ToString()
        {
            return $"Заказ ID: {Id}, Покупатель: {Customer}, Статус: {Status}";
        }

        public class OrderFactory
        {
            public Order Create(Customer customer)
            {
                var order = new Order(customer);
                return order;
            }
        }
    }
}
