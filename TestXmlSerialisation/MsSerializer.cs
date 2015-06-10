using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace TestXmlSerialisation
{
    public static class MsSerializer
    {
        public static string SerialiseToXml(ShoppingBasket _basket)
        {
            var serializer = new XmlSerializer(_basket.GetType());
            StringWriter sww = new StringWriter();
            XmlWriter writer = XmlWriter.Create(sww);
            serializer.Serialize(writer, _basket);
            return sww.ToString(); // Your XML
        }
    }
}
