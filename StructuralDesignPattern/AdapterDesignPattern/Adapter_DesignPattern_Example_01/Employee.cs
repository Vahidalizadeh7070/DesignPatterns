using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DesignPattern_Example_01
{
    // The Employe model with 3 properties and a constructor
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public Employee(int id, string name,  decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
    }
}
