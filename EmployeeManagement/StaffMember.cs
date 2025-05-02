using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class StaffMember
    {
        private int id;
        private string name;
        private string phone;
        private string email;
        Department department;
        public StaffMember(int id , string name , string phone , string email , Department department)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.Department =  new Department(department.Id , department.Name);
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        internal Department Department { get => department; set => department = value; }

        public StaffMember()
        {

        }
        public virtual void Print() =>
  Console.WriteLine($"ID is : {Id}\nName is : {Name}\nPhone is :" +
      $" {Phone}\nEmail is : {Email}\nDepartment Id is : {Department.Id}");
        public virtual double PayRoll()
        {
            return 0;
        }
    }
}
