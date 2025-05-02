using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Staff
    {
        List<Employee> employees;
        static int countEmployees;
        static Staff()
        {
            countEmployees = 0;
        }
        public Staff()
        {
            employees = new List<Employee>();

        }
        public void AddEmployee()
        {
            Console.Write("id is : ");
            int.TryParse(Console.ReadLine() , out int id);
            Console.Write("social Security is : ");
            int.TryParse(Console.ReadLine(), out int socialSecurity);
            Console.Write("name is : ");
            string name = Console.ReadLine();
            Console.Write("phone is : ");
            string phone = Console.ReadLine();
            Console.Write("email is : ");
            string email = Console.ReadLine();
            Console.Write("dept Id is : ");
            int.TryParse(Console.ReadLine(), out int deptId);
            Console.Write("dept Name is : ");
            string deptName = Console.ReadLine();
            Department department = new Department(deptId, deptName);
            Employee emp = employees.FirstOrDefault(a => a.Id == id || a.Phone == phone ||
            a.Email == email || a.SocialSecurityNumber == socialSecurity );
            if ( emp == null)
            {
            employees.Add(new Employee(id, name, phone, email, department, socialSecurity));
                countEmployees++;
            }
            else
             Console.WriteLine("Some Data Are Duplicated"); 
        }
        private void MakeEditChoice(ref Employee emp)
        {
            Console.WriteLine("1-Edit Id\n2-Edit email\n3-Edit phone\n4-Edit name\n" +
                "Edit Department\n6-Edit socialSecurity");
            int.TryParse (Console.ReadLine(), out int choice);
            switch (choice)
            {
                case 1:
                    Console.Write("id is : ");
                    int.TryParse(Console.ReadLine(), out int id);
                    emp.Id = id;
                    break;
                case 2:
                    Console.Write("Email is : ");
                    string email = Console.ReadLine();
                    emp.Email = email;
                    break;
                case 3:
                    Console.Write("phone is : ");
                    string phone = Console.ReadLine();
                    emp.Phone = phone;
                    break;
                case 4:
                    Console.Write("Name is : ");
                    string name = Console.ReadLine();
                    emp.Name = name;
                    break;
                case 5:
                    Console.Write("Department id is : ");
                    int.TryParse(Console.ReadLine(), out int deptId);
                    Console.Write("Department name is : ");
                    string deptName = Console.ReadLine();
                    emp.Department= new Department(deptId , deptName );
                    break;
                case 6:
                    Console.Write("social security is : ");
                    int.TryParse(Console.ReadLine(), out int social);
                    emp.SocialSecurityNumber = social;
                    break;
                default:
                    break;
            }

        }
        public void EditEmployee()
        {
            Console.Write("id you wanna edit is : ");
            int.TryParse(Console.ReadLine(), out int id);
            Employee emp = MatchedEmp(id);
            if (emp == null)
                Console.WriteLine("id is not found");
            else
                MakeEditChoice(ref emp);

        }
        public void DeleteEmployee()
        {
            Console.Write("id you wanna delete is : ");
            int.TryParse(Console.ReadLine(), out int id);
            Employee emp = MatchedEmp(id);
            if (emp == null)
                Console.WriteLine("id is not found");
            else
            {
                employees.Remove(emp);
                countEmployees--;
            }
        }
        public Employee MatchedEmp(int id) => employees.FirstOrDefault(a=> a.Id == id);
        public void PrintAllEmployees()
        {
            foreach (Employee emp in employees)
                emp.Print();
        }
        public double CallPayRoll()
        {
            double res = 0;
            foreach (Employee emp in employees)
                res += emp.PayRoll();
            return res;
        }

    }
}
