using System;

namespace _05_Classes
{
    public class Cookie
    {
        public int SugarAmount { get; set; } // Chip Count, Shape, Brand
        public int ChipCount { get; set; }
        public double FlourAmount { get; set; }
        public string Brand { get; set; }
        public bool IsGood { get; set; }

        public Cookie()
        {

        }

        public Cookie(int sugarAmount, int chipCount, double flourAmount, string brand,bool isGood)
        {
            SugarAmount = sugarAmount;
            ChipCount = chipCount;
            FlourAmount = flourAmount;
            Brand = brand;
            IsGood = isGood;
        }
      
    }

}
