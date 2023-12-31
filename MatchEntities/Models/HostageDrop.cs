﻿using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    public partial class HostageDrop :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent
        //Enable interfaces below by adding IsCt property
        //IPlayerEvent
    {
        public long MatchId { get; set; }
        public byte Round { get; set; }
        public int Time { get; set; }
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
