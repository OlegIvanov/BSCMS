using System.Web.Configuration;
using BSCMS.Infrastructure.Configuration;
using BSCMS.Model;
using BSCMS.Repository;
using StructureMap;

namespace BSCMS.WebUI
{
    public static class ContainerBootstrapper
    {
        public static void BootstrapStructureMap()
        {
            ObjectFactory.Initialize(x => 
            {
                x.For<IUserRepository>().Use<UserRepository>().Ctor<string>().Is(WebConfigurationManager.ConnectionStrings["BookStore"].ConnectionString);
                x.For<IBookRepository>().Use<BookRepository>().Ctor<string>().Is(WebConfigurationManager.ConnectionStrings["BookStore"].ConnectionString);

                x.For<IApplicationSettings>().Use<WebConfigApplicationSettings>();
            });
        }
    }
}