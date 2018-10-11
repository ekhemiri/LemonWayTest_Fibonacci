using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace FibonacciTest.Controllers
{
    public class XmlToJsonHelper
    {
        /// <summary>
        /// Conversion XML vers JSON.
        /// </summary>
        /// <param name="n">La châine XML.</param>
        /// <returns>La châine JSON</returns>
        public string XmlToJson(string xml)
        {
            try
            {
                XmlDocument documentXml = new XmlDocument();
                documentXml.LoadXml(xml);
                return JsonConvert.SerializeXmlNode(documentXml);
            }
            catch (XmlException e)
            {
                throw e;
            }
        }
    }
}