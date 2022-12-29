using Aggregates.CustomerAggregate;
using Aggregates.OrderAggregate;
using static Aggregates.OrderAggregate.Order;

namespace Aggregates
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var customerRepository = new CustomerRepository())
            {
                var customerFactory = new Customer.CustomerFactory();

                var customerCard = customerFactory.Create("Ivan", "Ivanov",
                    new CardPayMethod("123456789", CardType.Visa));
                customerRepository.Add(customerCard);

                var customerWallet = customerFactory.Create("Igor", "Smirnov",
                    new WalletPayMethod("89031234450"));
                customerRepository.Add(customerWallet);

                Console.WriteLine(customerCard);
                Console.WriteLine(customerWallet);

                using (var orderRepository = new OrderRepository())
                {
                    var orderFactory = new OrderFactory();

                    var order = orderFactory.Create(customerCard);
                    order.AddProduct(new Product("Banan", 500));
                    order.SetShippingAddress(new Address("Lenina 4","Moscow", "Russia"));
                    orderRepository.Add(order);
                    order.SetStatus(OrderStatus.Delivered);

                    Console.WriteLine(order);

                    order = orderFactory.Create(customerWallet);
                    order.AddProduct(new Product("Blackberry", 1200));
                    order.SetShippingAddress(new Address("Pushkina 10", "Chehov", "Russia"));
                    orderRepository.Add(order);
                    order.SetStatus(OrderStatus.Shipped);

                    Console.WriteLine(order);
                }
            }
        }
    }
}