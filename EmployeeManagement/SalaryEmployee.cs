using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class SalaryEmployee : Employee
    {
        int salary;

        public int Salary { get => salary; set => salary = value; }

        public override double PayRoll() => Salary;
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Type is : Salary Employee");
        }
    }
}
