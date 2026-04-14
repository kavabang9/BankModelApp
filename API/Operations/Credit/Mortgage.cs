using BankModelApp.API.Operations;

namespace BankModelApp.API.Operations.Credit
{
    internal class Mortgage : Operation
    {
        public string PropertyAddress { get; set; }
        public decimal PropertyValue { get; set; }
        public decimal DownPayment { get; set; }
        public decimal LoanToValueRatio { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public bool IsInsuranceRequired { get; set; }

        public Mortgage(string accountId, decimal principal,
                       decimal interestRate, int termInMonths,
                       string propertyAddress, decimal propertyValue,
                       decimal downPayment)
            : base(accountId, principal, interestRate, termInMonths)
        {
        }
    }
}
