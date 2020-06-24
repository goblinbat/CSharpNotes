using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        // 1    2       3                 1: Access modifier     2: Return type      3: Method signature (method name + parameters)
        public void MethodExecution()
        // 4                                     4: Body (where the code goes)
        {
            // to run: open test explorer (right click and select "debug tests" or use search bar at top to find it) and run it
            SayHello("Reese");
            SayHello("stinky");

            int inputOne = 13;
            int inputTwo = 37;
            int sum = AddTwoNumbers(inputOne, inputTwo);
            Console.WriteLine(sum);

            double doubleSum = AddTwoNumbers(34.52d, 342.6d);
            Console.WriteLine(doubleSum);

            int age = CalculateAge(new DateTime(1995, 10, 02));
            Console.WriteLine("My age is " + age);
        }
        

        public void SayHello(string name)      // method name should say what it's doing + be PascalCase 
                                               // parameters basically create a variable that can be used within the method
        {
            Console.WriteLine($"Hello {name}!");
        }


        public int AddTwoNumbers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }


        public double AddTwoNumbers(double x, double y)        // methods can have the same name but must have different parameters (as determined by type and amount)
        {
            double sum = x + y;
            return sum;
        }


        private int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;    // more accurate than just 365 bc of leap years, etc
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }


    }
}
