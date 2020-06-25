using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Flashed :
        IMatchDataEntity,
        IRoundEntity
        //Enable interfaces below by adding Time property
        //IIngameEvent,
        //IPlayerEvent,
        //IVictimEvent
    {
        public long MatchId { get; set; }
        public long GrenadeId { get; set; }
        public long VictimId { get; set; }
        public byte Round { get; set; }
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
        public virtual Flash Flash { get; set; }
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
