using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace DanasNET_Subclasses
{
    public class EventHandlers
    {

        public Dictionary<PlayerRoles.RoleTypeId, List<Subclass>> roles;

        private Subclasses _plugin;
        public EventHandlers(Subclasses plugin)
        {
            _plugin = plugin;
        }

        private Dictionary<PlayerRoles.RoleTypeId, List<Subclass>> LoadConfig()
        {
            Dictionary<PlayerRoles.RoleTypeId, List<Subclass>> roles = null;
            roles = new Dictionary<PlayerRoles.RoleTypeId, List<Subclass>>(_plugin.Config.Subclasses);
            return roles;
        }

        public void OnRoundStarted()
        {
            roles = new Dictionary<PlayerRoles.RoleTypeId, List<Subclass>>(_plugin.Config.Subclasses);
            foreach (var role in roles)
            {
                List<Player> players = Player.List.Where(player => player.Role.Type == role.Key).ToList();
                if (players.Count > 0)
                {
                    foreach (Subclass subclass in role.Value)
                    {
                        int count = subclass.MaxPlayerCount;
                        while (players.Count > 0 && count > 0)
                        {
                            if (_plugin.rng.Next(100) <= subclass.Chance)
                            {
                                Player player = players[_plugin.rng.Next(players.Count)];
                                subclass.SetSubclass(ref player);
                                players.Remove(player);
                            }
                            count--;
                        }
                    }
                }
            }
        }
    }
}
