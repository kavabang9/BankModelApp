namespace BankModelApp.API
{
    internal interface IBankingService
    {
        event EventHandler ServiceRequested;
        event EventHandler DocumentMissing;
    }
}
