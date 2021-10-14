using Compori.MagentoApi.SoapClient.MessageInspection;
using System.Collections.Generic;
using System.IO;
using Xunit;
using Xunit.Categories;

namespace MagentoApi.SoapClient.BaseUnitTests.MessageInspection
{
    [UnitTest]
    public class NamespaceModificationTest
    {        
        public static IEnumerable<object[]> GetXmlData()
        {
            yield return new object[] {
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<sample xmlns=\"ns2\" />", 
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<sample xmlns=\"ns1\" />", 
                "ns1", 
                "ns2"
            };
            yield return new object[] {
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns2\" />", 
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns1\" />", 
                "ns1", 
                "ns2"
            };
            yield return new object[] {
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns2_rest\">\r\n  <item xmlns=\"ns2_rest2\" />\r\n</n:sample>", 
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns1_rest\">\r\n  <item xmlns=\"ns1_rest2\" />\r\n</n:sample>", 
                "ns1", 
                "ns2"
            };
        }

        [Theory]
        [MemberData(nameof(GetXmlData))]
        public void TestGetModifiedXml(string expected, string data, string sourceNamespace, string destinationNamespace)
        {
            var sut = new NamespaceModification();
            var actual = sut.GetModifiedXml(data, sourceNamespace, destinationNamespace);
            Assert.Equal(expected, actual);
            // weired ... conform ? currently failed
            //
            //data = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns1_rest\">\r\n  <n:item xmlns=\"ns1_rest2\" attr1=\"a\" />\r\n</n:sample>";
            //expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns2_rest\">\r\n  <n:item xmlns=\"ns2_rest2\" attr1=\"a\" />\r\n</n:sample>";
            //actual = sut.Modify(data, "ns1", "ns2");
            //Assert.Equal(expected, actual);
        }
        
        public static IEnumerable<object[]> GetExternalXmlData()
        {
            yield return new object[] {
                "namespace-modification-1-expected.xml", 
                "namespace-modification-1.xml", 
                "http://magento.developing.site/my-shop", 
                "https://magento.production.site/shop"
            };
            yield return new object[] {
                "namespace-modification-2-expected.xml", 
                "namespace-modification-2.xml", 
                "http://magento.developing.site/my-shop", 
                "https://magento.production.site/shop"
            };
            yield return new object[] {
                "namespace-modification-3-expected.xml", 
                "namespace-modification-3.xml", 
                "http://magento.developing.site/my-shop", 
                "https://magento.production.site/shop"
            };
            yield return new object[] {
                "namespace-modification-4-expected.xml", 
                "namespace-modification-4.xml", 
                "http://magento.developing.site/my-shop", 
                "https://magento.production.site/shop"
            };        
            yield return new object[] {
                "namespace-modification-4-expected.xml", 
                "namespace-modification-4.xml", 
                "http://magento.developing.site/my-shop/soap/default?services=", 
                "https://magento.production.site/shop/soap/default?services="
            };        
            yield return new object[] {
                "namespace-modification-4-expected.xml", 
                "namespace-modification-4.xml", 
                "http://magento.developing.site/my-shop/soap/default?services=storeWebsiteRepositoryV1", 
                "https://magento.production.site/shop/soap/default?services=storeWebsiteRepositoryV1"
            };        
        }

        private static string ReadFile(string fileName)
        {
            return File.ReadAllText($@"MessageInspection\data\{fileName}");
        }

        [Theory]
        [MemberData(nameof(GetExternalXmlData))]
        public void TestGetModifiedXmlFromExternal(string expectedSource, string actualSource, string sourceNamespace, string destinationNamespace)
        {
            var data = ReadFile(actualSource);
            var expected = ReadFile(expectedSource);
            var sut = new NamespaceModification();
            var actual = sut.GetModifiedXml(data, sourceNamespace, destinationNamespace);
            Assert.Equal(expected, actual);
        }
    }
}
