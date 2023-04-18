using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace DanasNET_Subclasses
{
    internal class EventHandlers
    {

        private readonly Subclasses _plugin;
        private Random rng;
        public EventHandlers(Subclasses plugin)
        {
            _plugin = plugin;
            rng = new Random();
        }

        public void OnRoundStarted()
        {
            foreach (var role in _plugin.Config.Subclasses)
            {

            }
        }
    }
}
