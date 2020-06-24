using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("hello");
                    break;
                case 2:
                    Console.WriteLine("what");
                    break;
                default:
                    Console.WriteLine("this will execute if no other case fits");
                    break;
            }

            DayOfWeek today = DateTime.Today.DayOfWeek;
            switch (today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Hope you ae ready to work!");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry, we are closed");
                    break;
            }

            Console.WriteLine("on a scale of 1-5, how are you feeling?");
            string inputF = Console.ReadLine();
            int feeling = int.Parse(inputF);
            switch (feeling)
            {
                case 1:
                    Console.WriteLine("ribbit");
                    break;
                case 2:
                    Console.WriteLine("quack");
                    break;
                case 3:
                    Console.WriteLine("woof");
                    break;
                case 4:
                    Console.WriteLine("chirp");
                    break;
                case 5:
                    Console.WriteLine("meow");
                    break;
                default:
                    Console.WriteLine("...");
                    break;

            }
        }
    }
}
