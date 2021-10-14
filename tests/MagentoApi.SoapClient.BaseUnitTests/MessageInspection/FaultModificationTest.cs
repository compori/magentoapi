using Compori.MagentoApi.SoapClient.MessageInspection;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace MagentoApi.SoapClient.BaseUnitTests.MessageInspection
{
    public class FaultModificationTest
    {
        public static IEnumerable<object[]> GetExternalXmlData()
        {
            yield return new object[] {
                "fault-modification-1-expected.xml", 
                "fault-modification-1.xml", 
                "http://magento.developing.site/my-shop"
            };            
        }

        private static string ReadFile(string fileName)
        {
            return File.ReadAllText($@"MessageInspection\data\{fileName}");
        }

        [Theory]
        [MemberData(nameof(GetExternalXmlData))]
        public void TestGetModifiedXmlFromExternal(string expectedSource, string actualSource, string namespaceName)
        {
            var data = ReadFile(actualSource);
            var expected = ReadFile(expectedSource);
            var sut = new FaultModification();
            var actual = sut.Modify(data, namespaceName);
            Assert.Equal(expected, actual);
        }
    }
}
