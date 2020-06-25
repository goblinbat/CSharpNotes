using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classes
{
    public enum VehicleType { Car, Van, Truck, Plane, Boat, Motorcycle, Spaceship, Helicoptor, Submarine, Bicycle };
    public class Vehicle
    {
        /// properties
        public string Make { get; set; }
        // accessModifier  propertyType  PropertyName  { getters + setters }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string Color { get; set; }
        public VehicleType TypeOfVehicle { get; set; }

        public Vehicle(string make, string model, int year, double mileage, string color, VehicleType type)
        {
            // this is a constructor (beats manually adding individual property values one at a time any time you make an object)
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            Color = color;
            TypeOfVehicle = type;
            // Can specify defaults here, if so desired (usually if you're using an empty constructor like Vehicle() )
            // ex: Color = "yellow"
            // if color is not specified (variable.Color = "red"), color will be yellow
        }

        public Vehicle() { }    // including an empty constructor allows you to create an object without adding properties on creation
                                // if no constructor is specified, a class implicitly has this empty constructor; adding a constructor replaces the empty one, if you want to keep it you have to make it explicit like this
    }

    public class Person
    {
        public string FirstName { get; set; }
        private string _lastName;      // typing "propfull" and hitting tab twice will quickly scaffold this out

        public string LastName         // along with this
        {
            get { return _lastName; }       // these are default; we're not actually modifying these rn, but this is how you can
            set { _lastName = value; }
        }

        public string FullName
        { get { return $"{FirstName} {LastName}"; } }        // this property is basically readonly now so you can't assign it to be different from your previously established first + last names

        public DateTime DateOfBirth { get; set; }
        public int AgeInYears
        {
            get
            {
                if (DateOfBirth == new DateTime())      // ie, the default
                {
                    return 9001;
                }
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                /*return Convert.ToInt32(Math.Floor(totalAgeInYears));*/       // this is the method we learned
                return (int)totalAgeInYears;        // this is the method i found on google; it's quicker/easier
            }
        }

        public Vehicle Transport { get; set; }

        public Person (string firstname, string lastname, DateTime birthday)
        {
            FirstName = firstname;
            _lastName = lastname;
            DateOfBirth = birthday;
        }

    }
}
