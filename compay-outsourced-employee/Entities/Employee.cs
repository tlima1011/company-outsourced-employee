using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace compay_outsourced_employee.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {

        }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double payment()
        {
            return Hours * ValuePerHour; 
        }

        internal void listEmployees(List<Employee> list)
        {
            Console.WriteLine("\nPAYMENTS: "); 
            foreach(Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} - $ {emp.payment().ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
