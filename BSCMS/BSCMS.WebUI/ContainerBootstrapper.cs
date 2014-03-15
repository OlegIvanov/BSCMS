using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;

namespace BSCMS.WebUI
{
    public static class ContainerBootstrapper
    {
        public static void BootstrapStructureMap()
        {
            ObjectFactory.Initialize(x => 
            { 
            });
        }
    }
}