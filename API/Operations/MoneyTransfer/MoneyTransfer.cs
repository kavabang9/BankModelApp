using BankModelApp.API.Operations;
using System.Windows.Media;

namespace BankModelApp.API.Model.MoneyTransfer
{
    internal class MoneyTransfer : Operation // Перевод 
    {
        public string TransferId { get; set; }
        public string SenderAccountId { get; set; }
        public string ReceiverAccountId { get; set; }
        public decimal Amount { get; set; }
        public object Status { get; set; } // ?
        public DateTime TransferDate { get; set; }
    }
}
