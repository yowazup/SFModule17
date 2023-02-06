using SFModule17.InterestAccountTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SFModule17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //расчет процентной ставки обычного счета
            var account1 = new OrdinaryAccount() { Balance = 100000 };
            Calculator.CalculateInterest(account1);
            Printer.Print(account1);

            //расчет процентной ставки зарплатного счета
            var account2 = new PayrollAccount() { Balance = 100000 };
            Calculator.CalculateInterest(account2);
            Printer.Print(account2);

            Console.ReadKey();
        }
    }
}