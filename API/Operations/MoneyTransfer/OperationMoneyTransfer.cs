using BankModelApp.API.Operations;
using System.Windows.Media;

namespace BankModelApp.API.Model.MoneyTransfer
{
    internal class OperationMoneyTransfer : Operation // Перевод средств со счета
    {
        public OperationMoneyTransfer(decimal amountMoney)
        {
            AmountMoney = amountMoney;
        }
    }
}
