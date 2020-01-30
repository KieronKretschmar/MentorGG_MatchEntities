using MatchEntities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class PlayerRoundStats : IMatchDataEntity
    {
        public PlayerRoundStats()
        {
            BombDefused = new HashSet<BombDefused>();
            BombPlant = new HashSet<BombPlant>();
            BotTakeOver = new HashSet<BotTakeOver>();
            Damages = new HashSet<Damage>();
            DamagesReceived = new HashSet<Damage>();
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
            Deaths = new HashSet<Kill>();
            PlayerPosition = new HashSet<PlayerPosition>();
            RoundItem = new HashSet<RoundItem>();
            Smoke = new HashSet<Smoke>();
            WeaponFired = new HashSet<WeaponFired>();
            WeaponReload = new HashSet<WeaponReload>();
        }

        public long MatchId { get; set; }
        public short Round { get; set; }
        public long PlayerId { get; set; }
        public int PlayedEquipmentValue { get; set; }
        public int MoneyInitial { get; set; }
        public int MoneySaved { get; set; }
        public int MoneyEarned { get; set; }
        public int MoneySpent { get; set; }
        public int MoneyLost { get; set; }
        public int GiftedValue { get; set; }
        public int ReceivedGiftValue { get; set; }
        public bool IsCt { get; set; }
        public ArmorType ArmorType { get; set; }
        public short RoundStartKills { get; set; }
        public short RoundStartDeaths { get; set; }
        public short RoundStartAssists { get; set; }
        public short RoundStartScore { get; set; }
        public short RoundStartMvps { get; set; }
        public short RoundStartDamage { get; set; }

        [JsonIgnore]
        public MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public PlayerMatchStats PlayerMatchStats { get; set; }
        [JsonIgnore]
        public RoundStats RoundStats { get; set; }
        [JsonIgnore]
        public ICollection<BombDefused> BombDefused { get; set; }
        [JsonIgnore]
        public ICollection<BombPlant> BombPlant { get; set; }
        [JsonIgnore]
        public ICollection<BotTakeOver> BotTakeOver { get; set; }
        [JsonIgnore]
        public ICollection<Damage> Damages { get; set; }
        [JsonIgnore]
        public ICollection<Damage> DamagesReceived { get; set; }
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
        public ICollection<Kill> Deaths { get; set; }
        [JsonIgnore]
        public ICollection<PlayerPosition> PlayerPosition { get; set; }
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
