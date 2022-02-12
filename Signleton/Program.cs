using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(()=> UserOne(), ()=> UserTwo());
            
            // Invoke default class for user one
            Default fromuseroneDefault = new Default();
            fromuseroneDefault.PrintMessage("This message is comming from user 1 --- Default");

            // Invoke default class for user two
            Default fromusertwoDefault = new Default();
            fromuseroneDefault.PrintMessage("This message is comming from user 2 --- Default");

            Console.ReadLine();
        }

        // Invoke UserTwo function in Main() method
        private static void UserTwo()
        {
            // Invoke Singleton for user two
            Singleton fromUserTwo = Singleton.GetInstance;
            fromUserTwo.PrintMessage("This message is comming from user 2 --- Singleton");
        }

        // Invoke UserOne function in Main() method
        private static void UserOne()
        {
            // Invoke Singleton for user one
            Singleton fromUserOne = Singleton.GetInstance;
            fromUserOne.PrintMessage("This message is comming from user 1 --- Singleton");
        }
    }
}
