namespace NWAPI_AmmoNum
{
    using PlayerRoles;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Config
    {
        [Description("Set AmmonumOf ClassD Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfClassD { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };
        [Description("Set AmmonumOf Scientist Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfScientist { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };
        [Description("Set AmmonumOf FacilityGuard Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfFacilityGuard { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };
        [Description("Set AmmonumOf NtfCaptain Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfNtfCaptain { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 }; 
        [Description("Set AmmonumOf NtfPrivate Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfNtfPrivate { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };
        [Description("Set AmmonumOf NtfSergeant Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfNtfSergeant { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };
        [Description("Set AmmonumOf NtfSpecialist Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfNtfSpecialist { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };

        [Description("Set AmmonumOf ChaosConscript Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfChaosConscript { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };
        [Description("Set AmmonumOf ChaosMarauder Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfChaosMarauder { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };
        [Description("Set AmmonumOf ChaosRepressor Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfChaosRepressor { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };
        [Description("Set AmmonumOf ChaosRifleman Ammo12gauge Ammo9x19 Ammo44cal Ammo762x39 Ammo556x45")]
        public List<ushort> AmmoOfChaosRifleman { get; set; } = new List<ushort> { 100, 100, 100, 100, 100 };
    }
}


