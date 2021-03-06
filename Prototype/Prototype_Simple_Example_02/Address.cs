using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Simple_Example_02
{
    // Address class includes some properties which refer to the address details
    // This class also override ToString() method to demonstrate in a specific format
    public class Address
    {
        public Address() { }

        public int DoorNumber { get; set; }
        public int StreetNumber { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return string.Format("AddressDetails : Door : {0}, Street: {1}, ZipCode : {2}," +
                " Country : {3}", this.DoorNumber, this.StreetNumber, this.Zipcode.ToString(),
                this.Country);
        }
    }
}
