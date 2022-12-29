using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates.CustomerAggregate
{
    public enum CardType
    {
        Visa =1,
        MasterCard =2
    }
    public class CardPayMethod:PayMethod
    {
        public string CardNumber {get; set;}
        public CardType CardType { get; set;}

        public CardPayMethod(string cardNumber, CardType cardType) : base(PayMethodType.Card)
        {
            CardNumber = cardNumber;
            CardType = cardType;
        }
    }
}
