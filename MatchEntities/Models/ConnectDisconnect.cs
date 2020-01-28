using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class ConnectDisconnect : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public long ConnectDisconnectId { get; set; }
        public short Round { get; set; }
        public long PlayerId { get; set; }
        public int Time { get; set; }
        public bool Connect { get; set; }

        [JsonIgnore]
        public MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public PlayerMatchStats PlayerMatchStats { get; set; }
        [JsonIgnore]
        public RoundStats RoundStats { get; set; }
    }
}
