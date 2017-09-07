using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Enums;
using Card = Hearthstone_Deck_Tracker.Hearthstone.Card;

namespace Healthy
{
    internal class HealthyWatcher
    {
        public HealthyWatcher()
        {
            GameEvents.OnPlayerMinionMouseOver.Add(handleMouseOver);
        }

        public void handleMouseOver(Card card)
        {
        }
    }
}
