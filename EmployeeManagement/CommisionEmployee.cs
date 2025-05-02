using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class CommisionEmployee : Employee
    {
        int target;

        public int Target { get => target; set => target = value; }

        public override double PayRoll() => Target * 0.05;
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Type is : Commision Employee");
        }
    }
}
