using nManager;
using static nManager.Wow.ObjectManager.ObjectManager;
using nManager.Wow.Helpers;

// ReSharper disable once CheckNamespace
public class Info
{
    public uint Level = Me.Level;
    // public string Name = Me.Name;
    public string Class = Me.WowClass.ToString();
    public string Spec = Me.WowSpecialization().ToString();
    public string PlayerFaction = Me.PlayerFaction;
    public string PlayerRace = Me.PlayerRace;
    public string Gender = Me.WowGender.ToString();
    public string Position = Me.Position.ToString(); // example: "2258.836 ; 6809.693 ; 122.5866 ; None"
    public int Durability = Me.GetDurability;
    public int Health = Me.Health;
    public float HealthPercent = Me.HealthPercent;
    public int MaxHealth = Me.MaxHealth;
    public uint Mana = Me.Mana;
    public uint ManaPercent = Me.ManaPercentage;
    public uint MaxMana = Me.MaxMana;
    public int Experience = Me.Experience;
    public int ExperienceMax = Me.ExperienceMax;

    public bool IsCasting = Me.IsCasting;
    public bool InCombat = Me.InCombat;
    public static bool IsDead = Me.IsDead;
    public bool IsMounted = Me.IsMounted;
    public bool OnTaxi = Me.OnTaxi;
    public bool InGame = Usefuls.InGame;
    public bool IsFalling = Usefuls.IsFalling;
    public bool IsFlyableArea = Usefuls.IsFlyableArea;
    public bool IsFlying = Usefuls.IsFlying;
    public bool IsInBattleground = Usefuls.IsInBattleground;
    public bool IsInDungeon = Usefuls.IsInDungeon;
    public bool IsInPetBattle = Usefuls.IsInPetBattle;
    public bool IsInRaid = Usefuls.IsInRaid;
    public bool IsLoading = Usefuls.IsLoading;
    public bool IsOutdoors = Usefuls.IsOutdoors;
    public bool IsSwimming = Usefuls.IsSwimming;

    public uint Deaths = Statistics.Deaths;
    public uint Farms = Statistics.Farms;
    public uint Kills = Statistics.Kills;
    public uint Loots = Statistics.Loots;
    public uint Stucks = Statistics.Stucks;
    
    public int DeathsByHr = Statistics.DeathsByHr();
    public int ExperienceByHr = Statistics.ExperienceByHr();
    public int FarmsByHr = Statistics.FarmsByHr();
    public int HonorByHr = Statistics.HonorByHr();
    public int KillsByHr = Statistics.KillsByHr();
    public int LootsByHr = Statistics.LootsByHr();
    public int RunningTimeInSec = Statistics.RunningTimeInSec();

    public int HonorPoints = Usefuls.GetHonorPoint;
    public int WoWTime = Usefuls.GetWoWTime;
    public int Latency = Usefuls.Latency;
    public int FreeBagSlots = Usefuls.GetContainerNumFreeSlots;
    public string MapName = Usefuls.MapName;  // "Troll Raid" always => bugged? or shows properly but only while in dung/raid?
    public string ZoneName = Usefuls.MapZoneName; // example: "val sharah"
    public string SubZoneName = Usefuls.SubMapZoneName; // example: "Field of Dreamers"
    // public string RealmName = Usefuls.RealmName;
}
