using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRY
{
    //Dont
    //Repeat
    //Yourself
    public class Payroll
    {
        private decimal CalculateTaxAndBonus(decimal salary)
        {
            decimal tax = salary * 0.10m;
            decimal bonus = salary * 0.05m;
            return salary - tax + bonus;

        }
        public decimal CalculateSalaryForFullTime(decimal baseSalary)
        {

            return CalculateTaxAndBonus(baseSalary);
        }

        public decimal CalculateSalaryForPartTime(decimal hourlyRate, int hoursWorked)
        {

            decimal salary = hourlyRate * hoursWorked;

            return CalculateTaxAndBonus(salary);

        }
    }
}
