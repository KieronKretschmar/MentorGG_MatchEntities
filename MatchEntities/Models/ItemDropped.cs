using MatchEntities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class ItemDropped : IMatchDataEntity
    {
        public ItemDropped()
        {
            ItemPickedUp = new HashSet<ItemPickedUp>();
        }

        public long MatchId { get; set; }
        public short Round { get; set; }
        public long PlayerId { get; set; }
        public bool IsCt { get; set; }
        public long ItemDroppedId { get; set; }
        public long ItemId { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }
        public EquipmentElement Equipment { get; set; }
        public bool ByDeath { get; set; }
        public bool Gift { get; set; }

        [JsonIgnore]
        public MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public PlayerMatchStats PlayerMatchStats { get; set; }
        [JsonIgnore]
        public PlayerRoundStats PlayerRoundStats { get; set; }
        [JsonIgnore]
        public RoundStats RoundStats { get; set; }
        [JsonIgnore]
        public ICollection<ItemPickedUp> ItemPickedUp { get; set; }
    }
}
