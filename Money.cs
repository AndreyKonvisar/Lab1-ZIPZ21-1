using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    interface IGetterMoney
    {
        void GetMoneyAltogether();
    }
 
    internal class Money : IGetterMoney
    {
        protected int money;
        protected int coins;

        public Money(int money_, int coins_)
        {
            money = money_;
            coins = coins_;
        }

        public int _money { get { return money; } set { money = value; } }
        public int _coins { get { return coins; } set { coins = value; } }

        public void GetMoneyAltogether()
        {
            global::System.Console.WriteLine($"Тимчасова ціна: {money}.{coins}");
        }

        
    }
}
