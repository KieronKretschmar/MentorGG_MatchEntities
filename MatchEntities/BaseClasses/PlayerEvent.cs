using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MatchEntities
{
    public abstract class PlayerEvent : InGameEvent
    {
        public bool IsCt { get; set; }
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


        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
    }

    public abstract class PlayerViewEvent : PlayerEvent
    {
        private float PlayerViewX { get; set; }
        private float PlayerViewY { get; set; }
        public Vector2 PlayerView
        {
            get
            {
                return new Vector2(PlayerViewX, PlayerViewY);
            }
            set
            {
                PlayerViewX = value.X;
                PlayerViewY = value.Y;
            }
        }
    }
}
