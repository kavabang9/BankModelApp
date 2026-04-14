using BankModelApp.API.Operations;

namespace BankModelApp.API.Model.Credit
{
    internal class Credit : Operation
    {
        public string CreditId { get; set; }
        public string AccountId { get; set; }
        public decimal Principal { get; set; }
        public decimal InterestRate { get; set; }
        public int TermInMonths { get; set; }
        public decimal MonthlyPayment { get; set; }
        public decimal RemainingBalance { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public CreditStatus Status { get; set; }
    }
}
