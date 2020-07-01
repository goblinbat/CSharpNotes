using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes.Animals
{
    public enum DietType { Herbivore, Omnivore, Carnivore, Insectivore, Piscivore }
    public abstract class Animal        // abstract means we can't make objects of this type; we can make objects that inherit from this class, but we can't make objects explicitly of this type
    {
        public int NumberOfLegs { get; set; }
        public bool isMammal { get; set; }
        public bool canFly { get; set; }
        public bool inEndangered { get; set; }
        public DietType TypeOfDiet { get; set; }

        public virtual void Move()      // virtual allows this to be redefined by classes inheriting from Animal
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}
