
namespace TestXmlSerialisation
{
    /// <summary>
    /// A data object for tracking what's in your shopping basket
    /// </summary>
    public class ShoppingBasket
    {
        public string Name { get; set; }
        public int ItemCount { get; set; }
        public things LastThingAdded { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}
