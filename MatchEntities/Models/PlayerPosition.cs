using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class PlayerPosition : PlayerViewEvent
    {
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
    }
}
