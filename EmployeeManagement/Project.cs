using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Project
    {
        int id;
        string Location;
        double currentCost;
        Manager manager;
        List<Budget> budgets;
        public Project(Manager manager)
        {
            budgets = new List<Budget>();
            this.manager = manager;
        }

        public double CurrentCost { get => currentCost; set => currentCost = value < 0 ? 0 : value; }
        public int Id { get => id; set => id = value; }
        public string Location1 { get => Location; set => Location = value; }

        public double CalcTotalBudgets()
        {
            double totalBudget = 0;
            foreach (Budget b in budgets)
                totalBudget += b.Value;
            return totalBudget;
        }
        public void Print()
        {
            Console.WriteLine($"id is {Id}\nlocation is {Location1}\ncost is {CurrentCost}" +
                $"manager name is {manager.Name}");
            foreach (Budget b in budgets)
                Console.WriteLine(b.Value);
        }
    }
}
