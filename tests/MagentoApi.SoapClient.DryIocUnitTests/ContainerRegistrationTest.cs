using Compori.MagentoApi;
using Compori.MagentoApi.Authentication;
using Compori.MagentoApi.Settings;
using Compori.MagentoApi.SoapClient;
using Compori.MagentoApi.SoapClient.DryIoc;
using DryIoc;
using Xunit;
using Xunit.Categories;

namespace MagentoApi.SoapClient.DryIocUnitTests
{
    [UnitTest]
    public class ContainerRegistrationTest
    {
        [Fact]
        public void TestRegisterMagentoToken()
        {
            var container = new Container();
            ContainerRegistration.RegisterMagentoToken(container);

            Assert.NotNull(container.Resolve<ISystemDateTime>(true));
            Assert.NotNull(container.Resolve<ITokenRequest>(true));
            Assert.NotNull(container.Resolve<TokenFactory>(true));
            Assert.Null(container.Resolve<IToken>(true));

            container.UseInstance(new TokenSettings 
                { 
                    TokenType = TokenType.Integration,
                    AccessToken = "ABC1234"
                } 
            );

            Assert.NotNull(container.Resolve<IToken>(true));
        }

        [Fact]
        public void TestRegisterMagentoSoapClient()
        {
            var container = new Container();
            var settings = new Settings
            { 
                Token = new TokenSettings 
                { 
                    TokenType = TokenType.Integration,
                    AccessToken = "ABC1234"
                } 
            };
            ContainerRegistration.RegisterMagentoSoapClient(container);

            Assert.NotNull(container.Resolve<IServiceRegistry>(true));
            Assert.Null(container.Resolve<IClientChannelFactory>(true));
            container.UseInstance(settings);
            container.UseInstance(settings.Token);
            Assert.NotNull(container.Resolve<IClientChannelFactory>(true));
        }

        [Fact]
        public void TestRegisterMagento()
        {
            var container = new Container();
            var settings = new Settings
            { 
                Token = new TokenSettings 
                { 
                    TokenType = TokenType.Integration,
                    AccessToken = "ABC1234"
                } 
            };
            ContainerRegistration.RegisterMagento(container, settings);

            Assert.NotNull(container.Resolve<IServiceRegistry>(true));
            Assert.NotNull(container.Resolve<IClientChannelFactory>(true));
            Assert.NotNull(container.Resolve<ISystemDateTime>(true));
            Assert.NotNull(container.Resolve<ITokenRequest>(true));
            Assert.NotNull(container.Resolve<TokenFactory>(true));
            Assert.NotNull(container.Resolve<IToken>(true));
        }
    }
}
