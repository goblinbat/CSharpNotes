using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Methods
{
    [TestClass]
    public class MethodExamples
    {
        public void SayHello(string name)      // method name should say what it's doing + be PascalCase 
                             // parameters basically create a variable that can be used within the method
        {
            Console.WriteLine($"Hello {name}!");
        }

        [TestMethod]
        // 1    2       3                 1: Access modifier     2: Return type      3: Method signature (method name + parameters)
        public void MethodExecution()
        // 4                                     4: Body (where the code goes)
        {
            SayHello("Reese");
            SayHello("stinky");

            // to run: open test explorer (right click and select "debug tests" or use search bar at top to find it) and run it

            
        }
    }
}
