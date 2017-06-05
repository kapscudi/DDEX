using System;
using Business.DDEXFactory.Interfaces;
using Business.DDEXFactory.Helpers;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace DDEX.Generation.ERN_382
{
    public class ERN_382Generator : Generator
    {
        public ERN_382Generator(IXmlGenerationFactory factory)
        {
            _Factory = factory;
        }

        public override IXmlObject DeserializeNewReleaseMessage(string value)
        {
            IXmlObject ret = null;
            ret = (IXmlObject)Business.DDEXFactory.Helpers.SerializationHelper.Deserialize(typeof(Business.DDEXFactory.Schemas.ERN_382.NewReleaseMessage), value);

            return ret;
        }

        public override bool IsValid(string fileName, out string outMessage)
        {
            bool ret = true;

            string value = System.IO.File.ReadAllText(fileName);

            XmlSchemaSet schemas = new XmlSchemaSet();

            string xsdEmbeddedResourceName = null;
            string xsdMarkup = null;

            xsdEmbeddedResourceName = "Business.DDEXFactory.Schemas.ERN_382.xsd.release-notification.xsd";
            xsdMarkup = ReflectionHelper.ReadEmbeddedResource(ReflectionHelper.CurrentAssembly, xsdEmbeddedResourceName);
            schemas.Add("http://ddex.net/xml/ern/382", XmlReader.Create(new StringReader(xsdMarkup)));

            xsdEmbeddedResourceName = "Business.DDEXFactory.Schemas.ERN_382.xsd.avs.xsd";
            xsdMarkup = ReflectionHelper.ReadEmbeddedResource(ReflectionHelper.CurrentAssembly, xsdEmbeddedResourceName);
            schemas.Add("http://ddex.net/xml/avs/avs", XmlReader.Create(new StringReader(xsdMarkup)));

            outMessage = "";

            var rdr = new StringReader(value);

            XDocument doc = XDocument.Load(rdr, LoadOptions.None);
            string msg = "";
            doc.Validate(schemas, (o, e) => {
                msg += e.Message + Environment.NewLine;
            });

            ret = (msg == "" ? true : false);

            outMessage = msg;

            return ret;
        }
    }
}
