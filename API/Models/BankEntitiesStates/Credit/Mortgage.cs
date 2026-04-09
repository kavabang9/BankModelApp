namespace BankModelApp.API.Models.BankEntities.Credit
{
    public class Mortgage : Deposit // Ипотека
    {
        public Mortgage(decimal amountMoney)
        {
            AmountMoney = amountMoney;
        }
    }
}
