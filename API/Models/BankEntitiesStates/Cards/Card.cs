namespace BankModelApp.API.Models.BankEntitiesStates.Cards
{
    public abstract class Card
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string OwnerName { get; set; }
        public abstract string GetCardType();
    }
}
