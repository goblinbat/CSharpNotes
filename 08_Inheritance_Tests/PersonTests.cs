using System;
using System.Collections.Generic;
using _08_Inheritance_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Inheritance_Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void SetName_ShouldSetCorrectly()
        {
            /// most of the code in here is for notes purposes rather than test purposes   
            Person martha = new Person();
            Customer bob = new Customer();
            SalaryEmployee leslie = new SalaryEmployee {
                //Name = "Leslie",
                Salary = 200000,
                HireDate = new DateTime(1306, 09, 04) 
            };
            Console.WriteLine(leslie.YearsWithCompany);

            //martha.Name = "Martha";
            //bob.Name = "Bob";           
            //leslie.Name = "Leslie";     
            /// martha, bob, and leslie all have access to person property "Name", but only bob has access to customer properties and only leslie has access to employee and salaryemployee properties
            martha.setFirstName("Martha");
            martha.setLastName("Clark");
            
            Assert.AreEqual("Martha Clark", martha.Name);
        }

        [TestMethod]
        public void CustomerIsPremium_ShouldGetCorrectBool()
        {
            Customer firstCustomer = new Customer();
            firstCustomer.IsPremium = true;

            Console.WriteLine(firstCustomer.GetType());     // this can be useful in the future

            Assert.IsTrue(firstCustomer.IsPremium);
        }

        [TestMethod]
        public void EmployeeTests()
        {
            Employee jenny = new Employee();
            HourlyEmployee michael = new HourlyEmployee();
            SalaryEmployee pepper = new SalaryEmployee();
            michael.HoursWorked = 55;
            michael.HourlyWage = 20;
            pepper.Salary = 84000;

            List<Employee> allEmployees = new List<Employee>();
            allEmployees.Add(jenny);
            allEmployees.Add(michael);
            allEmployees.Add(pepper);   // despite technically being different types, since they all inherit from Employee they can all go in the list

            foreach(Employee worker in allEmployees)
            {
                if(worker.GetType() == typeof(SalaryEmployee))
                {
                    SalaryEmployee sEmployee = (SalaryEmployee)worker;
                    Console.WriteLine($"This is a salaried employee who makes {sEmployee.Salary}");
                }
                else if (worker is HourlyEmployee hourlyWorker) // this is called pattern matching; turns worker to type HourlyEmployee (if it can; if it can't it returns false, fails the if, and moves on) and creates new variable hourlyWorker. 
                    // Basically, if worker is of type HourlyEmployee (in addition to its explicit type of Employee), then they become are assigned to variable hourlyWorker which is explicitly of type HourlyEmployee
                {
                    Console.WriteLine($"{worker.Name} has worked {hourlyWorker.HoursWorked} hours!");
                }
            }
        }
    }
}
