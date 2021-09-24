using System;

namespace Compori.MagentoApi
{
    public class ServiceRegistryItem
    {
        /// <summary>
        /// Gets the type.
        /// </summary>
        /// <value>The type.</value>
        public Type Type { get; private set; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this instance is store view capable.
        /// </summary>
        /// <value><c>true</c> if this instance is store view capable; otherwise, <c>false</c>.</value>
        public bool IsStoreViewCapable { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceRegistryItem"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="name">The name.</param>
        /// <param name="isStoreViewCapable">if set to <c>true</c> [is store view capable].</param>
        public ServiceRegistryItem(Type type, string name, bool isStoreViewCapable)
        {
            this.Type = type;
            this.Name = name;
            this.IsStoreViewCapable = isStoreViewCapable;
        }
    }
}
