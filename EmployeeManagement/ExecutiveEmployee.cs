using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class ExecutiveEmployee : Employee
    {
        int salary;
        int bonus;

        public int Salary { get => salary; set => salary = value; }
        public int Bonus { get => bonus; set => bonus = value; }

        public override double PayRoll() => Salary * Bonus;
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Type is : Executive Employee");
        }
    }
}
