using System;

namespace Adapter_DesignPattern_Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an istance
            string[,] employeesArray = new string[5, 3]
            {
                {"1","Mike","10000"},
                {"2","Vahid","20000"},
                {"3","Liza","30000"},
                {"4","John","40000"},
                {"5","Sara","50000"}
            };

            // Set a new Adapter to ITarget instance (target) 
            // It has an access to its method
            ITarget target = new Adapter();
            Console.WriteLine("The employee list implemented by Adapter design pattern\n");
            
            target.ProcessEmployeeList(employeesArray);
            Console.Read();
        }
    }
}
