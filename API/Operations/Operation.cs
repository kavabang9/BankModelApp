using System;
using System.Collections.Generic;
using System.Text;

namespace BankModelApp.API.Operations
{
    public abstract class Operation
    {
        public string OperationId { get; set; }
        public string OperationName { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid Id { get; set; }

        public abstract void Execute();
        public abstract void Validate();
        public abstract void Rollback();
        public abstract void OperationDetails();
    }
}
