namespace BSCMS.Model
{
    public interface IUserRepository
    {
        User FindBy(UserAuthenticationQuery userAuthenticationQuery);
    }
}
