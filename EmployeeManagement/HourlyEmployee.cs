using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class HourlyEmployee : Employee
    {
        int rate;
        int hours;

        public int Rate { get => rate; set => rate = value; }
        public int Hours { get => hours; set {
                if (value < 0 || value > 24) hours = 0;
                else 
                hours = value; }
        }

        public override double PayRoll()=> Rate * Hours;
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Type is : Hourly Employee");
        }

    }
}
