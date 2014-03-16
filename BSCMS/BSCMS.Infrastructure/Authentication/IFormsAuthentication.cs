namespace BSCMS.Infrastructure.Authentication
{
    public interface IFormsAuthentication
    {
        void SetAuthenticationToken(string token);
        void SignOut();
    }
}
