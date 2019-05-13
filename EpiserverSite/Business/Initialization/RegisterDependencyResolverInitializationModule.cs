using System;
using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EpiserverSite.Business.DependencyResolvers;
using System.Web.Mvc;
using EPiServer.ServiceLocation;

namespace EpiserverSite.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RegisterDependencyResolverInitializationModule : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.StructureMap()));
            //Implementations for custom interfaces can be registered here.
            context.ConfigurationComplete += (o, e) =>
            {
                //Register custom implementations that should be used in favour of the
                //default implementations
            };
        }

        public void Initialize(InitializationEngine context) { }
        public void Uninitialize(InitializationEngine context) { }
    }
}