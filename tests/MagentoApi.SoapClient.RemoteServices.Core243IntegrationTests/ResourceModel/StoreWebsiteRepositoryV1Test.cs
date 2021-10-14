using Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.StoreWebsiteRepositoryV1;
using Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModelExtensions;
using System.Linq;
using Xunit;

namespace MagentoApi.SoapClient.RemoteServices.Core243IntegrationTests.ResourceModel
{
    public class StoreWebsiteRepositoryV1Test
    {
        [Fact()]
        public async void TestGetListAsync()
        {
            var sut = Container.Resolve<storeWebsiteRepositoryV1PortTypeChannel>();

            var result = await sut.GetListAsync();

            // Admin store view should always be there
            Assert.NotNull(result);
            Assert.Contains("admin", result.Select( v => v.code));
        }
    }
}
