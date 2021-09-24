using Compori.MagentoApi.SoapClient.Helpers;
using System;
using Xunit;
using Xunit.Categories;

namespace MagentoApi.SoapClient.BaseUnitTests.Helpers
{
    [UnitTest]
    public class EndpointHelperTest
    {
        [Fact]
        public void TestCreateAddressFailure()
        {
            var sut = new EndpointHelper();
            ArgumentException argEx;
            argEx = Assert.Throws<ArgumentException>(() => sut.CreateAddress(null, null, null));
            Assert.Equal("serviceName", argEx.ParamName);
            argEx = Assert.Throws<ArgumentException>(() => sut.CreateAddress("", "", ""));
            Assert.Equal("serviceName", argEx.ParamName);
            argEx = Assert.Throws<ArgumentException>(() => sut.CreateAddress(null, "", null));
            Assert.Equal("serviceName", argEx.ParamName);
            argEx = Assert.Throws<ArgumentException>(() => sut.CreateAddress(null, "   ", null));
            Assert.Equal("serviceName", argEx.ParamName);
            argEx = Assert.Throws<ArgumentException>(() => sut.CreateAddress(null, "storeWebsiteRepositoryV1", null));
            Assert.Equal("storeView", argEx.ParamName);
            argEx = Assert.Throws<ArgumentException>(() => sut.CreateAddress(null, "storeWebsiteRepositoryV1", ""));
            Assert.Equal("storeView", argEx.ParamName);
            argEx = Assert.Throws<ArgumentException>(() => sut.CreateAddress(null, "storeWebsiteRepositoryV1", "   "));
            Assert.Equal("storeView", argEx.ParamName);

            Assert.Throws<ArgumentNullException>(() => sut.CreateAddress(null, "storeWebsiteRepositoryV1", "default"));
        }

        [Fact]
        public void TestCreateAddress()
        {
            var sut = new EndpointHelper();
            Assert.Equal("http://myshop.site/relative/soap/default?services=storeWebsiteRepositoryV1", sut.CreateAddress("http://myshop.site/relative", "storeWebsiteRepositoryV1", "default"));
            Assert.Equal("http://myshop.site/relative/soap/default?services=storeWebsiteRepositoryV1", sut.CreateAddress("http://myshop.site/relative/", "storeWebsiteRepositoryV1", "default"));
            Assert.Equal("https://myshop.site/relative/soap/default?services=storeWebsiteRepositoryV1", sut.CreateAddress("https://myshop.site/relative", "storeWebsiteRepositoryV1", "default"));
            Assert.Equal("https://myshop.site/relative/soap/default?services=storeWebsiteRepositoryV1", sut.CreateAddress("https://myshop.site/relative/", "storeWebsiteRepositoryV1", "default"));
        }

        [Fact]
        public void TestCreateEndpointAddress()
        {
            var sut = new EndpointHelper();
            Assert.Equal("http://myshop.site/relative/soap/default?services=storeWebsiteRepositoryV1", sut.CreateEndpointAddress("http://myshop.site/relative", "storeWebsiteRepositoryV1", "default").Uri.AbsoluteUri);
            Assert.Equal("http://myshop.site/relative/soap/default?services=storeWebsiteRepositoryV1", sut.CreateEndpointAddress("http://myshop.site/relative/", "storeWebsiteRepositoryV1", "default").Uri.AbsoluteUri);
            Assert.Equal("https://myshop.site/relative/soap/default?services=storeWebsiteRepositoryV1", sut.CreateEndpointAddress("https://myshop.site/relative", "storeWebsiteRepositoryV1", "default").Uri.AbsoluteUri);
            Assert.Equal("https://myshop.site/relative/soap/default?services=storeWebsiteRepositoryV1", sut.CreateEndpointAddress("https://myshop.site/relative/", "storeWebsiteRepositoryV1", "default").Uri.AbsoluteUri);
        }
    }
}
