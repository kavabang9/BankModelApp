namespace BankModelApp.API.Service
{
    internal class JwtToken
    {
        public string Token { get; set; }
        public int ExpiresIn { get; set; }
        public string RefreshToken { get; set; }
    }
}