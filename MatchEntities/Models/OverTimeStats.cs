using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class OverTimeStats : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public byte StartT { get; set; }
        public byte StartCt { get; set; }
        public int StartMoney { get; set; }
        public short NumRounds { get; set; }

        [JsonIgnore]
        public virtual MatchStats MatchStats { get; set; }
    }
}
