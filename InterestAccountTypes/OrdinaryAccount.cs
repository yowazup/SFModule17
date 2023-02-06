using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFModule17.InterestAccountTypes
{
    public class OrdinaryAccount : IAccount
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }

        public void Print()
        {
            Type = "Обычный";
            Console.WriteLine("Вид счета {0}. Баланс {1}. Процентая ставка {2}.", Type, Balance, Interest);
            Console.WriteLine();
        }
    }
}
