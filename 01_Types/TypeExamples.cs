using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class TypeExamples
    {
        [TestMethod]
        public void ValueTypes()
        {

            float firstVariable; // This is declaration
            firstVariable = 7f; // This is initialization

            bool on = true;
            bool off = false;

            char character = 'z';
            //int,double,decimal,long,short,float
            byte byteExample = 255; // 0-255
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMIn = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = - 9223372036854775808;


            float floatExample = 1.04523f;
            double doubleExample = 1.72342342567d;
            decimal decimalExample = 1.234567899m;

        }
        [TestMethod]
        public void Operators()
        {
            int numOne = 15;
            int numTwo = 7;

            // +,-, /, *,%

            int sum = numOne + numTwo;
            int diff = numOne - numTwo;
            int prod = numOne * numTwo;
            int quot = numOne / numTwo;
            int remainder = numOne % numTwo;
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string firstName = "Shabnam";
            string lastName = "Ziyovuddinova";


            // Concatenation
            string concatenatedFullName = firstName +  "" + lastName;

            //Composite Formatting
            string compositeFullName = 
                string.Format("Hi my name is {0}  {1}", firstName, lastName);

            //String Interpolation
            string interpolationFullName = $"{firstName} {lastName}";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolationFullName);




            //Other Reference Types-Objects
            DateTime today = DateTime.Today;
            DateTime someDay = new DateTime(1978, 1, 1);
            TimeSpan timeSpanExample = today - someDay;

            //Collections
            string banana = "An awesome fruit.";
            string[] stringArray = { "Hello", "World", "Why?", banana, "?" };
            string[] anotherArray = new string[17];

            List<string> listExample = new List<string>();
            listExample.Add(banana);
            listExample.Add(banana);
            listExample.Add(banana);
            listExample.Add(banana);
            listExample.Add(banana);
            listExample.Add(banana);

            Queue<int> queueExample = new Queue<int>();
            Dictionary<int, string> dictionaryExample = new Dictionary<int, string>();



        }
    }

}

