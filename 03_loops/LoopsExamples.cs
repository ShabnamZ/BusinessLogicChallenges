using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_loops
{
    [TestClass]
    public class LoopsExamples
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            //1 Starting Point
            //2 While this condition is true,keep looping
            //3 What we do after each loop
            //4 Code we execute each loop
            //for   //1     //2
            for (int i= 0;  i < studentCount; i++)// i = i + 1
            {
                //4
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string name = "Shabnam Ziyovuddinova";

            //1 Collection being worked on
            //2 Name of the current iteration
            //3 Type in the collection
            //4 In keyword used to separate the individual and the collection
            // foreach //3 //2  //4  //1
            foreach ( char letter in  name)
            {
                Console.WriteLine(letter);
            }

            List<string> students = new List<string>();
            students.Add("Josh");
            students.Add("Julie");
            students.Add("Nick");

            foreach (string student in students)
            {
                Console.WriteLine(student);

            }
            
        }

        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;
            while( total !=10)
            {
                Console.WriteLine(total);
                total++;
            }
            while (true)
            {
                total++;
                if(total>25)
                {
                    break;
                }
            }
        }

    }
}
