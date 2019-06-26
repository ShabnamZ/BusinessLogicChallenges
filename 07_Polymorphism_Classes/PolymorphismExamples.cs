using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Polymorphism_Classes
{
    public class Animal// parent class
    {
        public int EyeCount{ get; set;}
        public  int LegCount { get; set; }
        public double WeightInFreedomUnits { get; set; }
        public bool HasTail { get; set; }
        public bool HasFur { get; set; }

        public Animal() { Console.WriteLine("Animal Constructor"); }

        public Animal( int eyeCount, int legCount, double weight, bool hasTail, bool hasFur)
        {
            EyeCount = eyeCount;
            LegCount = legCount;
            WeightInFreedomUnits = weight;
            HasTail = hasTail;
            HasFur = hasFur;
            Console.WriteLine("Animal Constructor");
        }
    }


    public class Sloth : Animal
    {
        public Sloth()
        {
            Console.WriteLine("Sloth constructor");
        }

        public Sloth (int legCount, int eyeCount, bool hasFur, bool hasTail, double weight): base(eyeCount, legCount, weight, hasTail, hasFur)
        {

        }
        public bool IsSlow
        {
            get {return true;}
        }
    }

    public class Megatherium : Sloth
    {

    }
    public class Cat : Animal
    {
        public Cat() { }

        public Cat( int eyeCount, int legCount, double weight, bool hasTail, bool hasFur, double clawLenght)
            :base (eyeCount, legCount, weight, hasTail, hasFur)
        {
            ClawLenghtInInches = clawLenght;
        }
        public double ClawLenghtInInches { get; set; }

        public virtual void MakeSound() // override the implementation
        {
            Console.WriteLine("Meow");
        }
    }

    public class Liger : Cat
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Roar.");
        }
    }

    public class Tabbycat : Cat
    {
     public new void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Purr!");
        }

    }
}
