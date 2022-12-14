namespace NWAPI_AmmoNum
{
    using InventorySystem.Configs;
    using MEC;
    using PlayerRoles;
    using PluginAPI.Core;
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using PluginAPI.Events;
    using System.Collections.Generic;

    public class Plugin
    {
        [PluginEntryPoint("AmmoChange", "0.0.1", "修改玩家的默认备弹数量.A Plugin To Change the default ammo of Players", "1312255201")]
        void Enabled()
        {
            EventManager.RegisterEvents(this);
        }

        [PluginEvent(ServerEventType.PlayerSpawn)]
        void OnPlayerSpawn(Player player,RoleTypeId roleTypeId)
        {
            Timing.CallDelayed(0.3f, () =>
            {
                if(roleTypeId.GetTeam() != Team.SCPs)
                {
                    switch(roleTypeId)
                    { 
                        case RoleTypeId.ClassD:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfClassD[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfClassD[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfClassD[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfClassD[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfClassD[4]);
                            break;
                        case RoleTypeId.Scientist:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfScientist[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfScientist[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfScientist[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfScientist[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfScientist[4]);
                            break;
                        case RoleTypeId.FacilityGuard:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfFacilityGuard[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfFacilityGuard[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfFacilityGuard[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfFacilityGuard[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfFacilityGuard[4]);
                            break;
                        case RoleTypeId.NtfCaptain:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfNtfCaptain[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfNtfCaptain[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfNtfCaptain[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfNtfCaptain[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfNtfCaptain[4]);
                            break;
                        case RoleTypeId.NtfPrivate:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfNtfPrivate[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfNtfPrivate[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfNtfPrivate[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfNtfPrivate[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfNtfPrivate[4]);
                            break;
                        case RoleTypeId.NtfSergeant:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfNtfSergeant[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfNtfSergeant[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfNtfSergeant[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfNtfSergeant[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfNtfSergeant[4]);
                            break;
                        case RoleTypeId.NtfSpecialist:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfNtfSpecialist[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfNtfSpecialist[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfNtfSpecialist[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfNtfSpecialist[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfNtfSpecialist[4]);
                            break;
                        case RoleTypeId.ChaosRifleman:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfChaosRifleman[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfChaosRifleman[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfChaosRifleman[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfChaosRifleman[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfChaosRifleman[4]);
                            break;
                        case RoleTypeId.ChaosRepressor:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfChaosRepressor[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfChaosRepressor[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfChaosRepressor[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfChaosRepressor[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfChaosRepressor[4]);
                            break;
                        case RoleTypeId.ChaosMarauder:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfChaosMarauder[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfChaosMarauder[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfChaosMarauder[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfChaosMarauder[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfChaosMarauder[4]);
                            break;
                        case RoleTypeId.ChaosConscript:
                            player.SetAmmo(ItemType.Ammo12gauge, Config.AmmoOfChaosConscript[0]);
                            player.SetAmmo(ItemType.Ammo9x19, Config.AmmoOfChaosConscript[1]);
                            player.SetAmmo(ItemType.Ammo44cal, Config.AmmoOfChaosConscript[2]);
                            player.SetAmmo(ItemType.Ammo762x39, Config.AmmoOfChaosConscript[3]);
                            player.SetAmmo(ItemType.Ammo556x45, Config.AmmoOfChaosConscript[4]);
                            break;
                    }
                }
            });
        }
        [PluginConfig]
        public Config Config;


    }
}