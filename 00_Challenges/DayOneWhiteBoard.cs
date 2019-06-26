using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challenges
{
    [TestClass]
    public class DayOneWhiteBoard
    {
        [TestMethod]
        public void ChallengeOne()
        {
            //Declare/Initialize variables-One in,One string,One DateTime
            int someNumber = 73;
            string name = "Shabnam";
            DateTime today = new DateTime(2019, 6, 5);
        }

        [TestMethod]
        public void ChallengeTwo()
        {
            // Write  a switch case that evaluates a user's response whether or not thaey are wearing clothes
            string response = "yes";

            switch (response)
            {
                case "yes":
                    Console.WriteLine("Nice!");
                    break;
                case "no":
                    Console.WriteLine("Why are you the way you are?");
                    break;
                default:
                    Console.WriteLine("Please enter yes or no.");
                    break;
            }
        }
            [TestMethod]
        public void ChallengeThree()
        {
            // Write an if else statement that uses a boolean to check if the user is happy or not
            bool userIsHappy = true;

            if (userIsHappy)
            {
                Console.WriteLine("Yay!");
            }
            else if (!userIsHappy)
            {
                Console.WriteLine(" :(");
            }

        }

        [TestMethod]
        public void ChallengeFour()
        { 
            // Write an if/else that gives different responses based on salary ranges.
            //1000-10,000
            //11,000-50,000
            //51,000-100,000

            int salary = 12345;
            if (salary > 100000) 
            {
                Console.WriteLine("Nice!");
            }
            else if (salary >50000)
            {
                Console.WriteLine("Cool!");
            }
            else  if (salary > 10000)
            {
                Console.WriteLine("Neat");
            }
            else
            {
                Console.WriteLine("awwww");
            }
        }

        [TestMethod]
        public void ChallengeFive()
        {
            //3. Create a method that takes two strings  from the user and outputs the concatenated string
            string outString = AddTwoStrings("hello", "world");
            Console.WriteLine(outString);
        }

        private string AddTwoStrings(string x, string y)
        {
            return x + "" + y;
        }

        [TestMethod]
        public void ChallengeSix() //build a greeting method that prints a users name to the "console"
        {
            string name = " Shabnam";
             Greet(name);
            
            {
                //do something else
            }
        }

        private string Greet(string name)
        {
            return ($"Hello,(name)! It's good to see you!");
        }

    }
}
