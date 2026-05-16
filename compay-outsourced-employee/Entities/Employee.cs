using System;
using System.Collections.Generic;
using System.Text;

namespace compay_outsourced_employee.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }


        public double payment()
        {
            return Hours * ValuePerHour; 
        }
    }
}
