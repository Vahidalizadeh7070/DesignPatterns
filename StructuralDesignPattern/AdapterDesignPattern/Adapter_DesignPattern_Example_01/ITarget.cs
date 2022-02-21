using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_DesignPattern_Example_01
{
    // Target interface is going to use in our adapter class
    public interface ITarget
    {
        void ProcessEmployeeList(string[,] employeesArray);
    }
}
