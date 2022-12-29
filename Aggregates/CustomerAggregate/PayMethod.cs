using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates.CustomerAggregate
{
    public enum PayMethodType
    {
        OnlineWallet = 1,
        Card = 2
    }
    public abstract class PayMethod
    {
        public string Id { get; set; }
        public Customer Customer { get; set; }
        public PayMethodType PayMethodType { get; set; }
       

        protected PayMethod(PayMethodType type)
        {
            Id = Guid.NewGuid().ToString();
            PayMethodType = type;
        }
    }
}
