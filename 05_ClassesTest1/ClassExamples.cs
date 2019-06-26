using System;
using _05_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTest1
{
    [TestClass]
    public class ClassExamples
    {
        [TestMethod]
        public void CookieExamples()
        {
            Cookie snickerdoodle = new Cookie(); //method
            snickerdoodle.SugarAmount = 150;

            Cookie chocolateChip = new Cookie(700, 10, 2.0, "chips a'hoy", true);
        }

        [TestMethod]
        public void VehicleExamples()
        {
            Vehicle myCar = new Vehicle();
            myCar.TypeOfVehicle = VehicleType.Car;
            myCar.Mileage = 29000;

            myCar.StartVehicle();
            Assert.IsTrue(myCar.IsRunning);

            myCar.StopVehicle();
            Assert.IsFalse(myCar.IsRunning);
        }
    }

}
