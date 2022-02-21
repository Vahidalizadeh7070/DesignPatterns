using System;

namespace Facade_DesignPattern_Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // We can use Order class as a facade pattern
            // It means that you can use a class which are responsible for all the order process
            Order order = new Order();
            order.PlaceOrder();

            Console.Read();
        }
    }
}
