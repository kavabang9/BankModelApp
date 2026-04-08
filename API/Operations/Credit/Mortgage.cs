using BankModelApp.API.Operations;

namespace BankModelApp.API.Operations.Credit
{
    internal class Mortgage : Operation
    {
        public Mortgage(decimal amountMoney)
        {
            AmountMoney = amountMoney;
        }
    }
}
