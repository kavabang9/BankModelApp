using BankModelApp.API.Models.BankEntitiesStates.Cards;
using BankModelApp.API.Operations.Cards;

namespace API.Models.Operations.Cards;

public class CreateDebtCardStrategy : ICreateCardStrategy
{
    public Card CreateCard(ICardFactory factory)
    {
        return factory.CreateDebtCard();
    }
}