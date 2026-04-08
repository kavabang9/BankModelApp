using BankModelApp.API.Operations;
using System.Windows.Media;

namespace BankModelApp.API.Model.MoneyTransfer
{
    internal class MoneyTransfer : Operation // Перевод 
    {
        public MoneyTransfer(decimal amountMoney)
        {
            AmountMoney = amountMoney;
        }
        private decimal TransferFundsAnotherAccount()
        {
            return (decimal)AmountMoney;
        }
    }
}
