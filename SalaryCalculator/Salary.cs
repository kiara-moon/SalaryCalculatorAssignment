using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{
    class Salary
    {
        public string Name;
        public double Amount;
        public double Rent;
        public double Allowance;

        public double CalculateSalary()
        {
            double Salary = Amount + (Amount * Rent) / 100 + (Amount * Allowance) / 100;
            return Salary;
        }
    }
}
