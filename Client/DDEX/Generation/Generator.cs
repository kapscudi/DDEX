using System;
using Business.DDEXFactory.Interfaces;

namespace DDEX.Generation
{
    public abstract class Generator: IXmlGenerator
    {
        public string SerializeNewReleaseMessage(IXmlObject value)
        {
            string xml = Business.DDEXFactory.Helpers.SerializationHelper.Serialize(value);
            //System.IO.File.WriteAllText(fileName, xml);
            return xml;
        }

        public abstract bool IsValid(string value, out string outMessage);

        public abstract IXmlObject DeserializeNewReleaseMessage(string value);

        protected IXmlGenerationFactory _Factory = null;
        public IXmlGenerationFactory Factory
        {
            get
            {
                return _Factory;
            }
        }

    }
}
