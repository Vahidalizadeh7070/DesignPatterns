using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Simple_Example_02
{
    // Employee model includes some properties and ToString() method that demonstrate values based on these properties
    public partial class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public override string ToString()
        {
            return string.Format(" Name : {0}  " + "Department Id : {1}  {2} ",
                this.Name, this.DepartmentID.ToString(), AddressDetails.ToString());
        }
    }

    // This partial inherits from IClonable that clone a MemberwiseClone of the Employee class
    // It will implemented a shallow copy
    public partial class Employee : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    // It sets the AddressDetails as an Address for Employee Class
    public partial class Employee
    {
        public Address AddressDetails { get; set; } = null;
    }
}
