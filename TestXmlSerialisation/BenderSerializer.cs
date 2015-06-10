
using Bender;
namespace TestXmlSerialisation
{
    public class BenderSerializer
    {
        public static string SerialiseToXml(ShoppingBasket basket)
        {
            return Serialize.Xml(basket, x => x.Serialization(y =>
                y.AsSimpleType<CustomerType>()));
        }
    }
}
