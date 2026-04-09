using System;
using System.Collections.Generic;
using System.Text;

namespace BankModelApp.API.Models.BankEntities.Deposit
{
    public class Deposit // Накопительный счет
    {
        public decimal AmountMoney { get; set; }
        public Deposit(decimal amountMoney)
        {
            AmountMoney = amountMoney;
        }

        private decimal LogicDeposit()
        {
            int procent = 14;
            decimal totalProfit;
            totalProfit = AmountMoney * (procent / 100) / 365;
            return totalProfit;
        }
    }
}
