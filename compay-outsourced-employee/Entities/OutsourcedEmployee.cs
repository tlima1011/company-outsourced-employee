using System;
using System.Collections.Generic;
using System.Text;

namespace compay_outsourced_employee.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; } 

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double ac) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = ac; 

        }

        public override double payment()
        {
            return base.payment() + (1.1 * AdditionalCharge);
        }


    }
}
