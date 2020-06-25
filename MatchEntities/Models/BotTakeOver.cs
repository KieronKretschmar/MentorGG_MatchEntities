using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class BotTakeOver :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent
    {
        public long MatchId { get; set; }
        public long BotTakeOverId { get; set; }
        public long PlayerId { get; set; }
        public long BotId { get; set; }
        public byte Round { get; set; }
        public int Time { get; set; }

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
