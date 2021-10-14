using Compori.MagentoApi;
using Compori.MagentoApi.Settings;
using Compori.MagentoApi.SoapClient.DryIoc;
using Compori.MagentoApi.SoapClient.RemoteServices.Core;
using DryIoc;

namespace MagentoApi.SoapClient.RemoteServices.Core243IntegrationTests
{
    public class Container
    {
        /// <summary>
        /// Creates a new container an registered magento soap base client and core resource models.
        /// </summary>
        /// <returns>IContainer.</returns>
        public static IContainer Create()
        {
            var container = new DryIoc.Container();
            
            // Register Basis
            ContainerRegistration.RegisterMagento(container, Loader.Load("integration.testserver.ignore.xml"));

            // Register core source model via service a registry
            Compori.MagentoApi.SoapClient.RemoteServices.Core.Registration.Register(container.Resolve<IServiceRegistry>());

            return container;
        }

        /// <summary>
        /// Resolves this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T.</returns>
        public static T Resolve<T>()
        {
            return Create().Resolve<T>();
        }
    }
}
