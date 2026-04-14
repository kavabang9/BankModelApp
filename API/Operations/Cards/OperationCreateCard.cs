using BankModelApp.API.Models.BankEntitiesStates.Cards;

namespace BankModelApp.API.Operations.Cards
{
    public class OperationCreateCard : Operation
    {
        private readonly ICreateCardStrategy strategy;
        private readonly ICardFactory factory;
        public Card CreatedCard { get; set; }

        public OperationCreateCard(ICreateCardStrategy strategy, ICardFactory factory)
        {
            this.strategy = strategy;
            this.factory = factory;
        }

        public override void Execute()
        {

        }
        public override void Validate()
        {

        }
        public override void Rollback()
        {

        }
        public override void OperationDetails()
        {

        }
    }
}
