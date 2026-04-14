using BankModelApp.API.Models.BankEntitiesStates.Cards;

namespace BankModelApp.API.Operations.Cards
{
    public class CreateCreditCardStrategy : ICreateCardStrategy
    {
        public Card CreateCard(ICardFactory factory)
        {
            return factory.CreateCreditCard();
        }
    }
}
