﻿using MatchEntities.Enums;
using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class ItemSaved :
        IMatchDataEntity,
        IRoundEntity
        //Enable interfaces below by adding missing properties
        //IIngameEvent,
        //IPlayerEvent
    {
        public long MatchId { get; set; }
        public short Round { get; set; }
        public long PlayerId { get; set; }
        public bool IsCt { get; set; }
        public long ItemSavedId { get; set; }
        public long ItemId { get; set; }
        public EquipmentElement Equipment { get; set; }

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
