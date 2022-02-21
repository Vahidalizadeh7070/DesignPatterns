using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorator
{
    // This abstract class is the Decorator 
    public abstract class CarDecorator : ICar
    {
        protected ICar car;
        public CarDecorator(ICar car)
        {
            this.car = car;
        }
        // It is goint to be overridden by the child classes
        public virtual ICar ManufactureCar()
        {
            return car.ManufactureCar();
        }
    }
}
