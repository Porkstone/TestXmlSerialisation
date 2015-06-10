
using NUnit.Framework;
using System.Diagnostics;
namespace TestXmlSerialisation
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestDotNetSerialiser()
        {
            var testBasket = BasketBuilder.CreateTestBasket();
            var xml = MsSerializer.SerialiseToXml(testBasket);
            Debug.WriteLine(xml);
            Assert.AreEqual(@"<?xml version=""1.0"" encoding=""utf-16""?><ShoppingBasket xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema""><Name>Test Basket</Name><ItemCount>4</ItemCount><LastThingAdded>Thing2</LastThingAdded><CustomerType /></ShoppingBasket>", xml, "Serialised Xml does not match");
        }

        [Test]
        public void TestBenderSerialiser()
        {
            var testBasket = BasketBuilder.CreateTestBasket();
            var xml = BenderSerializer.SerialiseToXml(testBasket);
            Debug.WriteLine(xml);
            Assert.AreEqual(@"<?xml version=""1.0"" encoding=""utf-8""?><ShoppingBasket><Name>Test Basket</Name><ItemCount>4</ItemCount><LastThingAdded>Thing2</LastThingAdded><CustomerType>Gold</CustomerType></ShoppingBasket>", xml, "Serialised Xml does not match");
        }
    }
}
