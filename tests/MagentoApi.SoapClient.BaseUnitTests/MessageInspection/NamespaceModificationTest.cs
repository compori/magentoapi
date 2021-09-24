using Compori.MagentoApi.SoapClient.MessageInspection;
using System.IO;
using Xunit;
using Xunit.Categories;

namespace MagentoUnitTest.MessageInspection
{
    [UnitTest]
    public class NamespaceModificationTest
    {
        private static string ReadFile(string fileName)
        {
            return File.ReadAllText($@"MessageInspection\data\{fileName}");
        }

        [Fact]
        public void GetModifiedXmlSimpleTest()
        {
            var sut = new NamespaceModification();

            string data, expected, actual;
            data = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<sample xmlns=\"ns1\" />";
            expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<sample xmlns=\"ns2\" />"; ;
            actual = sut.GetModifiedXml(data, "ns1", "ns2");
            Assert.Equal(expected, actual);

            data = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns1\" />";
            expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns2\" />"; ;
            actual = sut.GetModifiedXml(data, "ns1", "ns2");
            Assert.Equal(expected, actual);

            data = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns1\">\r\n  <item xmlns=\"ns1\" />\r\n</n:sample>";
            expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns2\">\r\n  <item xmlns=\"ns2\" />\r\n</n:sample>";
            actual = sut.GetModifiedXml(data, "ns1", "ns2");
            Assert.Equal(expected, actual);

            data = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns1_rest\">\r\n  <item xmlns=\"ns1_rest2\" />\r\n</n:sample>";
            expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns2_rest\">\r\n  <item xmlns=\"ns2_rest2\" />\r\n</n:sample>";
            actual = sut.GetModifiedXml(data, "ns1", "ns2");
            Assert.Equal(expected, actual);

            // weired ... conform ? currently failed
            //
            //data = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns1_rest\">\r\n  <n:item xmlns=\"ns1_rest2\" attr1=\"a\" />\r\n</n:sample>";
            //expected = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<n:sample xmlns:n=\"ns2_rest\">\r\n  <n:item xmlns=\"ns2_rest2\" attr1=\"a\" />\r\n</n:sample>";
            //actual = sut.Modify(data, "ns1", "ns2");
            //Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetModifiedRealDataSamplesTest()
        {
            var data = ReadFile("namespace-modification-1.xml");
            var expected = ReadFile("namespace-modification-1-expected.xml");
            var sut = new NamespaceModification();
            var actual = sut.GetModifiedXml(data, "http://magento.developing.site/my-shop", "https://magento.production.site/shop");
            Assert.Equal(expected, actual);

            data = ReadFile("namespace-modification-2.xml");
            expected = ReadFile("namespace-modification-2-expected.xml");
            actual = sut.GetModifiedXml(data, "http://magento.developing.site/my-shop", "https://magento.production.site/shop");
            Assert.Equal(expected, actual);

            data = ReadFile("namespace-modification-3.xml");
            expected = ReadFile("namespace-modification-3-expected.xml");
            actual = sut.GetModifiedXml(data, "http://magento.developing.site/my-shop", "https://magento.production.site/shop");
            Assert.Equal(expected, actual);

            data = ReadFile("namespace-modification-4.xml");
            expected = ReadFile("namespace-modification-4-expected.xml");
            actual = sut.GetModifiedXml(data, "http://magento.developing.site/my-shop", "https://magento.production.site/shop");
            Assert.Equal(expected, actual);

            data = ReadFile("namespace-modification-4.xml");
            expected = ReadFile("namespace-modification-4-expected.xml");
            actual = sut.GetModifiedXml(data, "http://magento.developing.site/my-shop/soap/default?services=", "https://magento.production.site/shop/soap/default?services=");
            Assert.Equal(expected, actual);

            data = ReadFile("namespace-modification-4.xml");
            expected = ReadFile("namespace-modification-4-expected.xml");
            actual = sut.GetModifiedXml(data, "http://magento.developing.site/my-shop/soap/default?services=storeWebsiteRepositoryV1", "https://magento.production.site/shop/soap/default?services=storeWebsiteRepositoryV1");
            Assert.Equal(expected, actual);
        }
    }
}
