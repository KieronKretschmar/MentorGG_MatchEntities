using MatchEntities.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class ItemSaved : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public short Round { get; set; }
        public long PlayerId { get; set; }
        public bool IsCt { get; set; }
        public long ItemSavedId { get; set; }
        public long ItemId { get; set; }
        public EquipmentElement Equipment { get; set; }

        [JsonIgnore]
        public MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public PlayerMatchStats PlayerMatchStats { get; set; }
        [JsonIgnore]
        public PlayerRoundStats PlayerRoundStats { get; set; }
        [JsonIgnore]
        public RoundStats RoundStats { get; set; }
    }
}
