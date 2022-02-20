using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Prototype
{
    // Employee Class includes 3 properties and 2 method which implement Shallow and Deep copy
    // Also we override the ToString() method since set a new format that will be match we our return value.
    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Address EmpAddress { get; set; }

        // Shallow Copy
        // Use MemberwiseClone() to create a shallow copy of the current object
        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        // Deep Copy
        public Employee DeepCopy()
        {
            Employee other = (Employee)this.MemberwiseClone();
            other.EmpAddress = new Address(this.EmpAddress.DoorNumber,
                this.EmpAddress.StreetNumber, this.EmpAddress.Zipcode,
                this.EmpAddress.Country);
            return other;
        }

        public override string ToString()
        {
            return string.Format("Emp ID :{0}, Emp Name : {1}, {2}",
                this.ID, this.Name, this.EmpAddress.ToString());
        }
    }
}