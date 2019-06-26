using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Interfaces
{
    [TestClass]
    public class InterfacesTests
    {
        [TestMethod]
        public void CallingInterfaceMethods()
        {
            IFruit banana = new Banana();

            string output = banana.Peel();
            Console.WriteLine(output);
        }
        [TestMethod]
        public void InterfaceCollections()
        {
            List<IFruit> fruitList = new List<IFruit>
          {
              new Banana(),
              new Grape(),
              new Kiwi()
          };
            foreach (IFruit fruit in fruitList)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());
            }
        }

        [TestMethod]
        public void InterfacesInMethods()
        {
            IFruit kiwi = new Kiwi();
            string fruitName = GetFruitName(kiwi);
            Console.WriteLine($"This is a {fruitName}");
        }

        private string GetFruitName(IFruit fruit)
        {
            return fruit.Name;
        }

        [TestMethod]
        public void TypeOfInstance()
        {
            // Object Initialization Syntax
            var fruitSalad = new List<IFruit>
            {
                new Kiwi(),
                new Kiwi { IsPeeled = true},
                new Grape(),
                new Banana { IsPeeled = true},
                new Grape()
             };
            //var fruitSalad = new List<IFruit>();
            //fruitSalad.Add(new Kiwi());
            //fruitSalad.Add(new Grape());
            //fruitSalad.Add(new Kiwi());
            //fruitSalad.Add(new Banana());
            //fruitSalad.Add(new Kiwi());

            Kiwi anotherKiwi = new Kiwi();
            Kiwi againAnotherKiwi = new Kiwi
            {
                IsPeeled = true
            };

            foreach (var fruit in fruitSalad)
            {
                if (fruit is Kiwi)
                    if (fruit.IsPeeled)
                        Console.WriteLine("Is a peeled Kiwi.");
                    else
                        Console.WriteLine("Is a Kiwi.");
                else if (fruit.GetType() == typeof(Grape))
                    Console.WriteLine("Is a Grape?");
                else if (fruit.IsPeeled)
                    Console.WriteLine("Is a peeled Banana.");
                else
                    Console.WriteLine("Is a Banana.");
            }
        }
    }
}
