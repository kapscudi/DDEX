using DDEX.Navigation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEX
{
    public static class Globals
    {
        public static NavigationModel Model { get; set; } = new NavigationModel();

        public static void LoadNavigation()
        {
            string navigation = System.IO.File.ReadAllText(Properties.Settings.Default.NavigationFileName);
            Model = JsonConvert.DeserializeObject<NavigationModel>(navigation);
        }

        public static void SaveNavigation()
        {
            string navigation = JsonConvert.SerializeObject(Model);
            System.IO.File.WriteAllText(Properties.Settings.Default.NavigationFileName, navigation);
        }
    }
}
