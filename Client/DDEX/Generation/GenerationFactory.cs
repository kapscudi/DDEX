using Business.DDEXFactory.Interfaces;
namespace DDEX.Generation
{
    public abstract class GenerationFactory: IXmlGenerationFactory
    {
        public abstract IXmlGenerator GetGenerator();
        public abstract IXmlGenerationForm GetGenerationFormAudioSingle();
        
    }
}
