using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // This class is going to compare with the Singleton class and show that fact the Singleton class is
    // a class that can have only one object (an instance of the class) at a time.

    // The result of this class is that, every time that the constructor runs, we add a new object
    // in the opposite of Singleton patterns which have one object.
    public class Default
    {
        // We use this property to show the count of each object
        private int counter = 0;

        // In the constructor, we want to demonstrate the counter
        public Default()
        {
            counter++;
            Console.WriteLine("value for default class:" + counter.ToString());
        }

        // This is a void function that print a message to demonstrate the basic behaviour of the singleton
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
