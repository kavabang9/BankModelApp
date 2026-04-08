using BankModelApp.API.Operations;

namespace BankModelApp.API.Model.Credit
{
    internal class Credit : Operation
    {
        public Credit(decimal amountMoney)
        {
            AmountMoney = amountMoney;
        }
        private void ExtraditionCredit()
        {

        }
    }
}
