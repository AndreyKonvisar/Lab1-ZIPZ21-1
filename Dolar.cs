using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    internal class Dolar:Money
    {
        public Dolar(int money, int coins) : base(money, coins)
        {

        }
        public void GetMoneyAltogether()
        {
            Console.WriteLine($"Тимчасова ціна: {money}.{coins} доларів");
        }
    }
}
