using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Prototype
{
    // Address class includes a constructor and some properties 
    // We override the ToString() method to create a format that will be match with our return value
    public class Address
    {
        public Address() { }
        public Address(int doorNumber, int streetNumber,
            int zipCode, string country)
        {
            this.Country = country;
            this.DoorNumber = doorNumber;
            this.StreetNumber = streetNumber;
            this.Zipcode = zipCode;
        }

        public int DoorNumber { get; set; }
        public int StreetNumber { get; set; }
        public int Zipcode { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return string.Format(Environment.NewLine + "Emp Address: {0}",
                string.Format("{0}, {1}, {2}, {3}",
                this.DoorNumber, this.StreetNumber,
                this.Zipcode.ToString(), this.Country));
        }
    }
}
