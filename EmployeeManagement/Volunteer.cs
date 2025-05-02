using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Volunteer : StaffMember
    {
        int amount;

        public int Amount { get => amount; set => amount = value; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Amount is {Amount}");
        }
    }
}
