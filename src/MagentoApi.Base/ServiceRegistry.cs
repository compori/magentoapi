using System;
using System.Collections.Concurrent;

namespace Compori.MagentoApi
{

    public class ServiceRegistry : IServiceRegistry
    {
        /// <summary>
        /// The services lookup via service name
        /// </summary>
        private readonly ConcurrentDictionary<string, ServiceRegistryItem> _serviceNames;

        /// <summary>
        /// The services lookup via service type
        /// </summary>
        private readonly ConcurrentDictionary<Type, ServiceRegistryItem> _serviceTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRegistry"/> class.
        /// </summary>
        public ServiceRegistry()
        {
            this._serviceNames = new ConcurrentDictionary<string, ServiceRegistryItem>();
            this._serviceTypes = new ConcurrentDictionary<Type, ServiceRegistryItem>();
        }

        /// <summary>
        /// Registers the specified service.
        /// </summary>
        /// <param name="item">The specified service.</param>
        protected virtual ServiceRegistryItem Register(ServiceRegistryItem item)
        {
            var result = this._serviceNames.AddOrUpdate(item.Name, item, (k,v) => item);
            result = this._serviceTypes.AddOrUpdate(item.Type, item, (k, v) => item);
            return result;
        }

        /// <summary>
        /// Finds the specified service registry item by service type.
        /// </summary>
        /// <param name="type">The service type.</param>
        /// <returns>ServiceRegistryItem.</returns>
        protected ServiceRegistryItem Find(Type type)
        {
            if (this._serviceTypes.TryGetValue(type, out ServiceRegistryItem result))
            {
                return result;
            }
            return null;
        }

        /// <summary>
        /// Finds the specified service registry item by service name.
        /// </summary>
        /// <param name="name">The service name.</param>
        /// <returns>ServiceRegistryItem.</returns>
        protected ServiceRegistryItem Find(string name)
        {
            if (this._serviceNames.TryGetValue(name, out ServiceRegistryItem result))
            {
                return result;
            }
            return null;
        }

        #region IServiceRegistry Implementation

        /// <summary>
        /// Registers the specified service.
        /// </summary>
        /// <param name="item">The specified service.</param>
        void IServiceRegistry.Register(ServiceRegistryItem item)
        {
            this.Register(item);
        }

        /// <summary>
        /// Registers the specified service type with name.
        /// </summary>
        /// <param name="type">The service type.</param>
        /// <param name="name">The service name.</param>
        void IServiceRegistry.Register(Type type, string name)
        {
            this.Register(new ServiceRegistryItem(type, name, false));
        }

        /// <summary>
        /// Registers the specified type.
        /// </summary>
        /// <param name="type">The service type.</param>
        /// <param name="name">The service name.</param>
        /// <param name="isStoreViewCapable">if set to <c>true</c> if service is store view capable.</param>
        void IServiceRegistry.Register(Type type, string name, bool isStoreViewCapable)
        {
            this.Register(new ServiceRegistryItem (type, name, isStoreViewCapable));
        }

        /// <summary>
        /// Finds the specified service registry item by service type.
        /// </summary>
        /// <param name="type">The service type.</param>
        /// <returns>ServiceRegistryItem.</returns>
        ServiceRegistryItem IServiceRegistry.Find(Type type)
        {
            return this.Find(type);
        }
        /// <summary>
        /// Finds the specified service registry item by service name.
        /// </summary>
        /// <param name="name">The service name.</param>
        /// <returns>ServiceRegistryItem.</returns>
        ServiceRegistryItem IServiceRegistry.Find(string name)
        {
            return this.Find(name);
        }

        #endregion
    }
}