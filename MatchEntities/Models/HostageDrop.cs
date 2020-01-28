using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class HostageDrop : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }
        public long PlayerId { get; set; }
        private float PosX { get; set; }
        private float PosY { get; set; }
        private float PosZ { get; set; }
        public Vector3 Pos
        {
            get
            {
                return new Vector3(PosX, PosY, PosZ);
            }

            set
            {
                PosX = value.X;
                PosY = value.Y;
                PosZ = value.Z;
            }
        }

        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
    }
}
