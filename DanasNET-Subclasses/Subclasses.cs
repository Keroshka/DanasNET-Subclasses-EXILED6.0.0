using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanasNET_Subclasses
{
    public class Subclasses : Plugin<Config>
    {

        public override string Author => "Keroshka";
        public override string Name => "DanasNET-Subclasses";
        public override Version RequiredExiledVersion => new Version(6, 0, 0);
        public EventHandlers EventHandler { get; set; }
        public static Subclasses Instance;
        public Random rng = new Random();
        public override void OnEnabled()
        {
            Instance = this;
            EventHandler = new EventHandlers(Instance);
            Exiled.Events.Handlers.Server.RoundStarted += EventHandler.OnRoundStarted;

            base.OnEnabled();
        }

        public override void OnReloaded()
        {
            if (EventHandler.roles != null) EventHandler.roles = null;

            base.OnReloaded();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandler.OnRoundStarted;

            EventHandler = null;

            base.OnDisabled();
        }
    }
}
