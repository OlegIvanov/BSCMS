namespace BSCMS.Infrastructure.Configuration
{
    public interface IApplicationSettings
    {
        string BookCoversFolderName { get; }
        string PasswordSalt { get; }
    }
}
