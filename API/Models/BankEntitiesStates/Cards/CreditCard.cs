using BankModelApp.API.Models.BankEntitiesStates.Cards;

namespace BankModelApp.API.Models.BankEntities.Cards
{
    public class CreditCard : Card
    {
        public decimal Debt { get; set; }
        public override string GetCardType()
        {
            return "CreditCard";
        }
    }
}
