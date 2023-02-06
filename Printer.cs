using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModule17
{
    public static class Printer
    {
        // Метод вывода в консоль данных по счету
        public static void Print(IAccount account)
        {
            account.Print();
        }
    }
}
