using MatchEntities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class MatchStats : IMatchDataEntity
    {
        public MatchStats()
        {
            BombDefused = new HashSet<BombDefused>();
            BombExplosion = new HashSet<BombExplosion>();
            BombPlant = new HashSet<BombPlant>();
            BotTakeOver = new HashSet<BotTakeOver>();
            ConnectDisconnect = new HashSet<ConnectDisconnect>();
            Damage = new HashSet<Damage>();
            Decoy = new HashSet<Decoy>();
            FireNade = new HashSet<FireNade>();
            Flash = new HashSet<Flash>();
            Flashed = new HashSet<Flashed>();
            He = new HashSet<He>();
            HostageDrop = new HashSet<HostageDrop>();
            HostagePickUp = new HashSet<HostagePickUp>();
            HostageRescue = new HashSet<HostageRescue>();
            ItemDropped = new HashSet<ItemDropped>();
            ItemPickedUp = new HashSet<ItemPickedUp>();
            ItemSaved = new HashSet<ItemSaved>();
            Kills = new HashSet<Kill>();
            PlayerMatchStats = new HashSet<PlayerMatchStats>();
            PlayerPosition = new HashSet<PlayerPosition>();
            PlayerRoundStats = new HashSet<PlayerRoundStats>();
            RoundItem = new HashSet<RoundItem>();
            RoundStats = new HashSet<RoundStats>();
            Smoke = new HashSet<Smoke>();
            WeaponFired = new HashSet<WeaponFired>();
            WeaponReload = new HashSet<WeaponReload>();
        }

        public long MatchId { get; set; }
        public DateTime MatchDate { get; set; } = new DateTime(2000);
        public string Map { get; set; }
        public byte WinnerTeam { get; set; }
        public short Score1 { get; set; }
        public short Score2 { get; set; }
        public short NumRoundsT1 { get; set; }
        public short NumRoundsCt1 { get; set; }
        public short NumRoundsT2 { get; set; }
        public short NumRoundsCt2 { get; set; }
        public short BombPlants1 { get; set; }
        public short BombPlants2 { get; set; }
        public short BombExplodes1 { get; set; }
        public short BombExplodes2 { get; set; }
        public short BombDefuses1 { get; set; }
        public short BombDefuses2 { get; set; }
        public int MoneyEarned1 { get; set; }
        public int MoneyEarned2 { get; set; }
        public int MoneySpent1 { get; set; }
        public int MoneySpent2 { get; set; }
        public int? AvgRoundTime { get; set; }
        public int RoundTimer { get; set; }
        public int BombTimer { get; set; }
        public int StartMoney { get; set; }
        public short DemoTickRate { get; set; }
        public short SourceTickRate { get; set; }
        public Source Source { get; set; }
        public GameType GameType { get; set; }
        public float? AvgRank { get; set; }
        public short RealScore1 { get; set; }
        public short RealScore2 { get; set; }
        public string Event { get; set; }

        [JsonIgnore]
        public OverTimeStats OverTimeStats { get; set; }
        [JsonIgnore]
        public ICollection<BombDefused> BombDefused { get; set; }
        [JsonIgnore]
        public ICollection<BombExplosion> BombExplosion { get; set; }
        [JsonIgnore]
        public ICollection<BombPlant> BombPlant { get; set; }
        [JsonIgnore]
        public ICollection<BotTakeOver> BotTakeOver { get; set; }
        [JsonIgnore]
        public ICollection<ConnectDisconnect> ConnectDisconnect { get; set; }
        [JsonIgnore]
        public ICollection<Damage> Damage { get; set; }
        [JsonIgnore]
        public ICollection<Decoy> Decoy { get; set; }
        [JsonIgnore]
        public ICollection<FireNade> FireNade { get; set; }
        [JsonIgnore]
        public ICollection<Flash> Flash { get; set; }
        [JsonIgnore]
        public ICollection<Flashed> Flashed { get; set; }
        [JsonIgnore]
        public ICollection<He> He { get; set; }
        [JsonIgnore]
        public ICollection<HostageDrop> HostageDrop { get; set; }
        [JsonIgnore]
        public ICollection<HostagePickUp> HostagePickUp { get; set; }
        [JsonIgnore]
        public ICollection<HostageRescue> HostageRescue { get; set; }
        [JsonIgnore]
        public ICollection<ItemDropped> ItemDropped { get; set; }
        [JsonIgnore]
        public ICollection<ItemPickedUp> ItemPickedUp { get; set; }
        [JsonIgnore]
        public ICollection<ItemSaved> ItemSaved { get; set; }
        [JsonIgnore]
        public ICollection<Kill> Kills { get; set; }
        [JsonIgnore]
        public ICollection<PlayerMatchStats> PlayerMatchStats { get; set; }
        [JsonIgnore]
        public ICollection<PlayerPosition> PlayerPosition { get; set; }
        [JsonIgnore]
        public ICollection<PlayerRoundStats> PlayerRoundStats { get; set; }
        [JsonIgnore]
        public ICollection<RoundItem> RoundItem { get; set; }
        [JsonIgnore]
        public ICollection<RoundStats> RoundStats { get; set; }
        [JsonIgnore]
        public ICollection<Smoke> Smoke { get; set; }
        [JsonIgnore]
        public ICollection<WeaponFired> WeaponFired { get; set; }
        [JsonIgnore]
        public ICollection<WeaponReload> WeaponReload { get; set; }
    }
}
