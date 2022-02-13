using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(()=> UserOne(), ()=> UserTwo());

            //========================================================================================
            // We can use Parallel.Invoke instead in this way. We implemented the functions before and you can uncomment those if you need.
            LazyLoading_Singleton fromUserTwo = LazyLoading_Singleton.GetInstance;
            fromUserTwo.PrintMessage("This message is comming from user 3 --- LazyLoading_Singleton");
            LazyLoading_Singleton fromUserFour = LazyLoading_Singleton.GetInstance;
            fromUserFour.PrintMessage("This message is comming from user 4 --- LazyLoading_Singleton");
            //========================================================================================
            
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

        // You can uncomment functions and use Parallel.Invoke to use it in Main() function

        //private static void LazyUserThree()
        //{
        //    // Invoke Singleton for user two
        //    LazyLoading_Singleton fromUserThree = LazyLoading_Singleton.GetInstance;
        //    fromUserThree.PrintMessage("This message is comming from user 3 --- LazyLoading_Singleton");
        //}

        // Invoke UserOne function in Main() method
        //private static void LazyUserFour()
        //{
        //    // Invoke Singleton for user one
        //    LazyLoading_Singleton fromUserFour = LazyLoading_Singleton.GetInstance;
        //    fromUserFour.PrintMessage("This message is comming from user 4 --- LazyLoading_Singleton");
        //}
    }
}
