using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling.Models
{
    internal class LoanGraterthanBasicException : Exception
    {
        public LoanGraterthanBasicException() : base ("Loan installment canot grater than ypur basic salary") { }
    }
}
