using DecoratorDesignPattern.Decorator;
using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car object assign to the ICar
            ICar Car1 = new Car();
            // Invoke ManufactureCar() 
            Car1.ManufactureCar();
            Console.WriteLine(Car1 + "\n");

            // Object of DieselCarDecorator
            // This class inherits from CarDecorator
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(Car1);
            // Now if you invoke the ManufactureCar() it add the Engine to the Car
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();

            // This is another object to assign petrol car decorator
            ICar Car2 = new Car();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(Car2);
            carWithPetrolEngine.ManufactureCar();
            Console.ReadKey();
        }
    }
}
