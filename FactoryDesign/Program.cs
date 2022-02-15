using System;

namespace FactoryDesign
{
    // In this scenario, if EmployeeId is odd we should set hourlyPay variable to 10 and bonus to 12
    // and if EmployeeId is even we should set hourlyPay variable to 15 and bonus to 17
    class Program
    {
        static void Main(string[] args)
        {
            // This example is not use factory design pattern. 
            // One of the significant note is that we should not use any logic code in our 
            // So we make a decision to use a factory design pattern
            var employeeId = 9;
            // var employeeId = 2;
            int hourlyPay = 0;
            int bonus = 0;

            // Path way in here
            // EmployeeManagerFactor=======> GetEmployeeManager() ** it returns IEmployeeManager type which contains even and odd method
            // each one of these Even and Odd contain a class that return their values (for odd 10 and 12 | for even 15 and 17)
            // If we have one if statement with specific computation, we can use one class and etc.
            // In this scenario we have 2 if statement for Even and Odd calculation
            EmployeeManagerFactor factor = new EmployeeManagerFactor();
            hourlyPay = factor.GetEmployeeManager(employeeId).GetHourlyPay();
            bonus = factor.GetEmployeeManager(employeeId).GetBonus();

            Console.WriteLine($"Hourly pay is : {hourlyPay}");
            Console.WriteLine($"Bonus is : {bonus}");
        }
    }
}
