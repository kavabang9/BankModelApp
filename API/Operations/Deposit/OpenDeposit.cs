namespace BankModelApp.API.Operations.Deposit
{
    internal class OpenDeposit : Operation // Открытие счета
    {
        private string accountId;
        private decimal amount;
        private decimal interestRate;

        public string DepositId { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }

        public OpenDeposit(string accountId, decimal amount, decimal interestRate)
        {
        }
    }
}
