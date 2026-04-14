using System;
using System.Collections.Generic;
using System.Text;

namespace BankModelApp.API.Operations.Credit
{
    internal class OperationMortgage : Operation
    {
        private string accountId;
        private decimal principal;
        private decimal interestRate;
        private int termInMonths;
        private string propertyAddress;
        private decimal propertyValue;
        private decimal downPayment;
        private Mortgage mortgage;

        public OperationMortgage(string accountId, decimal principal,
                                 decimal interestRate, int termInMonths,
                                 string propertyAddress, decimal propertyValue,
                                 decimal downPayment)
        {
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

        public override string GetOperationDetails()
        {

        }

        private void ValidatePropertyDocuments()
        {

        }

        private void CheckDownPaymentSufficiency()
        {

        }

        private void SetupInsurance()
        {

        }

        private void CreditFundsToAccount()
        {

        }
    }
}
