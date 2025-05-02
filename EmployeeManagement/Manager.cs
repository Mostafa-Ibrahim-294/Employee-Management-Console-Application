using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Manager : Employee
    {
        public Manager(int id, string name, string phone, string email,
            Department department, int socialSecurityNumber) : base(id , name , phone , email
                , department , socialSecurityNumber)
        { }
    }
}
