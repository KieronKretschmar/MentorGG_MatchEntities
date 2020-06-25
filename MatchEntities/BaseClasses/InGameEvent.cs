using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MatchEntities
{
    public abstract class InGameEvent: IIngameEvent
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
