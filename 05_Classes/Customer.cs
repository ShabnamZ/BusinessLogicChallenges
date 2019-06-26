using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Classes
{
   public class Customer
    {
        public string FullName { get; set; }
        public int CustomerID { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public int AccidentCount { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Premium { get; set; }

        public Customer() { } //Constructor
       
        public Customer(int customerID, string fullName, int age, Address address, int accidentCount, string phoneNumber, decimal premium)
        {
            CustomerID = customerID;
            FullName = fullName;
            Age = age;
            Address = address;
            AccidentCount = accidentCount;
            PhoneNumber = phoneNumber;
            Premium = premium;
        }

      /*  private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        */

    }
}
