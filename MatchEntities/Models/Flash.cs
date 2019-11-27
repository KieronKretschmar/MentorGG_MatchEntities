﻿using System;
using System.Collections.Generic;

namespace MatchEntities
{
    public partial class Flash : IMatchDataEntity
    {
        public Flash()
        {
            Flashed = new HashSet<Flashed>();
        }

        public long MatchId { get; set; }
        public long GrenadeId { get; set; }
        public short Round { get; set; }
        public int Time { get; set; }
        public int Tick { get; set; }
        public long PlayerId { get; set; }
        public double PlayerPosX { get; set; }
        public double PlayerPosY { get; set; }
        public double PlayerPosZ { get; set; }
        public double PlayerViewX { get; set; }
        public double PlayerViewY { get; set; }
        public bool IsCt { get; set; }
        public double GrenadePosX { get; set; }
        public double GrenadePosY { get; set; }
        public double GrenadePosZ { get; set; }
        public int DetonationZoneByTeam { get; set; }
        public string Trajectory { get; set; }

        public MatchStats MatchStats { get; set; }
        public PlayerMatchStats PlayerMatchStats { get; set; }
        public PlayerRoundStats PlayerRoundStats { get; set; }
        public RoundStats RoundStats { get; set; }
        public ICollection<Flashed> Flashed { get; set; }
    }
}