using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DDEXFactory.Interfaces
{
    public interface IXmlGenerator
    {
        string SerializeNewReleaseMessage(IXmlObject value);
        IXmlObject DeserializeNewReleaseMessage(string value);
        bool IsValid(string fileName, out string outMessage);
        IXmlGenerationFactory Factory { get; }
    }
}
