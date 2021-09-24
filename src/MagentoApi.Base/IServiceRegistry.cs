using System;

namespace Compori.MagentoApi
{
    /// <summary>
    /// Interface IServiceRegistry
    /// </summary>
    public interface IServiceRegistry
    {
        /// <summary>
        /// Finds the specified service registry item by service type.
        /// </summary>
        /// <param name="type">The service type.</param>
        /// <returns>ServiceRegistryItem.</returns>
        ServiceRegistryItem Find(Type type);

        /// <summary>
        /// Finds the specified service registry item by service name.
        /// </summary>
        /// <param name="name">The service name.</param>
        /// <returns>ServiceRegistryItem.</returns>
        ServiceRegistryItem Find(string name);

        /// <summary>
        /// Registers the specified service.
        /// </summary>
        /// <param name="item">The specified service.</param>
        void Register(ServiceRegistryItem item);

        /// <summary>
        /// Registers the specified service type with name.
        /// </summary>
        /// <param name="type">The service type.</param>
        /// <param name="name">The service name.</param>
        void Register(Type type, string name);

        /// <summary>
        /// Registers the specified type.
        /// </summary>
        /// <param name="type">The service type.</param>
        /// <param name="name">The service name.</param>
        /// <param name="isStoreViewCapable">if set to <c>true</c> the service is store view capable.</param>
        void Register(Type type, string name, bool isStoreViewCapable);
    }
}
