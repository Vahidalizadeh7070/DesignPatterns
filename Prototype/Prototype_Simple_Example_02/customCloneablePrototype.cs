using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Simple_Example_02
{
    // This is custom clonable prototype class
    
    // In this abstract class we implement a clonable prototype
    
    public abstract class CloneablePrototype<T>
    {
        // Shallow copy
        // The Clone method returns MemberwiseClone() as the type of our method to implement shallow copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        // Deep Copy
        // Deep method serialize and deserialize the object 
        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<T>(result);
        }
    }

    //  This partial inherits from Clonable Prototype and pass Employe_Clonable as the <T>
    public partial class Employee_Clonable : CloneablePrototype<Employee_Clonable>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public int DepartmentID { get; set; }

        public Address AddressDetails { get; set; }
        public override string ToString()
        {
            return string.Format(" Name : {0}, DepartmentID : {1} , " +
                "Address : {2}",
                this.Name, this.DepartmentID.ToString(),
                this.AddressDetails.ToString());
        }
    }
}
