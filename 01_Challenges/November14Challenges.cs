using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Challenges
{
    [TestClass]
    public class November14Challenges
    {
        [TestMethod]
        public void Challenges()
        {
            string myFirstName = "Enrique";
            string myLastName = "Lopez";
            int myAge = 30;

            string[] favoriteMovies = { "Ender's Game", "Monster's Inc.", "The Matrix", "Mad Max" };

            List<DateTime> dates = new List<DateTime>();
            dates.Add(new DateTime(1990, 08, 26));
            dates.Add(DateTime.Now);

            int variable = 7;
            int sum = myAge + variable;
            int sub = myAge - variable;
            int multi = myAge * variable;
            int remain = myAge % variable;

            Console.WriteLine(sum);
            Console.WriteLine(sub);
            Console.WriteLine(multi);
            Console.WriteLine((double) 30 / 7);
            Console.WriteLine(remain);

            int hoursSlept = 5;
            if (hoursSlept >= 10)
            {
                Console.WriteLine("Wow, that is a lot of sleep");
            }
            else if (hoursSlept > 8 && hoursSlept < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hoursSlept > 4 && hoursSlept < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep");
            }


            int myDay = 1;
            switch (myDay)
            {
                case 1:
                    Console.WriteLine("Great");
                    break;
                case 2:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Okay");
                    break;
                case 4:
                    Console.WriteLine("Bad");
                    break;

            }
        }
    }
}
