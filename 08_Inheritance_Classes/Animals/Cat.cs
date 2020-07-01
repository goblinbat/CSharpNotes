using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public class Cat : Animal
    {
        /// meow
        public double ClawLength { get; set; }

        public virtual void MakeSounds()
        {
            Console.WriteLine("Meow");
        }

        public override void Move()     // override allows us to redefine virtual methods from parent classes
        {
            Console.WriteLine($"The {GetType().Name} moves quickly");
        }
    }

    public class Liger : Cat
    {
        public override void MakeSounds()
        {
            Console.WriteLine("Roar");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey");
            base.Move();       // this calls the original method (the one from the class' parent)
        }
    }

    public class TabbyCat : Cat
    {
        public override void MakeSounds()
        {
            base.MakeSounds();
            Console.WriteLine("purrrr");
        }
    }
}
