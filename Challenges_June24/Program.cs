using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges_June24
{
    class Program
    {
        enum animals { cat, dog, bat, duck, crow, lizard, frog, salamander }
        static void Main(string[] args)
        {
            // types
            string cat = "meow";
            int x = 37;
            double y = 42.13;
            char space = ' ';
            bool t = true;
            animals pet = animals.cat;
            Console.WriteLine($"{cat}, {x}, {y}, {space}, {t}, {pet}");

            string color = "gold";
            string welcomeMessage = string.Format("welcome to {0} badge", color);
            string spamEmail = string.Format("buy {0}", color);
            string sentence = string.Format("{0} is an element and a color. Au is {0}'s atomic number", color);
            Console.WriteLine(welcomeMessage);
            Console.WriteLine(spamEmail);
            Console.WriteLine(sentence);

            string cheese = "string cheese";
            string pasta = "mac and cheese" ;
            string beans = "kidney beans";
            string sentenceTwo = $"my brother's shopping list includes {cheese}, {pasta}, and {beans}";
            string hello = "hello";
            string greet = string.Format("{0} world, and {0} class. Welcome to the {1} badge.", hello, color);
            Console.WriteLine(greet);
            Console.WriteLine($"{hello} world, and {hello} class. Welcome to the {color} badge.");
            Console.WriteLine(hello + " world, and " + hello + " class. Welcome to the " + color + " badge");

            char[] letters = { 'h', 'm', 'l', 'i', 'x' };
            Console.WriteLine(letters[2]);
            List<string> fruit = new List<string>();
            fruit.AddRange(new List<string>() { "pear", "apple", "banana", "peach", "cherry" });
            fruit.Sort();
            Console.WriteLine(fruit[0]);


            // operators
            int a = 42;
            int b = 5;
            int first = a * b;  // 210
            int second = a + b; // 47
            int third = a / b;  // 5
            int bonusOne = a + a + b;   // 89
            int bonusTwo = a + b * 2;   //52
            Console.WriteLine(bonusOne);

            int day = 16;
            bool testComparison;
            if (day == 16 || day == 17)
            {
                testComparison = true;
            }
            if (day > 3 && day < 20)
            {
                testComparison = true;
            }
            if (day <= 18 && day != 16)
            {
                testComparison = false;
            }
            if (day < 4 || day > 50)
            {
                testComparison = false;
            }


            // conditionals
            int hoursSlept = 10;
            if (hoursSlept < 8)
            {
                Console.WriteLine("i am tired");
            }
            else if (hoursSlept > 20)
            {
                Console.WriteLine("i might be in a coma");
            }

            bool isCarOn = false;
            bool carHasGas = true;
            if (carHasGas && isCarOn)
            {
                Console.WriteLine("Let the adventure begin");
            }
            else if (carHasGas)
            {
                Console.WriteLine("turn the car on");
            }
            else if (isCarOn)
            {
                Console.WriteLine("i need gas");
            }
            else
            {
                Console.WriteLine("i'm not going anywhere");
            }

            string hogwartsHouse = "heck";
            switch (hogwartsHouse)
            {
                case "Gryffindor":
                    Console.WriteLine("griffins are pretty cool");
                    break;
                case "Ravenclaw":
                    Console.WriteLine("i love ravens");
                    break;
                case "Hufflepuff":
                    Console.WriteLine("good people");
                    break;
                case "Slytherin":
                    Console.WriteLine("not actually evil");
                    break;
            }

            int volumeLevel = 14;
            string volume = (volumeLevel >= 15) ? "turn down the volume" : "turn the volume up";
            bool canSee = true;
            string turnLight = canSee ? "off" : "on";


            // loops
            int iter = 0;
            while (iter < 50)
            {
                if (iter % 2 != 0)
                {
                    Console.WriteLine(iter);
                }
                iter++;
            }

            for (int i=0; i<50; i+=5)
            {
                if (i % 2 != 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            double[] nums = { 5, 42, 3, 3, 3, 3, 3, 3.14159 }; 
            foreach (double num in nums)
            {
                Console.WriteLine(num + " is a nice number");
            }

            int test = 1;
            do
            {
                Console.WriteLine("hey");
            }
            while (test > 10);

            do
            {
                Console.WriteLine(test);
                test++;
            }
            while (test < 11);


            //methods
            Destringify("meow");
            string greeting = WelcomeGreeting("Nyles");
            int product = Multiply(10, 9);
            double productTwo = Multiply(24.2, 51.89);
            

            Console.ReadKey();
        }


        // methods
        static void Destringify(string word)
        {
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
        }

        static string WelcomeGreeting(string name)
        {
            return $"Hello there, {name}!";
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }
    }
}
