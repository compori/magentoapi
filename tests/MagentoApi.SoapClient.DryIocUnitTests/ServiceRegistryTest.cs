using Compori.MagentoApi;
using Compori.MagentoApi.Authentication;
using Compori.MagentoApi.Settings;
using Compori.MagentoApi.SoapClient.DryIoc;
using DryIoc;
using MagentoApi.SoapClient.DryIocUnitTests.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Categories;

namespace MagentoApi.SoapClient.DryIocUnitTests
{
    [UnitTest, Trait("TestType", "Unit")]
    public class ServiceRegistryTest
    {
        [Fact]
        public void TestRegister()
        {
            var container = new Container();
            var settings = new Settings
            { 
                BaseEndpointAddress = "http://example.com",
                Token = new TokenSettings 
                { 
                    TokenType = TokenType.Integration,
                    AccessToken = "ABC1234"
                } 
            };

            ContainerRegistration.RegisterMagento(container, settings);
            Assert.Null(container.Resolve<test2ServiceV1PortTypeChannel>(true));

            var sut = container.Resolve<IServiceRegistry>();

            sut.Register(typeof(test2ServiceV1PortTypeChannel), "test2ServiceV1");

            var client1 = container.Resolve<test2ServiceV1PortTypeChannel>(true);
            Assert.NotNull(client1);

            var client2 = container.Resolve<test2ServiceV1PortTypeChannel>();
            Assert.Same(client1, client2);
        }

        [Fact]
        public void TestResolve()
        {
            var container = new Container();
            var settings = new Settings
            { 
                BaseEndpointAddress = "http://example.com",
                Token = new TokenSettings 
                { 
                    TokenType = TokenType.Integration,
                    AccessToken = "ABC1234"
                } 
            };

            container.Register<ExampleClass>();
            ContainerRegistration.RegisterMagento(container, settings);
            var sut = container.Resolve<IServiceRegistry>();

            Assert.Null(container.Resolve<ExampleClass>(IfUnresolved.ReturnDefault));
            sut.Register(typeof(test2ServiceV1PortTypeChannel), "test2ServiceV1");
            Assert.NotNull(container.Resolve<ExampleClass>());
            Assert.NotNull(container.Resolve<ExampleClass>().client);
        }
    }
}
