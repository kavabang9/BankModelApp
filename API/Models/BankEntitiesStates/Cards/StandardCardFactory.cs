using BankModelApp.API.Models.BankEntities.Cards;

namespace BankModelApp.API.Models.BankEntitiesStates.Cards
{
    public class StandardCardFactory : ICardFactory
    {
        public CreditCard CreateCreditCard()
        {
            return new CreditCard();
        }
        public DebtCard CreateDebtCard()
        {
            return new DebtCard();
        }
    }
}
