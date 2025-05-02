using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal static class AllDepartments
    {
        static List<Department> departments;
        static int countDepartments;
        static AllDepartments()
        {
            countDepartments = 0;
            departments = new List<Department>();
        }
        public static void AddDepartment()
        {
            Console.Write("id is : ");
            int.TryParse(Console.ReadLine(), out int id);
            Console.Write("name is : ");
            string name = Console.ReadLine();
            if(id == 0 || IsFound(id, name))
              Console.WriteLine("Some Data Are Duplicated");
            else
            {
                departments.Add(new Department(id, name));
                countDepartments++;
            }
        }
        public static bool IsFound(int id , string name)
        {
            Department dept = departments.FirstOrDefault(a => a.Id == id || a.Name == name);
            if (dept == null)
                return false;
            return true;

        }
        public static void PrintAllDepartments()
        {
            foreach (Department dept in departments)
            {
                Console.WriteLine($"id is : {dept.Id}\nname is : {dept.Name}");
            }
        }
    }
}
