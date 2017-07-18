using Business.DDEXSchemaERN_382.BindingObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEX.Navigation
{
    public class NavigationModel
    {
        public SortableBindingList<EditXmlFileModel> Files { get; set; } = new SortableBindingList<EditXmlFileModel>();
    }
}
