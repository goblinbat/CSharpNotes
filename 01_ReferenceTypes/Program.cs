using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings
            string thisIsDeclared;
            string declared;
            declared = "This is initialized";

            string declarationAndInitialization = "this is both declared and initialized";

            Console.WriteLine("what is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("what is your last name?");
            string lastName = Console.ReadLine();

            //concatenation
            string conFullName = firstName + " " + lastName;
            //composite
            string compFullName = string.Format("{0} {1}", firstName, lastName);
            //interpolation
            string intFullName = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(conFullName);
            Console.WriteLine(compFullName);
            Console.WriteLine(intFullName);


            /// Collections
            // Array
            string stringExample = "burn the witch";
            string[] stringArray = { "hello", "frog", "burgle", "meow", "mothman", "bat", stringExample, "?" };   // can modify contents of array, but cannot add things (unless something is first removed) (must always have same number of "slots")
            string thirdItem = stringArray[2];
            Console.WriteLine(thirdItem);
            stringArray[0] = "goblin";
            Console.WriteLine(stringArray[0]);

            // Lists
            List<string> stringList = new List<string>();
            List<int> intList = new List<int>();
            stringList.Add("ribbit");
            intList.Add(37);
            intList.Add(13);
            Console.WriteLine(intList[0]);

            // Queue
            Queue<string> fifo = new Queue<string>();   // fifo is "first in first out"
            fifo.Enqueue("a");
            fifo.Enqueue("b");
            string firstItem = fifo.Dequeue();
            Console.WriteLine(firstItem);

            // Dictionaries
            Dictionary<int, string> keyValue = new Dictionary<int, string>();
            keyValue.Add(13, "goblin");        // keys must be unique, values can repeat
            string valueThirteen = keyValue[13];   // NOT indexing; insert the key
            Console.WriteLine(valueThirteen);

            // Others
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lifo = new Stack<string>();       // lifo is "last in first out"



            /// Classes
            Random rng = new Random();
            int randNum = rng.Next();   // can add min and max values, limiting what numbers can pop up (ex: (0,100) would limit it to numbers btw 0 (inclusive) and 100 (exclusive) (available numbers are 0-99))
            Console.WriteLine(randNum);
            
            Console.ReadKey();
        }
    }
}
