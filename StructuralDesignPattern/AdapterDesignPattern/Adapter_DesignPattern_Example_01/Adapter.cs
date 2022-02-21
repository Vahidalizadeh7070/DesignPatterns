using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DesignPattern_Example_01
{
    // Usually Adapter plays a translator role 
    // In this example, The ProcessEmployeeList method get string array from client and then translate it to the Employee Object.
    public class Adapter : ITarget
    {
        EmployeeList employeeList = new EmployeeList();
        public void ProcessEmployeeList(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Salary = null;

            List<Employee> listEmployee = new List<Employee>();

            // These 2 for loop get the strings that will be come from the client
            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }

                // Now add these values to the Employee model 
                listEmployee.Add(new Employee(Convert.ToInt32(Id), Name, Convert.ToDecimal(Salary)));
            }

            // Adapter class converted Array of Employee to List of Employee
            // Now we can use the listEmployee in DisplayList method to demonstrate as an Employee

            // DisplayList method just have accept a type of Employee
            employeeList.DisplayList(listEmployee);
        }
    }
}
