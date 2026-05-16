using compay_outsourced_employee.Entities;
using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CompanyOutsourcedEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Employee employees = new Employee(); 

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine()); 

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee # {i} data:");
                Console.Write("Outsourced(y / n) ? ");
                char oe = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
                if(oe == 'n' || oe == 'N')
                {
                    list.Add(new Employee(name, hours, valuePerHour)); 
                }
                else
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additional));  
                }
            }
            employees.listEmployees(list);
            employees.ordenadaPorSalarioDesc(list);
        }
    }
}