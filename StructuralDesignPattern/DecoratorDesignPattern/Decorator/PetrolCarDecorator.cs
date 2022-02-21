using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorator
{
    // Petrol Decorator inherits from CarDecorator
    class PetrolCarDecorator : CarDecorator
    {
        public PetrolCarDecorator(ICar car) : base(car)
        {
        }

        // We override ManufactureCar to add a new method to ManufactorCar()
        public override ICar ManufactureCar()
        {
            car.ManufactureCar();
            AddEngine(car);
            return car;
        }


        public void AddEngine(ICar car)
        {
            if (car is Car)
            {
                Car Car = (Car)car;
                Car.Engine = "Petrol Engine";
                Console.WriteLine("PetrolCarDecorator added Petrol Engine to the Car : " + car);
            }
        }
    }
}
