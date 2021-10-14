using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Xml;

namespace Compori.MagentoApi.SoapClient.MessageInspection
{
    /// <summary>
    /// NamespaceModification Class
    ///
    /// <para>
    /// Each Magento Installation have its own namespace in its API calls. Even though the API or version may be the same.
    /// That leads to validation error if you try to call another Magento installation then the one used for integration.
    /// </para>
    ///
    /// <para>
    /// The solution is to replace the namespace in SOAP messages regarding the used Magento location e.g. every namespace defintion
    /// like xmlns="http://magento.developing.site/my-shop/soap/default?services=storeWebsiteRepositoryV1" has to become
    /// xmlns="https://magento.production.site/shop/soap/default?services=storeWebsiteRepositoryV1" on installation site
    /// https://magento.production.site/shop
    /// </para>
    ///
    /// <para>
    /// Unfortunatly a full xml processing is necessary because the namespace definition in request and response message can
    /// vary a lot. A simple find an replace would not cover all and leads into message mess.
    /// </para>
    /// </summary>
    public class NamespaceModification
    {
        /*

            The fast and easy way... But wont work in 100%

        /// <summary>
        /// Replaces the base namespace.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>System.String.</returns>
        public static string ReplaceBaseNamespace(string value, string current, string replace)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }
            string pattern = "((xmlns:[^=]*)|xmlns)[^=]*=[^\"]*\"" + Regex.Escape(current);

            var result = Regex.Replace(value, pattern, "$1=\"" + replace);
            return result;
        }

        */

        /// <summary>
        /// Replaces the base namespace URI.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="element">The element.</param>
        /// <param name="originalBaseNamespace">The original base namespace.</param>
        /// <param name="baseNamespace">The base namespace.</param>
        public void ReplaceBaseNamespace(XmlDocument doc, XmlElement element, string originalBaseNamespace, string baseNamespace)
        {
            this.ReplaceBaseNamespace(doc, element, originalBaseNamespace, baseNamespace, new Dictionary<string, string>());
        }

        /// <summary>
        /// Replaces the base namespace URI.
        /// </summary>
        /// <param name="doc">The xml document.</param>
        /// <param name="element">The current xml element.</param>
        /// <param name="originalBaseNamespace">The original base namespace.</param>
        /// <param name="baseNamespace">The base namespace.</param>
        /// <param name="namespaceReplacementMap">The namespace replacement map.</param>
        public void ReplaceBaseNamespace(XmlDocument doc, XmlElement element, string originalBaseNamespace, string baseNamespace, IDictionary<string, string> namespaceReplacementMap)
        {
            //
            // Search for namespace prefix and adjust them if necessary
            //
            foreach (XmlAttribute attribute in element.Attributes)
            {
                var attributeNamespace = WebUtility.UrlDecode(attribute.Value);
                if (attribute.Name.StartsWith("xmlns:") && (attributeNamespace.StartsWith(originalBaseNamespace)))
                {
                    // var xmlnsNamespaceUsedWithPrefix = attribute.Value;
                    var xmlnsNamespaceUsedWithPrefix = attributeNamespace;
                    var length = originalBaseNamespace.Length;

                    var namespaceURI = baseNamespace + xmlnsNamespaceUsedWithPrefix.Substring(length, xmlnsNamespaceUsedWithPrefix.Length - length);
                    if (namespaceURI.EndsWith("&wsdl=1")) {
                        namespaceURI = namespaceURI.Substring(0, namespaceURI.Length - 7);
                    }
                    attribute.Value = namespaceURI;

                    if (!namespaceReplacementMap.ContainsKey(attribute.LocalName))
                    {
                        namespaceReplacementMap.Add(attribute.LocalName, namespaceURI);
                    }
                }
            }

            //
            // Step recursive through the xml node tree
            //
            if (element.HasChildNodes)
            {
                int count = element.ChildNodes.Count;

                for (int i = 0; i < count; i++)
                {
                    // skip non element nodes
                    var node = element.ChildNodes[i];
                    if (node.NodeType != XmlNodeType.Element)
                    {
                        continue;
                    }

                    // recursive call if child xmlelement is casted
                    if (node is XmlElement child)
                    {
                        this.ReplaceBaseNamespace(doc, child, originalBaseNamespace, baseNamespace, namespaceReplacementMap);
                    }
                }
            }

            //
            // Move Element with default namepace from e.g.
            // xmlns="<originalBaseNamespace>rest"
            // to
            // xmlns="<baseNamespace>rest"
            //
            var xmlnsNamespace = element.GetNamespaceOfPrefix(string.Empty);
            if (string.IsNullOrEmpty(element.Prefix) && xmlnsNamespace.StartsWith(originalBaseNamespace))
            {
                var length = originalBaseNamespace.Length;
                var modifiedXmlnsURI = baseNamespace + xmlnsNamespace.Substring(length, xmlnsNamespace.Length - length);

                MoveElementToNamespace(doc, element, modifiedXmlnsURI);
                return;
            }

            //
            // Move prefixed namepace element e.g. n:element
            //
            if (!string.IsNullOrEmpty(element.Prefix) && namespaceReplacementMap.ContainsKey(element.Prefix))
            {
                MoveElementToNamespace(doc, element, namespaceReplacementMap[element.Prefix]);
                return;
            }
        }

        /// <summary>
        /// Moves an xml element to a different namespace.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <param name="element">The element.</param>
        /// <param name="namespaceURI">The namespace URI.</param>
        public static void MoveElementToNamespace(XmlDocument doc, XmlElement element, string namespaceURI)
        {
            var replacement = doc.CreateElement(element.Prefix, element.LocalName, namespaceURI);

            int count = element.ChildNodes.Count;
            for (int i = 0; i < count; i++)
            {
                replacement.AppendChild(element.ChildNodes[i].CloneNode(true));
            }

            element.ParentNode.ReplaceChild(replacement, element);
        }

        /// <summary>
        /// Modifies the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        /// <param name="originalBaseNamespace">The original base namespace.</param>
        /// <param name="baseNamespace">The base namespace.</param>
        public void Modify(XmlDocument document, string originalBaseNamespace, string baseNamespace)
        {
            this.ReplaceBaseNamespace(document, document.DocumentElement, originalBaseNamespace, baseNamespace);
        }

        /// <summary>
        /// Gets the modified XML in encoding
        /// </summary>
        /// <param name="xml">The message.</param>
        /// <param name="originalBaseNamespace">The original base namespace.</param>
        /// <param name="baseNamespace">The base namespace.</param>
        /// <returns>System.String.</returns>
        public string GetModifiedXml(string xml, string originalBaseNamespace, string baseNamespace)
        {
            XmlDocument doc = new XmlDocument
            {
                PreserveWhitespace = true
            };
            doc.LoadXml(xml);
            this.Modify(doc, originalBaseNamespace, baseNamespace);

            XmlWriterSettings settings = new XmlWriterSettings
            {
                Encoding = Encoding.UTF8,
                Indent = true,
            };

            var sb = new StringBuilder();
            using (var xmlWriter = XmlWriter.Create(sb, settings))
            {

                doc.WriteTo(xmlWriter);
                xmlWriter.Flush();
            }

            return sb.ToString();
        }
    }
}
