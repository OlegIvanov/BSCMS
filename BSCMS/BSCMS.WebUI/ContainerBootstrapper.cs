using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using BSCMC.Model;
using BSCMS.Repository;

namespace BSCMS.WebUI
{
    public static class ContainerBootstrapper
    {
        public static void BootstrapStructureMap()
        {
            ObjectFactory.Initialize(x => 
            {
                x.For<IUserRepository>().Use<UserRepository>();
            });
        }
    }
}