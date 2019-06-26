using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {
        [TestMethod]
        public void Methods()
        {
            int sumOne = AddTwoNumbers(4, 17);
            AddTwoNumbers(6, 25);

            int numberOne = int.Parse("17");
            string response = "5";
            int numberTwo = int.Parse(response);
            int sumTwo = AddTwoNumbers(numberOne, numberTwo);
            int numOne = 4, numTwo = 4;
            int sumThree = AddTwoNumbers(numOne, numTwo);

            float dividend = DivideTwoNumbers(8, 3);//make sure the number is not zero
            Console.WriteLine(dividend);

            int difference = SubTwoNumbers(4, 2);
            int product = MultiplyTwoNUmbers(4, 4);

        }

        //Access modifier(public,private,internal)
        //Return type ( The type that the method returns or spits out)
        // Method signature( Method name, and the parameters)

            // Access modifier return type Name(Parameters)
        private int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
            
        private int SubTwoNumbers(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        private int MultiplyTwoNUmbers(int numOne, int numTwo)
        {
            //f(x,y)=x*y
            return numOne * numTwo;
        }

        private int DivideTwoNumbers(int numOne,  int numTwo)
        {
            return numOne / numTwo;
        }
    }

}
