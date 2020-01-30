using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class RoundStats : IMatchDataEntity
    {
        public RoundStats()
        {
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
            PlayerPosition = new HashSet<PlayerPosition>();
            PlayerRoundStats = new HashSet<PlayerRoundStats>();
            RoundItem = new HashSet<RoundItem>();
            Smoke = new HashSet<Smoke>();
            WeaponFired = new HashSet<WeaponFired>();
            WeaponReload = new HashSet<WeaponReload>();
        }

        public long MatchId { get; set; }
        public short Round { get; set; }
        public byte WinnerTeam { get; set; }
        public bool OriginalSide { get; set; }
        public bool BombPlanted { get; set; }
        public byte? WinType { get; set; }
        public int RoundTime { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public int RealEndTime { get; set; }
        public int StartTick { get; set; }
        public int EndTick { get; set; }
        public int RealEndTick { get; set; }
        public int TerrorStrategyId { get; set; }
        public int CtStrategyId { get; set; }
        public int CtPlayedValue { get; set; }
        public int TPlayedValue { get; set; }
        public int CtBuyStrat { get; set; }
        public int TBuyStrat { get; set; }

        [JsonIgnore]
        public MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public BombDefused BombDefused { get; set; }
        [JsonIgnore]
        public BombExplosion BombExplosion { get; set; }
        [JsonIgnore]
        public BombPlant BombPlant { get; set; }
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
        public ICollection<PlayerPosition> PlayerPosition { get; set; }
        [JsonIgnore]
        public ICollection<PlayerRoundStats> PlayerRoundStats { get; set; }
        [JsonIgnore]
        public ICollection<RoundItem> RoundItem { get; set; }
        [JsonIgnore]
        public ICollection<Smoke> Smoke { get; set; }
        [JsonIgnore]
        public ICollection<WeaponFired> WeaponFired { get; set; }
        [JsonIgnore]
        public ICollection<WeaponReload> WeaponReload { get; set; }
    }
}
