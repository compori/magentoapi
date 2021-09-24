using Compori.MagentoApi.Authentication;
using DryIoc;

namespace Compori.MagentoApi.SoapClient.DryIoc
{
    public static class ContainerRegistration
    {
        /// <summary>
        /// Registers the magento token.
        /// </summary>
        /// <param name="container">The container.</param>
        public static void RegisterMagentoToken(IContainer container)
        {
            container.ThrowIfNull();

            // Register token related types.
            container.Register<ISystemDateTime, SystemDateTime>(reuse: Reuse.Singleton, ifAlreadyRegistered: IfAlreadyRegistered.Replace);
            container.Register<ITokenRequest, TokenRequest>(reuse: Reuse.Singleton, ifAlreadyRegistered: IfAlreadyRegistered.Replace);
            container.Register<TokenFactory>(reuse: Reuse.Singleton, ifAlreadyRegistered: IfAlreadyRegistered.Replace);

            // Register IToken by Factory expression
            container.Register(
                reuse: Reuse.Singleton,
                made: Made.Of(r => ServiceInfo.Of<TokenFactory>(), f => f.Create(Arg.Of<TokenSettings>())), 
                ifAlreadyRegistered: IfAlreadyRegistered.Replace);
        }

        /// <summary>
        /// Registers the magento SOAP client.
        /// </summary>
        /// <param name="container">The container.</param>
        public static void RegisterMagentoSoapClient(this IContainer container)
        {
            RegisterMagentoToken(container);

            container.ThrowIfNull();
            
            container.Register<IServiceRegistry, ServiceRegistry>(reuse: Reuse.Singleton, ifAlreadyRegistered: IfAlreadyRegistered.Replace);
            container.Register<IClientChannelFactory, ClientChannelFactory>(reuse: Reuse.Singleton, ifAlreadyRegistered: IfAlreadyRegistered.Replace);
        }

        /// <summary>
        /// Registers the magento soap client base.
        /// </summary>
        /// <param name="container">The container.</param>
        /// <param name="settings">The settings.</param>
        public static void RegisterMagento(this IContainer container, Settings.Settings settings)
        {
            container.UseInstance(settings, ifAlreadyRegistered: IfAlreadyRegistered.Replace);
            container.UseInstance(settings.Token, ifAlreadyRegistered: IfAlreadyRegistered.Replace);

            RegisterMagentoSoapClient(container);
        }
    }
}
