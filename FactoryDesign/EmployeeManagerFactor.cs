using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public class EmployeeManagerFactor
    {
        public IEmployeeManager GetEmployeeManager(int employeeId)
        {
            IEmployeeManager returnValue = null;
            if(employeeId % 2==0)
            {
                returnValue = new EvenEmployeeManager();
            }
            else
            {
                returnValue = new OddEmployeeManager();
            }
            return returnValue;
        }
    }
}
