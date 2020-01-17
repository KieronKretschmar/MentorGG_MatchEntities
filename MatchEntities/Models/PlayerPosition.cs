using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class PlayerPosition : IMatchDataEntity
    {
        public long MatchId { get; set; }
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
        private float PlayerVeloX { get; set; }
        private float PlayerVeloY { get; set; }
        private float PlayerVeloZ { get; set; }
        private Vector3 _playerVelo;
        public Vector3 PlayerVelo
        {
            get
            {
                if (_playerVelo == null)
                    _playerVelo = new Vector3(PlayerVeloX, PlayerVeloY, PlayerVeloZ);

                return _playerVelo;
            }

            set
            {
                PlayerVeloX = value.X;
                PlayerVeloY = value.Y;
                PlayerVeloZ = value.Z;
            }
        }
        public short Weapon { get; set; }

        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
    }
}
