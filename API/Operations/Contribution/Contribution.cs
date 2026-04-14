namespace BankModelApp.API.Operations.Contributer
{
    internal class Contribution : Operation
    {
        public string ContributionId { get; set; }
        public string AccountId { get; set; }
        public decimal Amount { get; set; }
        public DateTime ContributionDate { get; set; }
        public decimal InterestRate { get; set; }
        public ContributionStatus Status { get; set; }

        public Contribution(string accountId, decimal amount,
                           string currency, decimal interestRate)
        {
        }

        public decimal CalculateInterest()
        {

        }

        public void Activate()
        {

        }

        public void Close()
        {

        }

        public decimal GetTotalAmount()
        {

        }
    }
}
