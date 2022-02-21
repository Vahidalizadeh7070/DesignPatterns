using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    // This interface is a simple method that returns a car
    public interface ICar
    {
        ICar ManufactureCar();
    }
}
