using BankModelApp.API.Models.BankEntitiesStates.Cards;

namespace BankModelApp.API.Models.BankEntities.Cards
{
    public class DebtCard : Card
    {
        public decimal Balance { get; set; }
        public override string GetCardType()
        {
            return "DebtCard";
        }
    }
}
