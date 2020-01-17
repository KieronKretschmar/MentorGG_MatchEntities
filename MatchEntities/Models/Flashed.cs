using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class Flashed : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public long GrenadeId { get; set; }
        public long VictimId { get; set; }
        public short Round { get; set; }
        public float VictimPosX { get; set; }
        public float VictimPosY { get; set; }
        public float VictimPosZ { get; set; }
        public float VictimViewX { get; set; }
        public float VictimViewY { get; set; }
        public bool IsCt { get; set; }
        public int TimeFlashed { get; set; }
        public bool TeamAttack { get; set; }
        public long? AssistedKillId { get; set; }
        public int? TimeUntilAssistedKill { get; set; }
        public int AngleToCrosshair { get; set; }

        public Flash Flash { get; set; }
        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
    }
}
