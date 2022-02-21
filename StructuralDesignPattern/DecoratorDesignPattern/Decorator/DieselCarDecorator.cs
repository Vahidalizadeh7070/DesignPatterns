using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorator
{
    // Diesel Decorator inherits from CarDecorator

    public class DieselCarDecorator : CarDecorator
    {
        public DieselCarDecorator(ICar car) : base(car)
        {
        }
        
        // We override ManufactureCar to add a new method to ManufactorCar()
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();

            // The ICar is the argument of AddEngine
            AddEngine(car);
            return car;
        }

        public void AddEngine(ICar car)
        {
            if (car is Car)
            {
                Car Car = (Car)car;
                Car.Engine = "Diesel Engine";
                Console.WriteLine("DieselCarDecorator added Diesel Engine to the Car : " + car);
            }
        }
    }
}
