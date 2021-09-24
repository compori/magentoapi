using DryIoc;

namespace Compori.MagentoApi.SoapClient.DryIoc.Extensions
{
    public static class ContainerExtensions
    {
        /// <summary>
        /// Extends container with the token registration.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns>IContainer.</returns>
        public static IContainer WithMagentoToken(this IContainer container)
        {
            ContainerRegistration.RegisterMagentoToken(container);

            return container;
        }

        /// <summary>
        /// Registers the magento core objects in container.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <returns>IContainer.</returns>
        public static IContainer WithMagentoSoapClient(this IContainer container)
        {
            ContainerRegistration.RegisterMagentoSoapClient(container);

            return container;
        }

        /// <summary>
        /// Withes the magento.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="settings">The settings.</param>
        /// <returns>IContainer.</returns>
        public static IContainer WithMagento(this IContainer container, Settings.Settings settings)
        {
            ContainerRegistration.RegisterMagento(container, settings);

            return container;
        }
    }
}
