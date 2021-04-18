using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_SF
{
    class Employee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; } = 1000.0;
        public double Bonus { get; set; } = 0;
        public double Tax { get; set; }
        public double NetIncome { get; set; }
        public int Year { get; set; }

        public Employee(int id, string name, double salary, double bonus)
        {
            EmpID = id;
            Name = name;
            Salary = salary;
            Bonus = bonus;
        }

        public void UpdatePayRoll(double tax, double netincome, int year)
        {
            Tax = tax;
            NetIncome = netincome;
            Year = year;
        }
        public override string ToString()
        {
            return $"The calculated net income and tax of the Employee {Name} with ID {EmpID} is (net income: {NetIncome}, tax: {Tax}) for the year {Year}.";
        }
    }
}
