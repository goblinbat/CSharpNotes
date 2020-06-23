using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_If_Else_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("eat something");
            }

            int hoursSpentStudying = 1;
            if (hoursSpentStudying < 16)
            {
                Console.WriteLine("you should probably study more");
            } else
            {
                Console.WriteLine("you've studied a lot");
            }


            Console.WriteLine("how many eggs did you swallow whole");
            string eggsEaten = Console.ReadLine();
            int totslEggs = int.Parse(eggsEaten);

            if(totslEggs >= 8)
            {
                Console.WriteLine("whyyyy");
                Console.WriteLine($"why would you swallow {totslEggs} entire eggs whole???");
            }
            else
            {
                Console.WriteLine("at least you haven't swallowed 8 eggs, like wth why would you do that");
                if(totslEggs < 1)
                {
                    Console.WriteLine("thanks for not swallowing whole eggs");
                    if (totslEggs < 0)
                    {
                        Console.WriteLine("wait, did you spit up eggs??? wtf");
                    }
                } 
                else
                {
                    Console.WriteLine("but for real, what's wrong with you");
                }
            }


            Console.WriteLine("how old are you");
            string ageInput = Console.ReadLine();
            int ageNum = Convert.ToInt32(ageInput);

            if (ageNum > 17)
            {
                Console.WriteLine("congrats on being adult ig");
            }
            else
            {
                if(ageNum > 6)
                {
                    Console.WriteLine("you are a child");
                }
                else if (ageNum >= 0)
                {
                    Console.WriteLine("babby");
                }
                else
                {
                    Console.WriteLine("you don't exist yet??");
                }
            }


            if(ageNum > 65 || ageNum < 18)
            {
                Console.WriteLine("Quack");
            }


            Console.ReadKey();
        }
    }
}
