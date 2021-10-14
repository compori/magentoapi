using System.ServiceModel;

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core
{
    public sealed class Registration
    {
        /// <summary>
        /// Registers the remote services in implementing assembly to the service registry.
        /// Short hand:  (new Registration()).Register(registry);
        /// </summary>
        /// <param name="registry">The service registry.</param>
        public static void Register(IServiceRegistry registry)
        {
            MagentoApi.Registration.RegisterAssembly<IClientChannel>(
                typeof(Registration).Assembly, 
                registry, 
                "Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel", 
                "PortTypeChannel");

            registry.Register(
                new ServiceRegistryItem(typeof(ResourceModel.CatalogCategoryRepositoryV1.catalogCategoryRepositoryV1PortTypeChannel), "catalogCategoryRepositoryV1", true));
            registry.Register(
                new ServiceRegistryItem(typeof(ResourceModel.CatalogProductRepositoryV1.catalogProductRepositoryV1PortTypeChannel), "catalogProductRepositoryV1", true));
        }
    }
}
