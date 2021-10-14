using Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModel.StoreWebsiteRepositoryV1;
using System.Threading.Tasks;

namespace Compori.MagentoApi.SoapClient.RemoteServices.Core.ResourceModelExtensions
{
    public static class StoreWebsiteRepositoryV1Extensions
    {
        /// <summary>
        /// Gets the list asynchronous.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <returns>Task&lt;storeWebsiteRepositoryV1GetListResponse1&gt;.</returns>
        public static async Task<StoreDataWebsiteInterface[]> GetListAsync(this storeWebsiteRepositoryV1PortTypeChannel client)
        {
            var result = await client.storeWebsiteRepositoryV1GetListAsync(new storeWebsiteRepositoryV1GetListRequest1
            {
                storeWebsiteRepositoryV1GetListRequest = new StoreWebsiteRepositoryV1GetListRequest
                {                    
                }
            });

            return result?.storeWebsiteRepositoryV1GetListResponse?.result;
        }
    }
}
