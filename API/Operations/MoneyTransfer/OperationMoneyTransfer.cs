using BankModelApp.API.Operations;
using System.Windows.Media;

namespace BankModelApp.API.Model.MoneyTransfer
{
    internal class OperationMoneyTransfer : Operation // Перевод средств со счета
    {
        private string senderAccountId;
        private string receiverAccountId;
        private decimal amount;
        private MoneyTransfer moneyTransfer;

        public OperationMoneyTransfer(string senderAccountId, string receiverAccountId,
                                      decimal amount, string currency)
        {
        }
    }
}
