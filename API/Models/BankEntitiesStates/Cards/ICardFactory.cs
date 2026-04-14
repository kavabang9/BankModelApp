using BankModelApp.API.Models.BankEntities.Cards;

namespace BankModelApp.API.Models.BankEntitiesStates.Cards
{
    public interface ICardFactory
    {
        CreditCard CreateCreditCard();
        DebtCard CreateDebtCard();
    }
}
