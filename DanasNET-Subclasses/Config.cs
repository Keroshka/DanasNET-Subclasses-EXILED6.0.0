using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerRoles;
using Exiled.API.Enums;

namespace DanasNET_Subclasses
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public Dictionary<RoleTypeId, List<Subclass>> Subclasses { get; set; } = new Dictionary<RoleTypeId, List<Subclass>>
        {
            {
                RoleTypeId.ClassD,
                new List<Subclass>
                {
                    {
                new Subclass
                {
                    Name = "Smuggler",
                    StartingInventory = new List<ItemType>
                    {
                        ItemType.Coin
                    },
                    Chance = 15,
                    MaxPlayerCount = 2,
                    MainRole = RoleTypeId.ClassD
                }
            },
            {
                new Subclass
                {
                    Name = "Flashlight Guy",
                    StartingInventory = new List<ItemType>
                    {
                        ItemType.Flashlight
                    },
                    Chance = 15,
                    MaxPlayerCount = 2,
                    MainRole = RoleTypeId.ClassD
                }
            },
            {
                new Subclass
                {
                    Name = "Janitor",
                    StartingInventory = new List<ItemType>
                    {
                        ItemType.KeycardJanitor
                    },
                    Chance = 10,
                    MaxPlayerCount = 1,
                    MainRole = RoleTypeId.ClassD
                }
            },
                    {
                        new Subclass
                        {
                            Name = "Infiltrator",
                            StartingInventory = new List<ItemType>
                            {
                                ItemType.GunAK,
                                ItemType.KeycardChaosInsurgency,
                                ItemType.Medkit,
                                ItemType.ArmorCombat
                            },
                            Ammo = new Dictionary<AmmoType, ushort>
                            {
                                {
                                    AmmoType.Nato762,
                                    30
                                }
                            },
                            Chance = 10,
                            MaxPlayerCount = 1,
                            MainRole = RoleTypeId.ChaosConscript
                        }
                    }
                }
            },
            {
                RoleTypeId.Scientist,
                new List<Subclass>
                {
                    new Subclass
                    {
                        Name = "Zone Manager",
                        StartingInventory = new List<ItemType>
                        {
                            ItemType.KeycardZoneManager,
                            ItemType.Flashlight
                        },
                        Chance = 30,
                        MaxPlayerCount = 1,
                        MainRole = RoleTypeId.Scientist
                    }
                }
            },
            {
                RoleTypeId.FacilityGuard,
                new List<Subclass>
                {
                    new Subclass
                    {
                        Name = "Security Head",
                        StartingInventory = new List<ItemType>
                        {
                            ItemType.Jailbird,
                            ItemType.ArmorLight,
                            ItemType.Radio,
                            ItemType.KeycardGuard,
                            ItemType.Medkit
                        },
                        Chance = 100,
                        MaxPlayerCount = 1,
                        MainRole = RoleTypeId.FacilityGuard
                    }
                }
            }
        };
    }
}
