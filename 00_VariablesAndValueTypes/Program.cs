using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    class Program
    {
        enum PastryType { Cake, Cupcake, Croissant, Donut, Cookie, Danish, Scone };

        static void Main(string[] args)
        {
            /// ctrl+e+w   activates word wrap (same as alt+z in visual studio code)
            /// ctrl+k+d   cleans up code (if stuff is out of line it'll reindent/deindent, etc)
            /// ctrl+shift+/    comments out selected code
            /// shortcut for Console.WriteLine: type cw and hit tab twice

            bool isDeclared;
            isDeclared = true;

            bool isDeclaredAndInitialized = false;
            isDeclaredAndInitialized = true;

            char character = 'a';   // char denotes a single character; uses 'single quotes'. 
            // Differs from string in use of single quotes and length (char is only 1, string can have /many/)
            char symbol = '&';
            char number = '5';
            char space = ' ';
            char specialCharacter = '\n';   // \n = new line

            byte byteExample = 255;    // 255 is the max for byte
            sbyte sByteExample = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;    // Int16 == short
            int intMin = -2147483648;    // int is most common whole number variable designation
            Int32 intMax = 2147483647;      // Int32 == int
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;       // Int64 == long
            // most of these aren't used that often; mostly just use int

            
            int a = 7;   // break point: click on the bar with the red dot to add a red dot; when you run the code it'll pause on the line
            int b = -7000;

            byte age = 104;


            float floatExample = 1.045231f;     // floats need to have an f at the end
            double doubleExample = 1.789053278907036d;    // can end in a d, but doesn't have to. Numbers w/ decimal points default to doubles if there's no suffix
            decimal decimalExample = 1.2578907289045789789789789787897m;   // ends in m
            Console.WriteLine(1.2578907289045789789789789787897f);     // will cut off at float's limit
            Console.WriteLine(1.2578907289045789789789789787897d);      // will cut off at double's limit
            Console.WriteLine(1.2578907289045789789789789787897m);      // within decimal's limit so it won't cut off
            Console.ReadKey();


            /// Enums
            // Enums must be defined outside the class (so return to the top)
            PastryType myPastry = PastryType.Cake;
            PastryType anotherOne = PastryType.Croissant;


            /// Structs

            Int32 num = 42;
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1995, 10, 02);
            DateTime defaultTest = new DateTime();
        }
    }
}
