using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Invoke Singleton for user one
            Singleton fromUserOne = Singleton.GetInstance;
            fromUserOne.PrintMessage("This message is comming from user 1 --- Singleton");

            // Invoke Singleton for user two
            Singleton fromUserTwo = Singleton.GetInstance;
            fromUserTwo.PrintMessage("This message is comming from user 2 --- Singleton");

            // Invoke default for user one
            Default fromuseroneDefault = new Default();
            fromuseroneDefault.PrintMessage("This message is comming from user 1 --- Default");

            // Invoke default for user two
            Default fromusertwoDefault = new Default();
            fromuseroneDefault.PrintMessage("This message is comming from user 2 --- Default");

            Console.ReadLine();
        }
    }
}
