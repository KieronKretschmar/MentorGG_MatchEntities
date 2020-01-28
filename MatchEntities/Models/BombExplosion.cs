using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class BombExplosion : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }

        [JsonIgnore]
        public MatchStats MatchStats { get; set; }
        [JsonIgnore]
        public RoundStats RoundStats { get; set; }
    }
}
