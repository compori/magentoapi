using Compori.MagentoApi.SoapClient;
using Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CatalogProductRepositoryV1;
using Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModelExtensions;
using Xunit;

namespace MagentoApi.SoapClient.RemoteServices.Core243IntegrationTests.ResourceModel
{
    public class CatalogProductRepositoryV1Test
    {
        [Fact()]
        public async void TestCreateStoreViewAllAsync()
        {
            var sut = Container.Resolve<IClientChannelFactory>().Create<catalogProductRepositoryV1PortTypeChannel>("all");

            // Failed because product does not exist. currently no paremeters will be provvided by this fault.
            var e = await Assert.ThrowsAsync<System.ServiceModel.FaultException<GenericFault>>(() => sut.DeleteByIdAsync(System.Guid.NewGuid().ToString()));
            Assert.NotNull(e.Detail);
            Assert.Null(e.Detail.Parameters);
        }

        [Fact()]
        public async void TestDeleteByIdFailureAsync()
        {
            var sut = Container.Resolve<catalogProductRepositoryV1PortTypeChannel>();

            // Failed because product does not exist. currently no paremeters will be provvided by this fault.
            var e = await Assert.ThrowsAsync<System.ServiceModel.FaultException<GenericFault>>(
                () => sut.catalogProductRepositoryV1DeleteByIdAsync(new catalogProductRepositoryV1DeleteByIdRequest1
                {
                    catalogProductRepositoryV1DeleteByIdRequest = new CatalogProductRepositoryV1DeleteByIdRequest
                    {
                        sku = System.Guid.NewGuid().ToString()
                    }
                }));

            Assert.NotNull(e.Detail);
            Assert.Null(e.Detail.Parameters);
        }
        
        [Fact()]
        public async System.Threading.Tasks.Task TestSaveFailureAsync()
        {
            // Failed because attribute set is not set
            var sut = Container.Resolve<catalogProductRepositoryV1PortTypeChannel>();
            var e = await Assert.ThrowsAsync<System.ServiceModel.FaultException<GenericFault>>(
                () => sut.catalogProductRepositoryV1SaveAsync(new catalogProductRepositoryV1SaveRequest1
                {
                    catalogProductRepositoryV1SaveRequest = new CatalogProductRepositoryV1SaveRequest
                    {
                        product = new CatalogDataProductInterface
                        {
                            attributeSetIdSpecified = true,
                            attributeSetId = -1,
                            idSpecified = true,
                            id = -1
                        }
                    }
                }));

            Assert.NotNull(e.Detail);
            Assert.NotNull(e.Detail.Parameters);
            Assert.NotEmpty(e.Detail.Parameters);
        }
    }
}
