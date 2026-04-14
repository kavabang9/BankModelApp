using System;
using System.Collections.Generic;
using System.Text;

namespace BankModelApp.API.Operations.Contribution
{
    internal class OperationContribution : Operation
    {
        private string accountId;
        private decimal amount;
        private string currency;
        private decimal interestRate;
        private Contribution contribution;

        public OperationContribution(string accountId, decimal amount,
                                     string currency, decimal interestRate)
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

        private void CreateContribution()
        {

        }

        private void DebitFunds()
        {

        }
    }
}
