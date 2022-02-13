using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class LazyLoading_Singleton
    {
        private int counter = 0;
        private LazyLoading_Singleton()
        {
            counter++;
            Console.WriteLine("Counter value for lazy loading singleton class:" + counter.ToString());
        }
        private static readonly Lazy<LazyLoading_Singleton> instance = new Lazy<LazyLoading_Singleton>(()=>new LazyLoading_Singleton());

        public static LazyLoading_Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        // This is a void function that print a message to demonstrate the basic behaviour of the LazyLoading_Singleton class
        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
