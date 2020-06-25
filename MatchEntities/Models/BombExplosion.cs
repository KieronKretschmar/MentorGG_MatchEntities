using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class BombExplosion :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent
    {
        public long MatchId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }

        [JsonIgnore]
        public virtual MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public virtual RoundStats RoundStats { get; set; }
    }
}
