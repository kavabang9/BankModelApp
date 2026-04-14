using BankModelApp.API.Models.BankEntitiesStates.Cards;

namespace BankModelApp.API.Operations.Cards
{
    public interface ICreateCardStrategy
    {
        Card CreateCard(ICardFactory factory);
    }
}
