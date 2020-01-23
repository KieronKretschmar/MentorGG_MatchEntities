using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class Smoke : IMatchDataEntity
    {
        public long MatchId { get; set; }
        public long GrenadeId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }
        public long PlayerId { get; set; }
        private float PlayerPosX { get; set; }
        private float PlayerPosY { get; set; }
        private float PlayerPosZ { get; set; }
        private Vector3 _playerPos;
        public Vector3 PlayerPos
        {
            get
            {
                if (_playerPos == null)
                    _playerPos = new Vector3(PlayerPosX, PlayerPosY, PlayerPosZ);

                return _playerPos;
            }

            set
            {
                PlayerPosX = value.X;
                PlayerPosY = value.Y;
                PlayerPosZ = value.Z;
            }
        }
        public float PlayerViewX { get; set; }
        public float PlayerViewY { get; set; }
        public bool IsCt { get; set; }
        private float GrenadePosX { get; set; }
        private float GrenadePosY { get; set; }
        private float GrenadePosZ { get; set; }
        private Vector3 _grenadePos;
        public Vector3 GrenadePos
        {
            get
            {
                if (_grenadePos == null)
                    _grenadePos = new Vector3(GrenadePosX, GrenadePosY, GrenadePosZ);

                return _grenadePos;
            }

            set
            {
                GrenadePosX = value.X;
                GrenadePosY = value.Y;
                GrenadePosZ = value.Z;
            }
        }
        public int Category { get; set; }
        public int Target { get; set; }
        public TargetResult Result { get; set; }
        public string Trajectory { get; set; }

        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
    }
}
