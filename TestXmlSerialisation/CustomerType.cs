using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXmlSerialisation
{
    /// <summary>
    /// Type Safe Enum Patter
    /// </summary>
    public class CustomerType
    {
        private readonly String name;
        private readonly int value;

        public static readonly CustomerType Normal = new CustomerType (1, "Normal");
        public static readonly CustomerType Gold = new CustomerType (2, "Gold");
        public static readonly CustomerType Platinum = new CustomerType (3, "Platinum");

        public CustomerType()
        {

        }
        private CustomerType(int value, String name)
        {
            this.name = name;
            this.value = value;
        }

        public override String ToString(){
            return name;
        }
    }
}
