using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
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
            });
        }
    }
}