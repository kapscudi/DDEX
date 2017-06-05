using System.IO;
using System.Reflection;
using System.Xml;

namespace Business.DDEXFactory.Helpers
{
    public static class SerializationHelper
    {
        public static string Serialize(object value)
        {
            string ret = null;

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(value.GetType());
            using (var tw = new StringWriter())
            {
                x.Serialize(tw, value);
                ret = tw.ToString();
            }

            return ret;
        }

        public static object Deserialize(System.Type type, string value)
        {
            object ret = null;

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(type);
            
            using (var sr = new StringReader(value) )
            {
                using (var rdr = XmlReader.Create(sr))
                {
                    ret = x.Deserialize(rdr);
                }                    
            }

            return ret;
        }
    }
}
