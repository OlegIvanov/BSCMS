using System.Web.Configuration;

namespace BSCMS.Infrastructure.Configuration
{
    public class WebConfigApplicationSettings : IApplicationSettings
    {
        public string BookCoversFolderName
        {
            get { return WebConfigurationManager.AppSettings["BookCoversFolderName"]; }
        }
    }
}
