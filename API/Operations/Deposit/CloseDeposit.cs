using System;
using System.Collections.Generic;
using System.Text;

namespace BankModelApp.API.Operations.Deposit
{
    internal class CloseDeposit : Operation // Закрытие счета
    {
        private string depositId;
        private string accountId;
        private decimal accruedInterest; // Начисленные проценты
        private decimal principalAmount; // Основная сумма

        public DateTime CloseDate { get; set; }

        public CloseDeposit(string depositId, string accountId)
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

        private void CreditFundsToAccount()
        {

        }

        private void CheckEarlyClosureConditions()
        {

        }
    }
}
