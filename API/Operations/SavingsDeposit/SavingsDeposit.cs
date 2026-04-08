using BankModelApp.API.Operations;
using BankModelApp.API.Operations.Deposit;

namespace BankModelApp.API.Operations.SavingsDeposit
{
    internal class SavingsDeposit : Operation // Накопительный счет
    {
        public SavingsDeposit(decimal amountMoney)
        {
            AmountMoney = amountMoney;
        }

        private decimal LogicSavingsDeposit()
        {
            int procent = 14;
            decimal totalProfit;
            totalProfit = AmountMoney * (procent / 100) / 365;
            return totalProfit;
        }
    }
}
