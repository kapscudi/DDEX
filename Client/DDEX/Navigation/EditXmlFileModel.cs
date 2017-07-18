using Business.DDEXFactory.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEX.Navigation
{
    public class EditXmlFileModel: BindableModel
    {
        public string FileName { get; set; }
        public bool IsValidXml { get; set; }
    }
}
