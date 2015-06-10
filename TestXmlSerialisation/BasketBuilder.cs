using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXmlSerialisation
{
    public static class BasketBuilder
    {
        public static ShoppingBasket CreateTestBasket()
        {
            var basket = new ShoppingBasket();
            basket.Name = "Test Basket";
            basket.ItemCount = 4;
            basket.LastThingAdded = things.Thing2;
            basket.CustomerType = CustomerType.Gold;
            return basket;
        }
    }
}
