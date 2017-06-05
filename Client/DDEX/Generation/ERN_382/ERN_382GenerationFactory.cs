using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.DDEXFactory.Interfaces;

namespace DDEX.Generation.ERN_382
{
    public class ERN_382GenerationFactory : GenerationFactory
    {
        public override IXmlGenerationForm GetGenerationFormAudioSingle()
        {
            return new ERN_382GenerationFormAudioSingle(this);
        }

        public override IXmlGenerator GetGenerator()
        {
            return new ERN_382Generator(this);
        }
    }
}
