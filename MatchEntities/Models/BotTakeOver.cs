using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class BotTakeOver : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public long BotTakeOverId { get; set; }
        public long PlayerId { get; set; }
        public long BotId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }

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
