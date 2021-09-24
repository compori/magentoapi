using System.ServiceModel;

namespace Compori.MagentoApi.SoapClient
{
    /// <summary>
    /// Interface IClientChannelFactory
    /// </summary>
    public interface IClientChannelFactory
    {
        /// <summary>
        /// Creates the specified type.
        /// </summary>
        /// <param name="name">The service name.</param>
        /// <returns>IClientChannel.</returns>
        IClientChannel Create(string name);

        /// <summary>
        /// Creates the specified type.
        /// </summary>
        /// <param name="name">The service name.</param>
        /// <param name="storeView">The store view.</param>
        /// <returns>IClientChannel.</returns>
        IClientChannel Create(string name, string storeView);

        /// <summary>
        /// Creates the client channel for the default store.
        /// </summary>
        /// <typeparam name="T">Requested ClientChannel interface</typeparam>
        /// <returns>T.</returns>
        T Create<T>() where T : IClientChannel;

        /// <summary>
        /// Creates the client channel for the specified store.
        /// </summary>
        /// <typeparam name="T">Requested ClientChannel interface</typeparam>
        /// <param name="storeView">The store view.</param>
        /// <returns>T.</returns>
        T Create<T>(string storeView) where T : IClientChannel;
    }
}
