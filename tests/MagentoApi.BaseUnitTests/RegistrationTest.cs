using Compori.MagentoApi;
using System;
using Xunit.Categories;
using Xunit;
using System.ServiceModel;
using MagentoApi.BaseUnitTests.Fixtures.Registration.RemoteServices;
using MagentoApi.BaseUnitTests.Fixtures.Registration.NotRemoteServices;
using MagentoApi.BaseUnitTests.Fixtures.Registration.RemoteServices.SubNamespace;

namespace MagentoApi.BaseUnitTests
{
    [UnitTest]
    public class RegistrationTest
    {
        [Fact]
        public void TestRegisterAssemblyFailure()
        {            
            IServiceRegistry registry = new ServiceRegistry();

            ArgumentNullException argNullEx;
            argNullEx = Assert.Throws<ArgumentNullException>(() => Registration.RegisterAssembly<IClientChannel>(null, null));
            Assert.Equal("assembly", argNullEx.ParamName);
            argNullEx = Assert.Throws<ArgumentNullException>(() => Registration.RegisterAssembly<IClientChannel>(null, registry));
            Assert.Equal("assembly", argNullEx.ParamName);
            argNullEx = Assert.Throws<ArgumentNullException>(() => Registration.RegisterAssembly<IClientChannel>(this.GetType().Assembly, null));
            Assert.Equal("registry", argNullEx.ParamName);
        }

        [Fact]
        public void RegisterAssemblyTest()
        {            
            IServiceRegistry registry = new ServiceRegistry();

            Assert.Null(registry.Find(typeof(PortTypeChannel)));
            Assert.Null(registry.Find(typeof(test1ServiceV1PortTypeChannel)));
            Assert.Null(registry.Find(typeof(test2ServiceV1PortTypeChannel)));
            Assert.Null(registry.Find(typeof(test3ServiceV1PortTypeChannel)));
            Assert.Null(registry.Find(typeof(test4ServiceV1PortTypoChannel)));

            Registration.RegisterAssembly<IClientChannel>(this.GetType().Assembly, registry, "MagentoApi.BaseUnitTests.Fixtures.Registration.RemoteServices", "PortTypeChannel");

            Assert.Null(registry.Find(typeof(PortTypeChannel)));
            Assert.Null(registry.Find(typeof(test1ServiceV1PortTypeChannel)));
            Assert.Null(registry.Find(typeof(test3ServiceV1PortTypeChannel)));
            Assert.Null(registry.Find(typeof(test4ServiceV1PortTypoChannel)));

            var item = registry.Find(typeof(test2ServiceV1PortTypeChannel));
            Assert.NotNull(item);
            Assert.Equal(typeof(test2ServiceV1PortTypeChannel), item.Type);
            Assert.Equal("test2ServiceV1", item.Name);

            item = registry.Find(typeof(test5ServiceV1PortTypeChannel));
            Assert.NotNull(item);
            Assert.Equal(typeof(test5ServiceV1PortTypeChannel), item.Type);
            Assert.Equal("test5ServiceV1", item.Name);
            
        }
    }
}
