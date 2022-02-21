using Decorator_DesignPattern_Example01.Decorator;
using System;

namespace Decorator_DesignPattern_Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza PizzaObj = new Pizza();
            string plainPizza = PizzaObj.MakePizza();
            Console.WriteLine(plainPizza);
            PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(PizzaObj);
            string chickenPizza = chickenPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + chickenPizza + "' using ChickenPizzaDecorator");
            VegPizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(PizzaObj);
            string vegPizza = vegPizzaDecorator.MakePizza();
            Console.WriteLine("\n'" + vegPizza + "' using VegPizzaDecorator");
            Console.Read();
        }
    }
}
