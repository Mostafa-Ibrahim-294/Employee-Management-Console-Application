namespace EmployeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Management System");
            while (true)
            {
                Console.WriteLine("1. Department");
                Console.WriteLine("2. Staff");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                int.TryParse(Console.ReadLine() , out int mainOption);

                switch (mainOption)
                {
                    case 1:
                        HandleDepartmentMenu();
                        break;
                    case 2:
                        HandleStaffMenu();
                        break;
                    case 3 :
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void HandleDepartmentMenu()
        {
            Console.WriteLine("1. Add New Department");
            Console.WriteLine("2. Print All Departments");
            Console.Write("Select an option: ");
            int.TryParse(Console.ReadLine(), out int option);


            switch (option)
            {
                case 1:
                    Console.Write("Enter department id : ");
                    int.TryParse(Console.ReadLine(), out int id);
                    Console.Write("Enter department name: ");
                    string name = Console.ReadLine();
                    if(AllDepartments.IsFound(id, name))
                    {
                        Console.WriteLine("Some Data Are Duplicated");
                    }
                    else
                    {
                        AllDepartments.AddDepartment();
                        Console.WriteLine("Department added successfully.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Printing all departments...");
                    AllDepartments.PrintAllDepartments();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        static void HandleStaffMenu()
        {
            Console.WriteLine("1. Add New Members");
            Console.WriteLine("2. Print All Members");
            Console.WriteLine("3. Calculate Payroll");
            Console.WriteLine("4. Delete Member");
            Console.Write("Select an option: ");
            int.TryParse(Console.ReadLine() , out int option );
            Staff staff = new Staff();

            switch (option)
            {
                case 1:
                    Console.Write("Enter employee id: ");
                    int.TryParse(Console.ReadLine(), out int empId);
                    if (staff.MatchedEmp(empId) == null)
                    { 

                        Employee emp = new Employee();
                        staff.AddEmployee();
                        Console.WriteLine("Employee added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Employee with the same ID already exists.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Printing all members...");
                    staff.PrintAllEmployees();
                    break;
                case 3:
                    Console.WriteLine("Calculating payroll...");
                    Console.WriteLine(staff.CallPayRoll());
                    break;
                case 4:
                  staff.DeleteEmployee();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
