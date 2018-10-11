using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FibonacciTest.Controllers
{
    /// <summary>
    /// Classe de routage XmlToJson.
    /// </summary>
    public class XmlToJsonController : ApiController
    {
        // Get api/xmltojson/id
        public string GetXmlToJson(string id)
        {
            XmlToJsonHelper xmlToJson = new XmlToJsonHelper();
            return xmlToJson.XmlToJson(id);
        }
    }
}
