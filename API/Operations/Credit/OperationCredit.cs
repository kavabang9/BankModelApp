using System;
using System.Collections.Generic;
using System.Text;
using BankModelApp.API.Operations.Credit;

namespace BankModelApp.API.Operations.Credit
{
    internal class OperationCredit : Operation
    {
        private string accountId;
        private decimal principal; // Первоначальная сумма кредита без учёта процентов, комиссий и других начислений.
        private decimal interestRate; 
        private int termInMonths;
        private Credit credit;

        public OperationCredit(string accountId, decimal principal,
                               decimal interestRate, int termInMonths)
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

        private void CheckCreditworthiness()
        {

        }

        private void CreditFundsToAccount()
        {

        }

        private void CreatePaymentSchedule()
        {

        }
    }
}
