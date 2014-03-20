namespace BSCMS.Service.Messages
{
    public class AuthenticateResponse
    {
        public bool IsAuthenticated { get; set; }
        public string AuthenticationToken { get; set; }
        public string Username { get; set; }
    }
}
