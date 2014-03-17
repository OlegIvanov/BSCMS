namespace BSCMS.Infrastructure.Authentication
{
    public interface IFormsAuthentication
    {
        void SetAuthenticationToken(string token, string userName);
        void SignOut();
    }
}
