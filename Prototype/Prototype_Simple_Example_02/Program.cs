using System;

namespace Prototype_Simple_Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // ShallowCopy();
             ShallowCopyRef();
            //PrototypeDemo();
        }

        // Shallow copy method

        public static void ShallowCopy()
        {
            // Create an object from Employee.cs
            Employee empJohn = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "John",
                DepartmentID = 150,
            };

            

            // Use Shallow copy to copy and object and change the value 
            Employee empSam = (Employee)empJohn.Clone();

            // Set a new name for that object
            // All the remain properties will be the same as before
            empSam.Name = "Sam Paul";

            // Write empSam and empJohn
            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());

            Console.WriteLine("Changed Johns DepartmentID to 161");
            empJohn.DepartmentID = 161;
            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());

            Console.ReadLine();
        }

        // This method is a refresh method for shallow copy
        // We set new empJohn with AddressDetails
        public static void ShallowCopyRef()
        {
            Employee empJohn = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "John",
                DepartmentID = 150,
                AddressDetails = new Address()
                {
                    DoorNumber = 10,
                    StreetNumber = 20,
                    Zipcode = 90025,
                    Country = "US"
                }
            };

            Console.WriteLine(empJohn.ToString());

            // Clone the Employee and copy from the empJohn object and set it to the new variable 
            Employee empSam = (Employee)empJohn.Clone();
            
            // Update properties that is related with empSam
            empSam.Name = "Sam Paul";
            empSam.DepartmentID = 151;
            empSam.AddressDetails.StreetNumber = 21;
            empSam.AddressDetails.DoorNumber = 11;

            Console.WriteLine(empSam.ToString());

            Console.WriteLine("Modified Details of John");
            
            // Update AddressDetails property that is related with empJohn
            // empJohn is concrete objecte 
            // empSam is the copy of empJohn
            // In ShallowCopy if your change the subClasses, on the copy object all subclasses will be changed
            // (empJohn.Address Details and empSam.AddressDetails will be changed with new values)
            empJohn.AddressDetails.DoorNumber = 30;
            empJohn.AddressDetails.StreetNumber = 40;
            empJohn.DepartmentID = 160;

            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());

            Console.ReadLine();
        }

        // This method is a clonable method to implement Deep Copy to update the specific object

        private static void PrototypeDemo()
        {
            // Create a new object 
            Employee_Clonable empJohn = new Employee_Clonable()
            {
                Id = Guid.NewGuid(),
                Name = "John",
                DepartmentID = 150,
                AddressDetails = new Address()
                {
                    DoorNumber = 10,
                    StreetNumber = 20,
                    Zipcode = 90025,
                    Country = "US"
                }
            };

            Console.WriteLine(empJohn.ToString());

            // Use Deep Copy method in customClonablePrototype
            Employee_Clonable empSam = (Employee_Clonable)empJohn.DeepCopy();

            // Set new value to the empSam object
            empSam.Name = "Sam Paul";
            empSam.DepartmentID = 151;
            empSam.AddressDetails.StreetNumber = 21;
            empSam.AddressDetails.DoorNumber = 11;

            Console.WriteLine(empSam.ToString());

            Console.WriteLine("Modified Details of John");
            
            // Update the AddressDetails of empJohn which it is the basic object 
            empJohn.AddressDetails.DoorNumber = 30;
            empJohn.AddressDetails.StreetNumber = 40;
            empJohn.DepartmentID = 160;

            // In the result, it will demonstrate both object (main and copy) and as you can see the specific object (empJohn) has just updated
            // and the copy object(empSam) has not changed
            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());
            Console.ReadLine();
        }
    }
}
