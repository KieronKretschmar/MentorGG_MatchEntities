using MatchEntities.Enums;
using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class ItemPickedUp :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent
        //Enable interfaces below by adding missing properties
        //IPlayerEvent
    {
        public long MatchId { get; set; }
        public short Round { get; set; }
        public long PlayerId { get; set; }
        public bool IsCt { get; set; }
        public long ItemPickedUpId { get; set; }
        public long ItemId { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }
        public EquipmentElement Equipment { get; set; }
        public long? ItemDroppedId { get; set; }
        public bool Gift { get; set; }
        public bool Buy { get; set; }

        [JsonIgnore]
        public virtual ItemDropped ItemDropped { get; set; }
        [JsonIgnore]
        public virtual MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public virtual PlayerMatchStats PlayerMatchStats { get; set; }
        [JsonIgnore]
        public virtual PlayerRoundStats PlayerRoundStats { get; set; }
        [JsonIgnore]
        public virtual RoundStats RoundStats { get; set; }
    }
}
