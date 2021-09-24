using System;
using System.Linq;

namespace Compori.MagentoApi
{
    public abstract class Registration
    {
        /// <summary>
        /// Registers all remote services in an assembly.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assembly">The assembly.</param>
        /// <param name="registry">The service registry.</param>
        /// <param name="namespaceName">Name of the namespace.</param>
        /// <param name="interfaceNameSuffix">The interface name suffix.</param>
        /// <exception cref="ArgumentNullException">assembly</exception>
        /// <exception cref="ArgumentNullException">registry</exception>
        public void RegisterAssembly<T>(System.Reflection.Assembly assembly, IServiceRegistry registry, string namespaceName = null, string interfaceNameSuffix = null)
        {
            if(assembly == null)
            {
                throw new ArgumentNullException(nameof(assembly));
            }
            if (registry == null)
            {
                throw new ArgumentNullException(nameof(registry));
            }

            //
            // find all interfaces in assembly that inherits the given type interface in a (sub) namespace
            //
            var clientInterfaces = assembly.GetTypes().Where( t =>
                t.IsInterface
                && t.GetInterfaces().Contains(typeof(T))
                && (string.IsNullOrWhiteSpace(namespaceName) || t.Namespace.StartsWith(namespaceName)));

            
            foreach (var clientInterface in clientInterfaces)
            {
                var name = clientInterface.Name;
                var serviceName = name;
            
                //
                // If a suffix is provided, substring service name 
                //
                if (!string.IsNullOrWhiteSpace(interfaceNameSuffix))
                {
                    // naming convention
                    //
                    // RemoteServices.<ServiceNameXyz>.<serviceNameXyz>PortTypeChannel
                    if(!name.EndsWith(interfaceNameSuffix))
                    {
                        continue;
                    }

                    serviceName = name.Substring(0, name.Length - interfaceNameSuffix.Length);
                    if (string.IsNullOrEmpty(serviceName))                
                    {
                        continue;
                    }
                }
                
                //
                // Register interface with service name
                //
                registry.Register(clientInterface, serviceName);
            }
        }

        /// <summary>
        /// Registers the remote services in implementing assembly to the service registry.
        /// </summary>
        /// <param name="registry">The service registry.</param>
        public abstract void Register(IServiceRegistry registry);
    }
}
