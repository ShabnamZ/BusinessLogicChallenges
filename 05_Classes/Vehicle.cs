using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Classes
{
    public enum VehicleType { Car = 1, Truck, Van, Motorcycle, SUV, Minivan, Boat, Plane, Spaceship}
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Insurance { get; set; }
        public int AccidentCount { get; set; }
        public string PlateNumber { get; set; }
        public double Mileage { get; set; }
        public string Color { get; set; }
        public VehicleType TypeOfVehicle { get; set; }
        public bool IsRunning { get; set; }
        public int CoolnessFactor { get; set; }

        public void StartVehicle()
        {
            IsRunning = true;
            CoolnessFactor++;

        }

        public void StopVehicle()
        {
            IsRunning = false;
            CoolnessFactor--;
        }

        public void DriveVehicle(double distanceTravelled)
        {
         if (IsRunning)
            {
                Mileage = Mileage + distanceTravelled;
            }
        }

        


    }
}
