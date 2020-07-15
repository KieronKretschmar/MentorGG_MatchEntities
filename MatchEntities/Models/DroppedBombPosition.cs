using MatchEntities.Enums;
using MatchEntities.Interfaces;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class DroppedBombPosition : InGameEvent,
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent
    {

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
    }
}
