using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop
            int total = 1;
            while (total != 10)
            {
                Console.WriteLine(total);
                total++;
            }

            total = 0;
            while (true)
            {
                if(total == 10)
                {
                    Console.WriteLine("you did it!");
                    break;
                }
                total++;
            }

            Random rand = new Random();
            int someCount;
            int times = 0;
            bool keepLooping = true;
            while (keepLooping)
            {
                someCount = rand.Next(1, 21);
                times += 1;
                if (someCount == 1|| someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);
                if (someCount == 20)
                {
                    keepLooping = false;
                }
            }
            Console.WriteLine($"looped {times} times!");


            // For Loops
            int studentCount = 21;
            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Nick", "Adam", "Aj", "Austin", "Severa", "Tim" };
            for(int i=0; i < students.Length; i++)
            {
                Console.WriteLine($"Hello there, {students[i]}!");
            }


            // Foreach
            foreach (string student in students)
            {
                Console.WriteLine(student + " is here");
            }

            string myName = "molly ann";
            foreach (char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }


            // Do While
            // differs from while loop in that it doesn't evaluate its conditional until after it's already run once; it will always run at least once
            int iterator = 0;
            do
            {
                Console.WriteLine("hello");
                iterator++;
            }
            while (iterator < 5);



            Console.ReadKey();
        }
    }
}
