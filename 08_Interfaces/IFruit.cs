using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces
{
     public interface IFruit //C# Interface: An interface in C# contains only the declaration of the methods, properties, and events, but not the implementation. It is left to the class that implements the interface by providing implementation for all the members of the interface. Interface makes it easy to maintain a program. acting as a template.
    {
      string Name { get; }
      bool IsPeeled { get; set; }
      string Peel();//method prototyping
    }

    public class Banana : IFruit
    {
        public string Name{ get { return "banana"; } }

        public bool IsPeeled { get; set; }

        public string Peel()
        {
            IsPeeled = true;
            return " You peel the banana";
        }
    }

    public class Kiwi : IFruit
    {
        public string Name
        {
            get { return "kiwi"; }
        }
        public bool IsPeeled { get; set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peel the kiwi";
        }
    }

    public class Grape : IFruit
    {
        public string Name => "Grape";//grape is a property

        public bool IsPeeled { get; set; }

        public string Peel()
        {
            IsPeeled = true;
            return "Who peels grapes?";
        }

        public string Squeeze()
        {
            return "You squeeze the grape.";
        }

    }

}

