
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
            Assert.AreEqual("", xml, "Serialised Xml does not match");
        }
    }
}
