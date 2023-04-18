using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Enums;
using PlayerRoles;
namespace DanasNET_Subclasses
{
    public class Subclass
    {
        public string Name { get; set; }
        public List<ItemType> StartingInventory { get; set; }
        public Dictionary<AmmoType, ushort> Ammo { get; set; } = null;
        public RoleTypeId MainRole { get; set; }
        public int Chance { get; set; }
        public int MaxPlayerCount { get; set; }

        public bool SetSubclass(ref Exiled.API.Features.Player player)
        {
            if (MaxPlayerCount <= 0) return false;
            if (player.Role.Type != MainRole)
            {
                player.Role.Set(MainRole, SpawnReason.ForceClass, RoleSpawnFlags.UseSpawnpoint);
            }

            player.ResetInventory(StartingInventory);

            if (Ammo != null)
            {
                foreach (var item in Ammo)
                {
                    player.AddAmmo(item.Key, item.Value);
                }
            }
            if (MaxPlayerCount > 0)
            {
                MaxPlayerCount--;
                return true;
            }
            return false;
        }
    }
}
