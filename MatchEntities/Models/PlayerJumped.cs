using MatchEntities.Enums;
using MatchEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class PlayerJump : PlayerViewEvent,
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent
    {
        private float PlayerVeloX { get; set; }
        private float PlayerVeloY { get; set; }
        private float PlayerVeloZ { get; set; }
        public Vector3 PlayerVelo
        {
            get
            {
                return new Vector3(PlayerVeloX, PlayerVeloY, PlayerVeloZ);
            }
            set
            {
                PlayerVeloX = value.X;
                PlayerVeloY = value.Y;
                PlayerVeloZ = value.Z;
            }
        }
    }
}
