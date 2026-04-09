using BankModelApp.API.Operations;

namespace BankModelApp.API.Models.BankEntities.Contribution
{
    internal class Contribution : Deposit // Вклады
    {
        public Contribution(decimal amountMoney) 
        {
            AmountMoney = amountMoney;
        }
    }
}
