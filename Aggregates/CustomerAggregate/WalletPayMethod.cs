using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates.CustomerAggregate
{
    public class WalletPayMethod : PayMethod
    {
        public string PhoneNumber { get; set; }

        public WalletPayMethod(string phoneNumber) : base(PayMethodType.OnlineWallet)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
