using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Classes
{
    public class Employee
    {
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public string EmployeeID {get; set;}
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public string Title { get; set; }
        public decimal HourlyWage { get; set; }
        
        



        public Employee() { }

        public Employee(string fullName, DateTime birthday, string employeeID, string phoneNumber, Address address, string title, decimal hourlyWage)
        {
            FullName = fullName;
            Birthday= birthday;
            EmployeeID = employeeID;
            PhoneNumber = phoneNumber;
            Address = address;
            Title = title;
            HourlyWage = hourlyWage;
          
        }

    }
}
