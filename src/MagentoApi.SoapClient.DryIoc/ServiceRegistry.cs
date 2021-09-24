using DryIoc;

namespace Compori.MagentoApi.SoapClient.DryIoc
{
    /// <summary>
    /// Class ServiceRegistry.
    /// </summary>
    /// <seealso cref="Compori.Magento.ServiceRegistry" />
    public class ServiceRegistry : MagentoApi.ServiceRegistry
    {
        /// <summary>
        /// The container
        /// </summary>
        protected IContainer container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRegistry"/> class.
        /// </summary>
        /// <param name="container">The container.</param>
        public ServiceRegistry(IContainer container)
        {
            this.container = container;
        }

        /// <summary>
        /// Registers the specified service.
        /// </summary>
        /// <param name="item">The specified service.</param>
        /// <returns>ServiceRegistryItem.</returns>
        protected override ServiceRegistryItem Register(ServiceRegistryItem item)
        {
            var registeredItem = base.Register(item);

            //
            // Add service into container evertime someone registered an item with the service registry.
            //
            this.container.RegisterDelegate(
                item.Type,
                (ctx) => {
                    return ctx.Resolve<IClientChannelFactory>().Create(item.Name);
                },
                Reuse.Singleton,
                null,
                IfAlreadyRegistered.Replace);

            return registeredItem;
        }
    }
}
