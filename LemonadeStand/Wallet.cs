using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Wallet
    {

        private double money;
        public double Money
        {
            get { return money; }
        }
        public Wallet()
        {
            money = 20.00;
        }

        public void PayForItems(double totalCost)
        {
            money -= totalCost;
        }
        public void ReceiveMoney(double amount)
        {
            money += amount;
        }
    }

    
}
