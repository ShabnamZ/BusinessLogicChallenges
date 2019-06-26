using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IfElseStatetements()
        {
         int age =7;
         if (age > 17)
         {
            Console.WriteLine("You are an adult.");
            
          }
            else if (age > 6)
               {
            Console.WriteLine("You are a kid.");
                }
            else if (age > 0)
            {
             Console.WriteLine("You are far too young to be  on a computer.");
            }
            else
           {
           Console.WriteLine("You are not born yet.");
          }
          if(age < 65 & age > 18)
          {
            // And comparison
          }
         if (age> 65|| age <18)
         {
          // Or comparison
       }
        if (age== 21)
         {
         // Is equal to 
}
        if (age !=19)
            {
                //Not equal to
                // Bang operator
            }
        }

        [TestMethod]
        public void SwitchCases()
        {
          int age = 27;
          switch(age)
            {
                case 18:
                    // 18 Year Old Code
                    break;
                case 19:
                    // 19 year old code
                    break;
                case 20:
                    // 20 year old code
                    break;
                case 21:
                case 22:
                case 23:
                    //21-23 Year old code
                    break;
                default:
                    //If no other code is true do this
                    break;

            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 31;
            //(Condition/Boolean) ? trueResult : falseResult;
            bool isAdult = (age > 17) ? true : false;

            int numOne = 10;
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine((numOne == 10) ? "True" : "False");
        }
    }
}
