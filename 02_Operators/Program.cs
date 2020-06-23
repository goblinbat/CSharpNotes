using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 11;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;

            int remainder = b % a;

            Console.WriteLine($"{sum}, {difference}, {product}, {quotient}, {remainder}");


            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1842, 1, 1);
            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan);



            Console.WriteLine("Enter your age");
            string ageString = Console.ReadLine();    // ReadLine returns a string, so even though the response should be a number it'll be returned as a string
            int age = int.Parse(ageString);
            Console.WriteLine("Enter your name");
            string username = Console.ReadLine();
            bool equals = age == 24;
            bool userIsNyles = username == "Nyles" || username == "nyles";
            Console.WriteLine("user is 24: " + equals);
            Console.WriteLine("user is Nyles: " + userIsNyles);

            bool notEqual = age != 113;      // returns true if user is NOT 113, returns false if user is
            bool userIsNotReese = username != "Reese" || username != "reese";
            Console.WriteLine($"User is not 113: {notEqual}");
            Console.WriteLine($"User is not Reese: {userIsNotReese}");

            List<string> firstList = new List<string>();
            firstList.Add(username);
            List<string> secondList = new List<string>();
            secondList.Add(username);
            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool greaterThan = age > 18;
            bool greaterThanOrEqual = age >= 21;
            bool lessThan = age < 1;
            bool lessThanOrEqual = age <= 50;
            bool orValue = equals || lessThan;

            bool trueOrTrue = true || true;         //returns true
            bool trueOrFalse = true || false;       //returns true
            bool falseOrTrue = false || true;       //returns true
            bool falseOrFalse = false || false;     //returns false
            
            bool andValue = greaterThan && lessThanOrEqual;
            bool tAndT = true && true;              //returns true
            bool tAndF = true && false;             //returns false
            bool fAndT = false && true;             //returns false
            bool fAndF = false && false;            //returns false


            Console.ReadLine();
        }
    }
}
