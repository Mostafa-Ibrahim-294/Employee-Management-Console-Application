using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Budget
    {
        int id;
        int value;

        public int Value { get => value; set => this.value = value; }
        public int Id { get => id; set => id = value; }

        public void IncreaseBudget(int AddValue) => Value += AddValue < 0 ? 0 : AddValue;
    }
}
