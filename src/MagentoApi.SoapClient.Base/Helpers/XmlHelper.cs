using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Compori.MagentoApi.SoapClient.Helpers
{
    public class XmlHelper
    {
        /// <summary>
        /// Finds the first element with the with local name.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="localName">Name of the local.</param>
        /// <returns>XmlElement.</returns>
        public static XmlElement FindFirstWithLocalName(XmlElement element, string localName)
        {
            // Match!
            if(element.LocalName.Equals(localName))
            {
                return element;
            }

            // Search in child nodes
            foreach(XmlNode child in element.ChildNodes)
            {
                if(child.NodeType != XmlNodeType.Element)
                {
                    continue;
                }
                
                var result = FindFirstWithLocalName(child as XmlElement, localName);                
                if(result != null)
                {
                    return result;
                }
            }

            return null;
        }

        /// <summary>
        /// Renames the name of the local.
        /// </summary>
        /// <param name="element">The element.</param>
        /// <param name="localName">Name of the local.</param>
        /// <returns>XmlElement.</returns>
        public static XmlElement RenameLocalName(XmlElement element, string localName)
        {
            // Create a replacement
            var doc = element.OwnerDocument;
            var replacement = doc.CreateElement(localName);

            // Copy all child node in copy as deep clone
            int count = element.ChildNodes.Count;
            for (int i = 0; i < count; i++)
            {
                replacement.AppendChild(element.ChildNodes[i].CloneNode(true));                
            }
            
            // replace original with new item
            element.ParentNode.ReplaceChild(replacement, element);
            
            return replacement;
        } 
    }
}
