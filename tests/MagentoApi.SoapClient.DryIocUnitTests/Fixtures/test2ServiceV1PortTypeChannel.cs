namespace MagentoApi.SoapClient.DryIocUnitTests.Fixtures
{
#pragma warning disable IDE1006 // Naming style
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://example.com/soap/default?services=test2ServiceV1")]
    public interface test2ServiceV1PortTypeChannel : System.ServiceModel.IClientChannel
#pragma warning restore IDE1006 // Naming style
    {
        [System.ServiceModel.OperationContractAttribute(Action = "GetSum", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute()]
        System.Threading.Tasks.Task<int> GetSumAsync(int a, int b);
    }
}
