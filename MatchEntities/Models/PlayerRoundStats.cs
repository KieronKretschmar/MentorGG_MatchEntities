using MatchEntities.Enums;
using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class PlayerRoundStats :
        IMatchDataEntity,
        IRoundEntity
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
        public byte Round { get; set; }
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
        public virtual MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public virtual PlayerMatchStats PlayerMatchStats { get; set; }
        [JsonIgnore]
        public virtual RoundStats RoundStats { get; set; }
        [JsonIgnore]
        public virtual ICollection<BombDefused> BombDefused { get; set; }
        [JsonIgnore]
        public virtual ICollection<BombPlant> BombPlant { get; set; }
        [JsonIgnore]
        public virtual ICollection<BotTakeOver> BotTakeOver { get; set; }
        [JsonIgnore]
        public virtual ICollection<Damage> Damages { get; set; }
        [JsonIgnore]
        public virtual ICollection<Damage> DamagesReceived { get; set; }
        [JsonIgnore]
        public virtual ICollection<Decoy> Decoy { get; set; }
        [JsonIgnore]
        public virtual ICollection<FireNade> FireNade { get; set; }
        [JsonIgnore]
        public virtual ICollection<Flash> Flash { get; set; }
        [JsonIgnore]
        public virtual ICollection<Flashed> Flashed { get; set; }
        [JsonIgnore]
        public virtual ICollection<He> He { get; set; }
        [JsonIgnore]
        public virtual ICollection<HostageDrop> HostageDrop { get; set; }
        [JsonIgnore]
        public virtual ICollection<HostagePickUp> HostagePickUp { get; set; }
        [JsonIgnore]
        public virtual ICollection<HostageRescue> HostageRescue { get; set; }
        [JsonIgnore]
        public virtual ICollection<ItemDropped> ItemDropped { get; set; }
        [JsonIgnore]
        public virtual ICollection<ItemPickedUp> ItemPickedUp { get; set; }
        [JsonIgnore]
        public virtual ICollection<ItemSaved> ItemSaved { get; set; }
        [JsonIgnore]
        public virtual ICollection<Kill> Kills { get; set; }
        [JsonIgnore]
        public virtual ICollection<Kill> Deaths { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlayerJump> PlayerJump { get; set; }
        [JsonIgnore]
        public virtual ICollection<PlayerPosition> PlayerPosition { get; set; }
        [JsonIgnore]
        public virtual ICollection<RoundItem> RoundItem { get; set; }
        [JsonIgnore]
        public virtual ICollection<Smoke> Smoke { get; set; }
        [JsonIgnore]
        public virtual ICollection<WeaponFired> WeaponFired { get; set; }
        [JsonIgnore]
        public virtual ICollection<WeaponReload> WeaponReload { get; set; }
    }
}
