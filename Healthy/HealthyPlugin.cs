using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using Hearthstone_Deck_Tracker.Plugins;

namespace Healthy
{
    public class HealthyPlugin : IPlugin
    {
        public void OnLoad()
        {
            //when it's loaded upon each restart/turned on by the user
        }

        public void OnUnload()
        {
            // handle unloading here. HDT does not literally unload the assembly
        }

        public void OnButtonPress()
        {
            //when user presses the menu button
        }

        public void OnUpdate()
        {
            // called every ~100ms
        }

        public string Name => "Healthy";

        public string Description => "Displays total health of minion on mouseover.";

        public string ButtonText => "(There are no settings.)";

        public string Author => "Andrew Conant";

        public Version Version => new Version(0, 0, 1);

        public MenuItem MenuItem => null;
    }
}
