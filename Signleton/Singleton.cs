using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // Sealed ensures the class being inherited and object instantiation is restricted in the derived class.
    
    public sealed class Singleton
    {
        // We use this property to show the count of each object
        private int counter = 0;

        // Use this object in lock to handle threads
        private static readonly object obj = new object();

        // This private property ensures that only one instance of the object is created based on the null condition
        private static Singleton instance = null;
        
        // If use private constructor, we must define a sealed class as well.
        // In the constructor, we want to sum counter with 1.
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter value for singleton class:" + counter.ToString());
        }

        // public property is used to return only one instance of the class
        public static Singleton GetInstance
        {
            get
            {
                if(instance==null)
                {
                    // Use lock keyword to control thread
                    lock(obj)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        // This is a void function that print a message to demonstrate the basic behaviour of the singleton
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        // If we want to use nested class which inherited from base class, we should remove sealed keyword.
        // *** The significant point is that the sealed keyword and we can use it when we have a private constuctor and 
        // also it is not going to contain any nested class.

        //public class DerivedClass : Singleton
        //{

        //}
    }
}
