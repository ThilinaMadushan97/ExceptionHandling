using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal LoanInstalAmount { get; set; }

        public decimal CalculateNetSalary()
        {
            if(this.BasicSalary < this.LoanInstalAmount)
            {
                throw new LoanGraterthanBasicException();
            }
            return this.BasicSalary - this.LoanInstalAmount;
        }

    }
}
