﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Ternaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 77;
            bool isAdult = (age > 17) ? true : false;       // (codition/boolean) ? trueResult : falseResult

            int numOne = 62;
            int numTwo = (numOne == 10) ? 30 : 40;      // numTwo = 40

            int hoursAsleep = 4;
            string Outcome = (hoursAsleep >= 8) ? "congrats" : "sorry";
        }
    }
}
