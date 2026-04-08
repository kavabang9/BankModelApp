namespace BankModelApp.API.Service
{
    internal class JwtToken
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }

        public string SendingToken()
        {
            return Token;
        }
    }
}