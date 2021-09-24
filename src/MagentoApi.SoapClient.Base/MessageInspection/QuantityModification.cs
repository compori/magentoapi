using System.Xml;

namespace Compori.MagentoApi.SoapClient.MessageInspection
{
    /// <summary>
    /// Class QuantityModification.
    /// </summary>
    public class QuantityModification
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
            if (!"catalogProductRepositoryV1SaveResponse".Equals(responseNode.LocalName))
            {
                return;
            }

            //
            // set empty to zero.
            //
            if (responseNode.SelectSingleNode("result/extensionAttributes/stockItem/qty") is XmlElement qtyElement 
                && string.IsNullOrWhiteSpace(qtyElement.InnerText))
            {
                qtyElement.InnerText = "0";
            }
        }
    }
}
