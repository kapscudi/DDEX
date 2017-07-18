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
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Extension { get; set; }
        public string DirectoryName { get; set; }
        public DateTime LastWriteTime { get; set; }

    }
}
