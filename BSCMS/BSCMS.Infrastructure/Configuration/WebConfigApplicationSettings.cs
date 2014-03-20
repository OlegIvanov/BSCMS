using System.Web.Configuration;

namespace BSCMS.Infrastructure.Configuration
{
    public class WebConfigApplicationSettings : IApplicationSettings
    {
        public string BookCoversFolderName
        {
            get { return WebConfigurationManager.AppSettings["BookCoversFolderName"]; }
        }

        public string PasswordSalt
        {
            get { return WebConfigurationManager.AppSettings["PasswordSalt"]; }
        }
    }
}
