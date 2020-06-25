using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Classes
{
    [TestClass]
    public class ClassTests
    {
        [TestMethod]
        public void VehiclePropertyTests()
        {
            Vehicle firstVehicle = new Vehicle();
            /*firstVehicle.Color = "fuschia";*/
            firstVehicle.Make = "ladybug";
            firstVehicle.Model = "fire";
            firstVehicle.Mileage = 7000000000;
            firstVehicle.Year = 1659;
            firstVehicle.TypeOfVehicle = VehicleType.Helicoptor;
            string carDetails = $"{firstVehicle.Make} {firstVehicle.Color}";
            Console.WriteLine(carDetails);

            Vehicle rocket = new Vehicle("play-doh", "bird", 1200, 300, "chartreuse", VehicleType.Spaceship);
        }

        [TestMethod]
        public void PersonTests()      //can make/scaffold this out quickly by typing "testm" and hitting tab twice
        {
            Person reese = new Person("reese", "bright", new DateTime(1995, 10, 02));
            Console.WriteLine(reese.FullName);
            Console.WriteLine(reese.AgeInYears);

            Person nyles = new Person("nyles", "bitter", new DateTime(2042, 07, 13));
            nyles.Transport = new Vehicle("cat", "meow", 2015, 2000000, "vermillion", VehicleType.Bicycle);
            Console.WriteLine(nyles.Transport.Model);

            // sample test
            Assert.AreEqual("nyles bitter", nyles.FullName);
        }
    }


}
