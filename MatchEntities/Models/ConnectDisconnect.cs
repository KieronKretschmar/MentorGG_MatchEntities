using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class ConnectDisconnect :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent
        //Enable interfaces below by adding missing properties
        //IPlayerEvent
    {
        public long MatchId { get; set; }
        public long ConnectDisconnectId { get; set; }
        public short Round { get; set; }
        public long PlayerId { get; set; }
        public int Time { get; set; }
        public bool Connect { get; set; }

        [JsonIgnore]
        public virtual MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public virtual PlayerMatchStats PlayerMatchStats { get; set; }
        [JsonIgnore]
        public virtual RoundStats RoundStats { get; set; }
    }
}
