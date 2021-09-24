using System.Xml;

namespace Compori.MagentoApi.SoapClient.MessageInspection
{
    /// <summary>
    /// Class IsCustomerNotifiedModification.
    /// </summary>
    public class IsCustomerNotifiedModification  
    {
        /// <summary>
        /// Modifies the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        public void Modify(XmlDocument document)
        {
            //
            // Namespace xpath arg...
            //
            var responseNode = document?.DocumentElement?.FirstChild?.FirstChild;
            if (!"salesOrderRepositoryV1GetListResponse".Equals(responseNode.LocalName))
            {
                return;
            }

            //
            // set empty to zero.
            //
            var nodes = responseNode.SelectNodes("result/items/item/statusHistories/item/isCustomerNotified");
            foreach(var node in nodes)
            {
                if (node is XmlElement isCustomerNotifiedElement && string.IsNullOrWhiteSpace(isCustomerNotifiedElement.InnerText))
                {
                    isCustomerNotifiedElement.InnerText = "0";
                }
            }
        }
    }
}
