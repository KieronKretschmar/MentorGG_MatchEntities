using MatchEntities.Enums;
using MatchEntities.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace MatchEntities
{
    /// <summary>
    /// Holds data for an attempted BombPlant.
    /// </summary>
    public partial class BombPlant :
        IMatchDataEntity,
        IRoundEntity,
        IIngameEvent,
        IPlayerEvent
    {
        public long MatchId { get; set; }
        public byte Round { get; set; }
        public int StartTime { get; set; }

        /// <summary>
        /// The time at which the plant attempt finished, either by success or aborting.
        /// </summary>
        public int Time { get; set; }
        public long PlayerId { get; set; }
        public BombSite Site { get; set; }
        public bool Success { get; set; }
        public bool IsCt { get; set; }
        private float PlayerPosX { get; set; }
        private float PlayerPosY { get; set; }
        private float PlayerPosZ { get; set; }
        public Vector3 PlayerPos
        {
            get
            {
                return new Vector3(PlayerPosX, PlayerPosY, PlayerPosZ);
            }

            set
            {
                PlayerPosX = value.X;
                PlayerPosY = value.Y;
                PlayerPosZ = value.Z;
            }
        }
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

        public int PlantZone { get; set; }

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
