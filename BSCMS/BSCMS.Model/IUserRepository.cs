namespace BSCMS.Model
{
    public interface IUserRepository
    {
        User FindBy(string username, string passwordHash);
    }
}
