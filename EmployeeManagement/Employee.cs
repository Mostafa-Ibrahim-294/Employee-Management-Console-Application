using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Employee : StaffMember
    {
         int socialSecurityNumber;
        public Employee() { }
        public Employee(int id, string name, string phone, string email, 
            Department department ,int socialSecurityNumber) : base(id , name , phone , email ,department)
        {
            this.socialSecurityNumber = socialSecurityNumber;
        }

        public int SocialSecurityNumber { get => socialSecurityNumber; set => socialSecurityNumber = value; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Social Security Number is {SocialSecurityNumber}");
        }

    }
}
