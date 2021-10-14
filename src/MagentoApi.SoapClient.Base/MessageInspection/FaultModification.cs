using Compori.MagentoApi.SoapClient.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace Compori.MagentoApi.SoapClient.MessageInspection
{
    public class FaultModification
    {

        #region "Fix GenericFaultParameter Elements"

        /// <summary>
        /// Fixes the generic fault parameter elements.
        /// </summary>
        /// <param name="document">The document.</param>
        public static void FixGenericFaultParameterElements(XmlDocument document)
        {
            //
            // Replace <Parameters><GenericFaultParameter>...</GenericFaultParameter><GenericFaultParameter>...</GenericFaultParameter>...</Parameters>
            // with <Parameters><item>...</item><item>...</item>...</Parameters>
            //
            var element = XmlHelper.FindFirstWithLocalName(document.DocumentElement, "Parameters");
            if(element == null)
            {
                return;
            }

            var count = element.ChildNodes.Count;
            for (int i = 0; i < count; i++)
            {
                if (!(element.ChildNodes[i] is XmlElement child) || child.NodeType != XmlNodeType.Element || !child.LocalName.Equals("GenericFaultParameter"))
                {
                    continue;
                }
                XmlHelper.RenameLocalName(child, "item");
            }
        }

        #endregion

        public static IDictionary<string, string> GetNamespacesInScope(XmlNode xmlNode)
        {
             IDictionary<string, string> result = new Dictionary<string,string>();
             IDictionary<string, string> localNamespaces;
              
             XmlNode currentXmlNode = xmlNode;
             XPathNavigator navigator;
             while (currentXmlNode.ParentNode!=null)
             {
                 navigator = currentXmlNode.CreateNavigator();
                 localNamespaces = navigator.GetNamespacesInScope(XmlNamespaceScope.Local);
                 foreach (var item in localNamespaces)
                 {
                     if (!result.ContainsKey(item.Key))
                     {
                         result.Add(item);
                     }
                 }
                 currentXmlNode = currentXmlNode.ParentNode;
             }
             return result;
        }

        private XmlElement FindFirst(XmlElement element, string prefix)
        {
            if(element.Prefix.Equals(prefix))
            {
                return element;
            }

            foreach(XmlNode child in element.ChildNodes)
            {
                if(child.NodeType != XmlNodeType.Element)
                {
                    continue;
                }
                
                var result = FindFirst(child as XmlElement, prefix);
                
                if(result != null)
                {
                    return result;
                }
            }

            return null;
        }



        public void Replace(XmlElement element, string prefix)
        {
            var doc = element.OwnerDocument;
            if(element.Prefix.Equals(prefix))
            {
                var replacement = doc.CreateElement(element.LocalName);
                int count = element.ChildNodes.Count;
                for (int i = 0; i < count; i++)
                {
                    replacement.AppendChild(element.ChildNodes[i].CloneNode(true));
                }
                element.ParentNode.ReplaceChild(replacement, element);
                element = replacement;
            }

            for (int i = 0; i < element.ChildNodes.Count; i++)
            {
                if (!(element.ChildNodes[i] is XmlElement child) || child.NodeType != XmlNodeType.Element)
                {
                    continue;
                }

                Replace(child, prefix);
            }
        }



        /// <summary>
        /// Modifies the specified document.
        /// </summary>
        /// <param name="document">The document.</param>
        public void Modify(XmlDocument document, string baseNamespace)
        {
            var namespaces = GetNamespacesInScope(document.DocumentElement);
            string prefix = null;
            foreach( var kv in namespaces ) 
            {
                if(kv.Value.StartsWith(baseNamespace))
                {
                    prefix = kv.Key;
                    break;
                }
            }

            if(prefix == null)
            {
                return;
            }

            var element = this.FindFirst(document.DocumentElement, prefix);
            int count = element.ChildNodes.Count;
            
            for (int i = 0; i < count; i++)
            {
                if (!(element.ChildNodes[i] is XmlElement child) || child.NodeType != XmlNodeType.Element)
                {
                    continue;
                }
                Replace(child, prefix);
            }

            FixGenericFaultParameterElements(document);
        }

        

        
        /// <summary>
        /// Gets the modified XML in encoding.
        /// </summary>
        /// <param name="xml">The message.</param>
        /// <param name="baseNamespace">The base namespace.</param>
        /// <returns>System.String.</returns>
        public string Modify(string xml, string baseNamespace)
        {
            XmlDocument doc = new XmlDocument
            {
                PreserveWhitespace = true
            };
            doc.LoadXml(xml);
            this.Modify(doc, baseNamespace);

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
