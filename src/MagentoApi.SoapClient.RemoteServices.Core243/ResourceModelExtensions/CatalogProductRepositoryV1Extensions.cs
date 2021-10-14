using Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.CatalogProductRepositoryV1;
using System.Threading.Tasks;

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModelExtensions
{
    public static class CatalogProductRepositoryV1Extensions
    {
        /// <summary>
        /// Delete by identifier as an asynchronous operation.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="sku">The sku.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static async Task<bool> DeleteByIdAsync(this catalogProductRepositoryV1PortTypeChannel client, string sku)
        {
            var result = await client.catalogProductRepositoryV1DeleteByIdAsync(new catalogProductRepositoryV1DeleteByIdRequest1
            {
                catalogProductRepositoryV1DeleteByIdRequest = new CatalogProductRepositoryV1DeleteByIdRequest
                {
                    sku = sku
                }
            });

            return result?.catalogProductRepositoryV1DeleteByIdResponse?.result ?? false;
        }
    }
}
