using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Flashed : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public long GrenadeId { get; set; }
        public long VictimId { get; set; }
        public short Round { get; set; }
        private float VictimPosX { get; set; }
        private float VictimPosY { get; set; }
        private float VictimPosZ { get; set; }
        public Vector3 VictimPos
        {
            get
            {
                return new Vector3(VictimPosX, VictimPosY, VictimPosZ);
            }

            set
            {
                VictimPosX = value.X;
                VictimPosY = value.Y;
                VictimPosZ = value.Z;
            }
        }
        public float VictimViewX { get; set; }
        public float VictimViewY { get; set; }
        public bool IsCt { get; set; }
        public int TimeFlashed { get; set; }
        public bool TeamAttack { get; set; }
        public long? AssistedKillId { get; set; }
        public int? TimeUntilAssistedKill { get; set; }
        public int AngleToCrosshair { get; set; }

        [JsonIgnore]
        public Flash Flash { get; set; }
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
